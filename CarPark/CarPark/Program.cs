using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Runtime.Intrinsics.X86;
using System.Xml;
using System.Xml.Serialization;
using CarPark.transport_parts;
using CarPark.transport_type;
using CarPark.utility;
using CarPark.xml;

namespace Carpark
{
    class Program
    {
        static void Main(string[] args)
        {
            Engine engine = new Engine(400F, 20.0F, TypeEngine.TruckEngine, 123);
            Chassis chassis = new Chassis(16, 43, 55000);
            Transmission transmission = new Transmission(TypeTransmission.Manual, 7, "manufacture");
            Truck truck = new Truck(engine, chassis, transmission);

            Engine engine1 = new Engine(230F, 6.0F, TypeEngine.BusEngine, 125);
            Chassis chassis1 = new Chassis(8, 46, 11000);
            Transmission transmission1 = new Transmission(TypeTransmission.Automatic, 4, "manufacture");
            Bus bus = new Bus(engine1, chassis1, transmission1);

            Engine engine2 = new Engine(50F, 0.04F, TypeEngine.ScooterEngine, 12790);
            Chassis chassis2 = new Chassis(2, 23, 250);
            Transmission transmission2 = new Transmission(TypeTransmission.ContinuoslyVariable, 2, "manufacture");
            Scooter scooter = new Scooter(engine2, chassis2, transmission2);

            Engine engine3 = new Engine(200F, 4F, TypeEngine.CarEngine, 127);
            Chassis chassis3 = new Chassis(4, 30, 6000);
            Transmission transmission3 = new Transmission(TypeTransmission.ContinuoslyVariable, 15, "manufacture");
            PassengerCar passengerCar = new PassengerCar(engine3, chassis3, transmission3);

            Engine engine4 = new Engine(200F, 4F, TypeEngine.CarEngine, 129);
            Chassis chassis4 = new Chassis(4, 30, 6000);
            Transmission transmission4 = new Transmission(TypeTransmission.Automatic, 15, "manufacture");
            PassengerCar passengerCar2 = new PassengerCar(engine4, chassis4, transmission4);

            List<Transport> listTransport = new List<Transport>();

            List<Transport> truckAndBus = new List<Transport>();
            truckAndBus.AddRange(SorterTransportUtility.selectTransportFromListByType(listTransport, typeof(Bus)));
            truckAndBus.AddRange(SorterTransportUtility.selectTransportFromListByType(listTransport, typeof(Truck)));

            List<Transport> testList = new List<Transport>();
            testList.Add(truck);
            testList.Add(bus);
            testList.Add(scooter);
            testList.Add(passengerCar);


            TransportCollectionUtility transportCollection = new TransportCollectionUtility(testList);
            foreach (var transport in transportCollection)
            {
                Console.WriteLine(transport);
            }
            transportCollection.GetTransportByParameter("power", "400");
               
            foreach (var transport in transportCollection.UpdateTransportWithSerialNumber(passengerCar2, 127)) 
            {
                Console.WriteLine(transport);
            }


         //   WorkWithXML.WritePowerTypeNumberOfEngineInXml(truckAndBus, "Sortedfile.xml");
            WorkWithXML.WriteTransportsToXml(SorterTransportUtility.selectTransportWithEngineCapacity(testList, 1.5), "transport.xml");
           // WorkWithXML.WriteTransportsGroupByToXml(SorterTransportUtility.selectTransportGroupByTransmissionType(listTransport), "group.xml");
        }


    }

}

