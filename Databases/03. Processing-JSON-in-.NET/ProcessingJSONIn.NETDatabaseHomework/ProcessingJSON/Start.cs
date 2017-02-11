namespace ProcessingJSON
{
    public class Start
    {
        public static void Main()
        {
            var rssDownloader = new DownloadXMLFile();
            rssDownloader.DownloadXMLFilesMethod();

            var rssXmlToJson = new PrintVideoTitles();
            rssXmlToJson.PrintVideoTitlesMethod();

            var processingVideos = new ProcessingVideos();
            processingVideos.ProcessingVideosMethod();
        }
    }
}
