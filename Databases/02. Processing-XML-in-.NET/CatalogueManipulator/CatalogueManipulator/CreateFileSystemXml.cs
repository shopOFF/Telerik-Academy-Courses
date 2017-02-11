using System;
using System.IO;
using System.Linq;
using System.Xml;
using System.Xml.Linq;

namespace CatalogueManipulator
{
    public class CreateFileSystemXml
    {
        public static XElement CreateFileSystemXmlTree(string source)
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(source);
            var result = new XElement(
                "Dir",
                new XAttribute("Name", directoryInfo.Name),
                Directory.GetDirectories(source).Select(dir => CreateFileSystemXmlTree(dir)),
                directoryInfo.GetFiles().Select(fileName => new XElement("File", new XAttribute("Name", fileName.Name), new XAttribute("Size", fileName.Length))));

            return result;
        }

        public static void CreateFileSystemXmlTreeUsingXmlWriter(string source, XmlWriter writer)
        {
            var directoryInfo = new DirectoryInfo(source);
            var folders = directoryInfo.GetDirectories();

            foreach (var folder in folders)
            {
                writer.WriteStartElement("Dir");
                writer.WriteAttributeString("Name", folder.Name);
                CreateFileSystemXmlTreeUsingXmlWriter(folder.FullName, writer);
                writer.WriteEndElement();
            }

            var files = directoryInfo.GetFiles();
            foreach (var file in files)
            {
                writer.WriteStartElement("File");
                writer.WriteAttributeString("Name", file.Name);
                writer.WriteAttributeString("Size", file.Length.ToString());
                writer.WriteEndElement();
            }
        }
    }
}
