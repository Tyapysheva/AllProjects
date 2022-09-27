using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarPark.transport_parts;
using CarPark.transport_type;
using System.Xml;

namespace CarPark.utility
{
    public class SorterTransportUtility
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

            List<Transport> listTransport = new List<Transport>();

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
