using System;
using System.Collections;
using System.Xml;

namespace CatalogueManipulator
{
    public class XPathExtractor
    {
        public void XPathExtractorMethod()
        {
            var url = "../../catalog.xml";
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(url);

            string xPathQuery = "/catalog/albums/album";
            XmlNodeList albumsList = xmlDoc.SelectNodes(xPathQuery);

            Hashtable artists = new Hashtable();
            Console.WriteLine("Using XPath:\n");

            foreach (XmlNode artistNode in albumsList)
            {
                artists.Add(artistNode["name"].InnerText, artistNode["artist"].InnerText);
            }

            foreach (string key in artists.Keys)
            {
                Console.WriteLine("Artist - {0} ---> Album - {1}", artists[key], key);
            }

            Console.WriteLine("{0}", new string('-', 50));
        }
    }
}
