using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.ComponentModel;
using System.Xml.Linq;
using System.Xml.Serialization;
using System.IO;
using CarPark.TransportType;
using CarPark.TransportParts.Enum;

namespace CarPark.Xml
{
    public class WorkWithXML
    {
        private static string startElement = "Transport";
        public static void WriteTransportsToXml(List<Transport> transports, string fileName)
        {
            using (XmlWriter writer = CreateXMLDocAndStartElement(fileName, startElement))
            {
                foreach (Transport transport in transports)
                {
                    var serializer = new XmlSerializer(transport.GetType());
                    serializer.Serialize(writer, transport, GetXMLNamespace());
                    Console.WriteLine("Object has been serialized");
                }
            }
        }
        public static void WriteTransportsGroupByToXml(List<IGrouping<TypeTransmission, Transport>> transports, string fileName)
        {

            using (XmlWriter writer = CreateXMLDocAndStartElement(fileName, startElement))
            {
                foreach (var group in transports)
                {
                    writer.WriteStartElement("Group");
                    writer.WriteAttributeString("name", $"{group.Key}");
                    foreach (Transport transport in group)
                    {
                        var serializer = new XmlSerializer(transport.GetType());
                        serializer.Serialize(writer, transport, GetXMLNamespace());
                        Console.WriteLine("Object has been serialized");
                    }
                    writer.WriteEndElement();
                }
            }
        }
        public static void WritePowerTypeNumberOfEngineInXml(List<Transport> list, string fileName)
        {

            XmlDocument xmlDoc = new XmlDocument();
            XmlNode rootNode = xmlDoc.CreateElement(nameof(Transport));
            xmlDoc.AppendChild(rootNode);
            foreach (var transport in list)
            {
                XmlNode transportNode = xmlDoc.CreateElement(transport.GetType().Name);
                XmlNode engineNode = xmlDoc.CreateElement(transport.Engine.GetType().Name);

                XmlNode typeEngineNode = xmlDoc.CreateElement(transport.Engine.TypeEngine.GetType().Name);
                typeEngineNode.InnerText = transport.Engine.TypeEngine.ToString();
                engineNode.AppendChild(typeEngineNode);

                XmlNode powerEngineNode = xmlDoc.CreateElement("Power");
                powerEngineNode.InnerText = transport.Engine.Power.ToString();
                engineNode.AppendChild(powerEngineNode);

                XmlNode serialNumberEngineNode = xmlDoc.CreateElement("SerialNumber");
                serialNumberEngineNode.InnerText = transport.Engine.SerialNumber.ToString();
                engineNode.AppendChild(serialNumberEngineNode);

                transportNode.AppendChild(engineNode);
                rootNode.AppendChild(transportNode);
            }
            xmlDoc.Save(fileName);
        }
        private static XmlWriterSettings GetXMLSettings()
        {
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.OmitXmlDeclaration = false;
            settings.CloseOutput = false;
            return settings;
        }
        private static XmlSerializerNamespaces GetXMLNamespace()
        {
            XmlSerializerNamespaces ns = new XmlSerializerNamespaces();
            ns.Add("", "");
            return ns;
        }
        private static XmlWriter CreateXMLDocAndStartElement(string fileName, string startElem)
        {
            XmlWriter writer = XmlWriter.Create(fileName, GetXMLSettings());
            writer.WriteStartDocument();
            writer.WriteStartElement(startElem);
            return writer;
        }
    }
}






