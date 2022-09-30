using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarPark.TransportParts;
using CarPark.TransportParts.Enum;
using System.Xml;
using CarPark.TransportType;

namespace CarPark.Utils
{
    public class SorterTransportUtil
    {
        public static List<Transport> selectTransportWithEngineCapacity(List<Transport> transports, double capacity)
        {
            List<Transport> sort = transports
                .Where(transport => transport.Engine.Capacity > capacity)
                .ToList();
            return sort;
        }
        public static List<IGrouping<TypeTransmission, Transport>> selectTransportGroupByTransmissionType(List<Transport> transports)
        {
            List<IGrouping<TypeTransmission, Transport>> groupByTransmission = transports
                .GroupBy(o => o.Transmission.TypeTransmission).OrderBy(o => o.Key).ToList();

            return groupByTransmission;
        }
        public static List<Transport> selectTransportFromListByType(List<Transport> transports, Type type)
        {
            List<Transport> listEngine = transports
                .Where(transport => transport.GetType().Equals(type))
                .ToList();
            return listEngine;
        }
    }
}
