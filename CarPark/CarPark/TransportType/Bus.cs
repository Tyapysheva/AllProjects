using System.Xml.Serialization;
using CarPark.transport_parts;
using CarPark.utility;

namespace CarPark.transport_type
{
    [Serializable]

    public class Bus : Transport
    {
        public Bus()
        {

        }
        public Bus(Engine engine, Chassis chassis, Transmission transmission) : base(engine, chassis, transmission)
        {
            CheckEngine(engine);
            CheckChasis(chassis);
            CheckTransmission(transmission);
        }

        private void CheckEngine(Engine engine)
        {
            CompareUtil.CheckFieldWithSign("Bus Engine power", engine.Power, CompareSign.Greater, 210);
            CompareUtil.CheckFieldWithSign("Bus Engine power", engine.Power, CompareSign.Less, 285);
            CompareUtil.CheckFieldWithSign("Bus Engine capacity", engine.Capacity, CompareSign.Greater, 3.5);
            CompareUtil.CheckFieldWithSign("Bus Engine capacity", engine.Capacity, CompareSign.Less, 8.5);
            CompareUtil.CheckTypeEngine("Bus Engine type", engine.TypeEngine, TypeEngine.BusEngine);
            this.engine = engine;

        }
        private void CheckTransmission(Transmission transmission)
        {
            CompareUtil.CheckTypeTransmission("Bus Transmission type", typeof(Bus), transmission.TypeTransmission);
            CompareUtil.CheckFieldWithSign("Bus Transmission Number Of Gears", transmission.NumberOfGears, CompareSign.Greater, 4);
            CompareUtil.CheckFieldWithSign("Bus Transmission Number Of Gears", transmission.NumberOfGears, CompareSign.Less, 11);

            this.transmission = transmission;
        }

        private void CheckChasis(Chassis chassis)
        {
            CompareUtil.CheckFieldWithSign("Bus Chassis Permissible Load", chassis.PermissibleLoad, CompareSign.Greater, 10000);
            CompareUtil.CheckFieldWithSign("Bus Chassis Permissible Load", chassis.PermissibleLoad, CompareSign.Less, 25000);
            CompareUtil.CheckFieldWithSign("Bus Chassis Number Of Wheels", chassis.NumberOfWheels, CompareSign.Greater, 3);
            CompareUtil.CheckFieldWithSign("Bus Chassis Number Of Wheels", chassis.NumberOfWheels, CompareSign.Less, 20);
            this.chassis = chassis;
        }
        public override string? ToString()
        {
            return "\nBus:" + Engine + Chassis + Transmission;
        }

    }


}

