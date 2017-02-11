using System;
using System.Text;
using System.Xml.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Linq;

namespace ProcessingJSON
{
    public class PrintVideoTitles
    {
        public void PrintVideoTitlesMethod()
        {
            Console.OutputEncoding = Encoding.UTF8;
            var url = "../../rss.xml";
            XDocument rss = XDocument.Load(url);

            var jsonFromXml = JsonConvert.SerializeObject(rss, Formatting.Indented);
            var jsonObj = JObject.Parse(jsonFromXml);

            var titles = jsonObj["feed"]["entry"].Select(entry => entry["title"]);
            Console.WriteLine("Titles of the videos:\n");

            foreach (var title in titles)
            {
                Console.WriteLine(title);
            }
        }
    }
}
