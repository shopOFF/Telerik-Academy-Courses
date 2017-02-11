using System;
using System.IO;
using System.Text;
using System.Xml;

namespace CatalogueManipulator
{
    public class Phonebook
    {
        public void CreatePhonebook()
        {
            var url = "../../phonebook.txt";
            int lineNumber = 0;
            var writer = new XmlTextWriter("../../phonebook.xml", Encoding.UTF8);
            writer.WriteStartDocument();
            writer.WriteStartElement("entries");
            Console.WriteLine("Read from phonebook.txt data and create new XML document with the data:\n");

            using (var reader = new StreamReader(url))
            {
                while (!reader.EndOfStream)
                {
                    switch (lineNumber % 3)
                    {
                        case 0:
                            writer.WriteStartElement("entry");
                            writer.WriteElementString("name", reader.ReadLine());
                            break;
                        case 1:
                            writer.WriteElementString("address", reader.ReadLine());
                            break;
                        case 2:
                            writer.WriteElementString("phone", reader.ReadLine());
                            writer.WriteEndElement();
                            break;
                    }

                    lineNumber++;
                }
            }

            writer.WriteEndElement();
            writer.WriteEndDocument();
            writer.Close();
            writer.Dispose();

            Console.WriteLine("{0}", new string('-', 50));
        }
    }
}
