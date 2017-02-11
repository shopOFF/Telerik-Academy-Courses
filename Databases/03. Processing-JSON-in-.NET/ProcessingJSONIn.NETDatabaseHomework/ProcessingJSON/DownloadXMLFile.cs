using System.Net;

namespace ProcessingJSON
{
    public class DownloadXMLFile
    {
        public void DownloadXMLFilesMethod()
        {
            var url = "../../rss.xml";
            var webClient = new WebClient();
            webClient.DownloadFile("https://www.youtube.com/feeds/videos.xml?channel_id=UCLC-vbm7OWvpbqzXaoAMGGw", url);
        }
    }
}
