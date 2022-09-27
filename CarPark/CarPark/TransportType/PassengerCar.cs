using CarPark.transport_parts;
using CarPark.utility;

namespace CarPark.transport_type
{
    [Serializable]
    public class PassengerCar : Transport
    {
        public PassengerCar()
        {

        }
        public PassengerCar(Engine engine, Chassis chassis, Transmission transmission) : base(engine, chassis, transmission)
        {
            CheckEngine(engine);
            CheckChasis(chassis);
            CheckTransmission(transmission);
        }

        private void CheckEngine(Engine engine)
        {
            CompareUtil.CheckFieldWithSign("Passenger Car Engine power", engine.Power, CompareSign.Greater, 99);
            CompareUtil.CheckFieldWithSign("Passenger Car Engine power", engine.Power, CompareSign.Less, 260);
            CompareUtil.CheckFieldWithSign("Passenger Car Engine capacity", engine.Power, CompareSign.Greater, 1);
            CompareUtil.CheckFieldWithSign("Passenger Car Engine capacity", engine.Capacity, CompareSign.Less, 6);
            CompareUtil.CheckTypeEngine("Passenger Car Engine type", engine.TypeEngine, TypeEngine.CarEngine);
            this.engine = engine;

        }
        private void CheckTransmission(Transmission transmission)
        {
            CompareUtil.CheckTypeTransmission("Passenger Car Transmission type", typeof(PassengerCar), transmission.TypeTransmission);
            CompareUtil.CheckFieldWithSign("Passenger Car Transmission Number Of Gears", transmission.NumberOfGears, CompareSign.Greater, 3);
            CompareUtil.CheckFieldWithSign("Passenger Car Transmission Number Of Gears", transmission.NumberOfGears, CompareSign.Less, 18);

            this.transmission = transmission;
        }

        private void CheckChasis(Chassis chassis)
        {
            CompareUtil.CheckFieldWithSign("Passenger Car Chassis Permissible Load", chassis.PermissibleLoad, CompareSign.Greater, 5000);
            CompareUtil.CheckFieldWithSign("Passenger Car Chassis Permissible Load", chassis.PermissibleLoad, CompareSign.Less, 15000);
            CompareUtil.CheckFieldWithSign("Passenger Car Chassis Number Of Wheels", chassis.NumberOfWheels, CompareSign.Greater, 3);
            CompareUtil.CheckFieldWithSign("Passenger Car Chassis Number Of Wheels", chassis.NumberOfWheels, CompareSign.Less, 5);
            this.chassis = chassis;
        }
        public override string? ToString()
        {
            return "\nPassenger Car:" + Engine + Chassis + Transmission;
        }
    }
}

