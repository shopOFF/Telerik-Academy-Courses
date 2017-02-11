using System;
using System.Collections;
using System.Xml;

namespace CatalogueManipulator
{
    public class DomParserExtractor
    {
        public void DomParserExtractorMethod()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("../../catalog.xml");
            XmlNode rootNode = doc.DocumentElement;
            Hashtable artists = new Hashtable();
            Console.WriteLine("Using DOM parser:\n");

            foreach (XmlNode node in rootNode.ChildNodes)
            {
                foreach (XmlNode item in node)
                {
                    artists.Add(item["name"].InnerText, item["artist"].InnerText);
                }

                foreach (string key in artists.Keys)
                {
                    Console.WriteLine("Artist - {0} ---> Album - {1}", artists[key], key);
                }
            }

            Console.WriteLine("{0}", new string('-', 50));
        }
    }
}
