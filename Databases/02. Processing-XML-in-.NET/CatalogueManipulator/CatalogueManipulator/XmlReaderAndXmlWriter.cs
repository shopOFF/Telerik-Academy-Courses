using System;
using System.Text;
using System.Xml;

namespace CatalogueManipulator
{
    public class XmlReaderAndXmlWriter
    {
        public void CreateAlbumsXml()
        {
            var url = "../../catalog.xml";
            var writer = new XmlTextWriter("../../albums.xml", Encoding.UTF8);
            writer.WriteStartDocument();
            writer.WriteStartElement("albums");
            Console.WriteLine("Using XmlReader And XmlWriter reads the file catalog.xml and creates the file album.xml:\n");

            using (var reader = XmlReader.Create(url))
            {
                while (reader.Read())
                {
                    writer.Formatting = Formatting.Indented;
                    writer.IndentChar = '\t';
                    writer.Indentation = 1;

                    switch (reader.Name)
                    {
                        case "album":
                            if (reader.IsStartElement())
                            {
                                writer.WriteStartElement("album");
                            }

                            break;
                        case "name":
                            writer.WriteElementString("title", reader.ReadElementContentAsString());
                            break;
                        case "artist":
                            writer.WriteElementString("artist", reader.ReadElementContentAsString());
                            writer.WriteEndElement();
                            break;
                    }
                }
            }

            writer.WriteEndElement();
            writer.WriteEndDocument();
            writer.Close();

            Console.WriteLine("{0}", new string('-', 50));
        }
    }
}
