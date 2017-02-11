using System;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Schema;
using System.Xml.Xsl;

namespace CatalogueManipulator
{
    public class StartProgram
    {
        public static void Main()
        {
            // task 1 and 2
            var domParsExtract = new DomParserExtractor();
            domParsExtract.DomParserExtractorMethod();

            // task 3
            var xPathExtract = new XPathExtractor();
            xPathExtract.XPathExtractorMethod();

            // task 4
            var albumDelete = new AlbumDeleter();
            albumDelete.AlbumDeleterMethod();

            // task 5
            var xmlReaderTitleExtract = new XMLReaderSongTitleExtractor();
            xmlReaderTitleExtract.XMLReaderTitleExtractor();

            // task 6
            var xDocLinqTitleExtract = new XDocumentAndLINQQueryTitleExtractor();
            xDocLinqTitleExtract.XDocumentAndLINQQuerySongTitleExtractor();

            // task 8
            var albumsCreator = new XmlReaderAndXmlWriter();
            albumsCreator.CreateAlbumsXml();

            // task 9 
            using (var writer = new XmlTextWriter("../../traverseWithXmlWriter.xml", Encoding.UTF8))
            {
                writer.WriteStartDocument();
                writer.WriteStartElement("DirectoriesRoot");
                writer.Formatting = Formatting.Indented;
                writer.IndentChar = '\t';
                writer.Indentation = 1;
                CreateFileSystemXml.CreateFileSystemXmlTreeUsingXmlWriter("../../..", writer);
                writer.WriteEndElement();
                writer.WriteEndDocument();
                writer.Close();
            }

            // task 10
            var xDocument = new XDocument();
            xDocument.Add(CreateFileSystemXml.CreateFileSystemXmlTree("../../../"));
            xDocument.Save("../../traverseWithXElement.xml");

            // task 13 and 14
            var url = "../../catalog.xml";
            XslCompiledTransform catalogueXslt = new XslCompiledTransform();
            catalogueXslt.Load("../../catalog.xsl");
            catalogueXslt.Transform(url, "../../catalog.html");

            // task 16 
            string xsdMarkup = File.ReadAllText("../../catalog.xsd");
            XmlSchemaSet schemas = new XmlSchemaSet();
            schemas.Add(string.Empty, XmlReader.Create(new StringReader(xsdMarkup)));
            XDocument valid = XDocument.Load(url);
            XDocument invalid = new XDocument(
                new XElement(
                    "Root",
                    new XElement("Child1", "content1"),
                    new XElement("Child2", "content2")));
            Console.WriteLine(new string('-', 50));
            Console.WriteLine("Validating valid document:");
            bool errors = false;

            valid.Validate(schemas, (o, e) =>
            {
                Console.WriteLine("{0}", e.Message);
                errors = true;
            });

            Console.WriteLine("Valid {0}", errors ? "did not validate" : "validated");
            Console.WriteLine();
            Console.WriteLine("Validating invalid document:");
            errors = false;
            invalid.Validate(schemas, (o, e) =>
            {
                Console.WriteLine("{0}", e.Message);
                errors = true;
            });

            Console.WriteLine("doc2 {0}", errors ? "did not validate" : "validated");
        }
    }
}
