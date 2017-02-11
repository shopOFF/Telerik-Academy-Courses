using System;
using System.Xml;

namespace CatalogueManipulator
{
    public class AlbumDeleter
    {
        public void AlbumDeleterMethod()
        {
            var url = "../../catalog.xml";
            XmlDocument doc = new XmlDocument();
            doc.Load(url);
            XmlNode rootNode = doc.DocumentElement;

            Console.WriteLine("Removing all albums with price more than $20.00:\n");

            foreach (XmlNode node in rootNode.ChildNodes)
            {
                foreach (XmlNode item in node)
                {
                    var trimedPrice = item["price"].InnerText.Substring(1);
                    if (Decimal.Parse(trimedPrice) > 20.00M)
                    {
                        // To use uncomment, BUT USE WITH CAUTION !
                        //node.RemoveChild(item);
                    }
                }
            }

            doc.Save(url);
            Console.WriteLine("All albums with price more than $20.00 have been removed");
            Console.WriteLine("{0}", new string('-', 50));
        }
    }
}
