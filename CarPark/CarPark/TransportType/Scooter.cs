using CarPark.transport_parts;
using CarPark.utility;

namespace CarPark.transport_type
{
    [Serializable]
    public class Scooter : Transport
    {
        public Scooter()
        {

        }
        public Scooter(Engine engine, Chassis chassis, Transmission transmission) : base(engine, chassis, transmission)
        {
            CheckEngine(engine);
            CheckChasis(chassis);
            CheckTransmission(transmission);

        }

        private void CheckEngine(Engine engine)
        {
            CompareUtil.CheckFieldWithSign("Scooter Engine power", engine.Power, CompareSign.Greater, 45);
            CompareUtil.CheckFieldWithSign("Scooter Engine power", engine.Power, CompareSign.Less, 65);
            CompareUtil.CheckFieldWithSign("Scooter Engine capacity", engine.Power, CompareSign.Greater, 0.005);
            CompareUtil.CheckFieldWithSign("Scooter Engine capacity", engine.Capacity, CompareSign.Less, 1);
            CompareUtil.CheckTypeEngine("Scooter Engine type", engine.TypeEngine, TypeEngine.ScooterEngine);
            this.engine = engine;

        }
        private void CheckTransmission(Transmission transmission)
        {
            CompareUtil.CheckTypeTransmission("Scooter Transmission type", typeof(Scooter), transmission.TypeTransmission);
            CompareUtil.CheckFieldWithSign("Scooter Transmission Number Of Gears", transmission.NumberOfGears, CompareSign.Greater, 1);
            CompareUtil.CheckFieldWithSign("Scooter Transmission Number Of Gears", transmission.NumberOfGears, CompareSign.Less, 4);

            this.transmission = transmission;
        }

        private void CheckChasis(Chassis chassis)
        {
            CompareUtil.CheckFieldWithSign("Scooter Chassis Permissible Load", chassis.PermissibleLoad, CompareSign.Greater, 59);
            CompareUtil.CheckFieldWithSign("Scooter Chassis Permissible Load", chassis.PermissibleLoad, CompareSign.Less, 359);
            CompareUtil.CheckFieldWithSign("Scooter Chassis Number Of Wheels", chassis.NumberOfWheels, CompareSign.Greater, 1);
            CompareUtil.CheckFieldWithSign("Scooter Chassis Number Of Wheels", chassis.NumberOfWheels, CompareSign.Less, 3);
            this.chassis = chassis;
        }

        public override string? ToString()
        {
            return "\nScooter:" + Engine + Chassis + Transmission;
        }
    }

}


