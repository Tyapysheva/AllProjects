using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using CarPark.transport_type;
using System.ComponentModel;
using System.Xml.Linq;
using System.Xml.Serialization;
using System.IO;
using CarPark.transport_parts;

namespace CarPark.xml
{
    public class WorkWithXML
    {
        public static void WriteTransportsToXml(List<Transport> transports, string fileName)
        {
           
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.OmitXmlDeclaration = false;
            settings.CloseOutput = false;
            XmlSerializerNamespaces ns = new XmlSerializerNamespaces();
            ns.Add("", "");

            using (var writer = XmlWriter.Create(fileName, settings))
            {
                writer.WriteStartDocument();
                writer.WriteStartElement("Transport");

                foreach (Transport transport in transports)
                {
                    var serializer = new XmlSerializer(transport.GetType());
                    serializer.Serialize(writer, transport, ns);

                    Console.WriteLine("Object has been serialized");
                }
            }
        }

        public static void WriteTransportsGroupByToXml(List<IGrouping<TypeTransmission, Transport>> transports, string fileName)
        {
           
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.OmitXmlDeclaration = false;
            settings.CloseOutput = false;
            XmlSerializerNamespaces ns = new XmlSerializerNamespaces();
            ns.Add("", "");

            using (var writer = XmlWriter.Create(fileName, settings))
            {
                writer.WriteStartDocument();
                writer.WriteStartElement("Transport");

                foreach (var group in transports)
                {
                    writer.WriteStartElement("Group");
                    writer.WriteAttributeString("name", $"{group.Key.ToString()}");

                    foreach (Transport transport in group)
                    {
                        var serializer = new XmlSerializer(transport.GetType());
                        serializer.Serialize(writer, transport, ns);

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

                XmlNode numberEngineNode = xmlDoc.CreateElement("SerialNumber");
                numberEngineNode.InnerText = transport.Engine.SerialNumber.ToString();
                engineNode.AppendChild(numberEngineNode);

                transportNode.AppendChild(engineNode);
                rootNode.AppendChild(transportNode);
            }
            xmlDoc.Save(fileName);
        }

    }
}






