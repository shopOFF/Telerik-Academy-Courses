using System;
using System.Linq;
using System.Xml.Linq;

namespace CatalogueManipulator
{
    public class XDocumentAndLINQQueryTitleExtractor
    {
        public void XDocumentAndLINQQuerySongTitleExtractor()
        {
            var url = "../../catalog.xml";
            XDocument xDoc = XDocument.Load(url);
            var songTitlesUsingLinq = from songs in xDoc.Descendants("title") select songs.Value.Trim();

            Console.WriteLine("Using XDocument and LINQ extract all song titles:\n");
            Console.WriteLine(string.Join("\n", songTitlesUsingLinq));
            Console.WriteLine("{0}", new string('-', 50));
        }
    }
}
