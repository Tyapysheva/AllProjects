using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using CarPark.CarException;
using CarPark.TransportParts;
using CarPark.TransportParts.Enum;
using CarPark.TransportType;

namespace CarPark.Utils
{
    public class TransportCollectionUtil : List<Transport>
    {
        private List<Transport> transports;
        private  List<string> foundObjects = new List<string>();
        private IList<Type> nonRecursiveTypes = new List<Type> {
            typeof(int),
            typeof(string),
            typeof(Single),
            typeof(float),
            typeof(byte),
            typeof(Int64),
            typeof(Int16),

            typeof(TypeEngine),
            typeof(TypeTransmission),
        };
        public TransportCollectionUtil(List<Transport> transports)
        {
            this.transports = transports;
        }
        public List<Transport> AddTransport(Transport transport)
        {
            if (transport == null)
            {
                throw new AddException($"Collection can't consists transport without required fields");
            }
            transports.Add(transport);
            Console.WriteLine($"Add {transport.GetType().Name}");
            return transports;
        }
        public List<Transport> UpdateTransportWithSerialNumber(Transport newTransport, long serialNumber)
        {
            var result = transports.Any(transport => transport.Engine.SerialNumber.Equals(serialNumber));
            if (result)
            {
                transports.RemoveAll(transport =>
                transport.Engine.SerialNumber.Equals(serialNumber));
                transports.Add(newTransport);
            }
            else
            {
                throw new UpdateException("Transport with this serialNumber doesn't exist");
            }
            return transports;
        }
        public List<Transport> RemoveTransportWithSerialNumber(Transport newTransport, long serialNumber)
        {
            var result = transports.Any(transport => transport.Engine.SerialNumber.Equals(serialNumber));
            if (result)
            {
                transports.RemoveAll(transport =>
                transport.Engine.SerialNumber.Equals(serialNumber));
            }
            else
            {
                throw new RemoveException("Transport with this serialNumber doesn't exist");
            }
            return transports;
        }
        public void GetTransportByParameter(string parameter, string value)
        {
            foreach (Transport transport in transports)
            {
                FindObjectsByParameter(transport, parameter, value);
            }
            if (!foundObjects.Any())
            {
                throw new GetTransportByParameterException($"Auto wasn't found by {parameter} = {value}");
            }
            Console.WriteLine($"Found tranport:");
            foundObjects.ForEach(x => Console.WriteLine(x.ToString()));

        }
        private IEnumerable<object> FindObjectsByParameter(object obj, string parameter, string value)
        {
            var fields = obj.GetType()
                .GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance)
                .ToList();
            foreach (var field in fields)
            {
                if (!nonRecursiveTypes.Contains(field.FieldType))
                {
                    FindObjectsByParameter(field.GetValue(obj), parameter, value);
                }
                else
                {
                    if (field.Name.ToLower() == parameter.ToLower() && field.GetValue(obj)?.ToString() == value)
                    {
                        foundObjects.Add(obj.ToString());
                        break;
                    }
                }
            }
            return foundObjects;
        }
    }
}
