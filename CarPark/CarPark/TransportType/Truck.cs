using System.Xml.Linq;
using CarPark.transport_parts;
using CarPark.utility;

namespace CarPark.transport_type
{

    [Serializable]
    public class Truck : Transport
    {
        public Truck() 
        {
            
        }
        public Truck(Engine engine, Chassis chassis, Transmission transmission) : base(engine, chassis, transmission)
        {
            CheckEngine(engine);
            CheckChasis(chassis);
            CheckTransmission(transmission);
        }

        private void CheckEngine(Engine engine)
        {
            CompareUtil.CheckFieldWithSign("Truck Engine power", engine.Power, CompareSign.Greater, 199);
            CompareUtil.CheckFieldWithSign("Truck Engine power", engine.Power, CompareSign.Less, 751);
            CompareUtil.CheckFieldWithSign("Truck Engine capacity", engine.Power, CompareSign.Greater, 6);
            CompareUtil.CheckFieldWithSign("Truck Engine capacity", engine.Capacity, CompareSign.Less, 21);
            CompareUtil.CheckTypeEngine("Truck Engine type", engine.TypeEngine, TypeEngine.TruckEngine);
            this.engine = engine;
        }
        private void CheckTransmission(Transmission transmission)
        {
            CompareUtil.CheckTypeTransmission("Truck Transmission type", typeof(Truck), transmission.TypeTransmission);
            CompareUtil.CheckFieldWithSign("Truck Transmission Number Of Gears", transmission.NumberOfGears, CompareSign.Greater, 4);
            CompareUtil.CheckFieldWithSign("Truck Transmission Number Of Gears", transmission.NumberOfGears, CompareSign.Less, 17);

            this.transmission = transmission;
        }

        private void CheckChasis(Chassis chassis)
        {
            CompareUtil.CheckFieldWithSign("Truck Chassis Permissible Load", chassis.PermissibleLoad, CompareSign.Greater, 25000);
            CompareUtil.CheckFieldWithSign("Truck Chassis Permissible Load", chassis.PermissibleLoad, CompareSign.Less, 70000);
            CompareUtil.CheckFieldWithSign("Truck Chassis Number Of Wheels", chassis.NumberOfWheels, CompareSign.Less, 32);
            this.chassis = chassis;
        }

        public override string? ToString()
        {

            return "\nTruck: " + Engine + Chassis + Transmission;
        }
    }
}
