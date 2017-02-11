using System;
using System.IO;
using System.Text;
using System.Xml;

namespace Phonebook
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

            using (var reader = new StreamReader(url))
            {
                while (!reader.EndOfStream)
                {
                    writer.Formatting = Formatting.Indented;
                    writer.IndentChar = '\t';
                    writer.Indentation = 1;

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
            Console.WriteLine("New XML Phonebook document has been created");
        }
    }
}
