using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ProcessingJSON
{
    public class ProcessingVideos
    {
        public void ProcessingVideosMethod()
        {
            XDocument url = XDocument.Load("../../rss.xml");
            string jsonFromXml = JsonConvert.SerializeXNode(url, Formatting.Indented);
            var jsonObj = JObject.Parse(jsonFromXml);

            var template = new { id = string.Empty, title = string.Empty, published = string.Empty };
            var videos = jsonObj["feed"]["entry"].Select(video => JsonConvert.DeserializeAnonymousType(video.ToString(), template));
            var htmlCreator = new StreamWriter("../../videos.html");
            htmlCreator.Write("<html><head><title>Videos from Telerik RSS</title><meta charset=\"UTF-8\"></head><body>");

            foreach (var video in videos)
            {
                htmlCreator.WriteLine(
                    "<div style=\"display: inline-block;\"><iframe width=420 height=315 src=\"https://www.youtube.com/embed/"
                    + video.id.Substring(video.id.LastIndexOf(":") + 1) + "\"></iframe><br />"
                    + "<a style=\"text-decoration: none; font-family: Arial; color: #444;\""
                    + " href=\"https://youtu.be/"
                    + video.id.Substring(video.id.LastIndexOf(":") + 1) + "\" target=\"_blank\">" + video.title + "</a></div"
                    + ">");
            }

            htmlCreator.Write("</body></html>");
            htmlCreator.Close();
        }
    }
}
