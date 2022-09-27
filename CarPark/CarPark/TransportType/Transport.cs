using System.Xml.Serialization;
using CarPark.transport_parts;
using CarPark.utility;

namespace CarPark.transport_type
{
    [Serializable]

    public abstract class Transport
    {
        protected Engine engine;
        protected Chassis chassis;
        protected Transmission transmission;

        protected string model;
        public Transport()
        {

        }

        public Transport(Engine engine, Chassis chassis, Transmission transmission)
        {
            Engine = engine;
            Chassis = chassis;
            Transmission = transmission;
        }

        public Engine Engine
        {
            get => engine;
            set
            {
                CompareUtil.CheckFieldNotNull("Engine", value);
                engine = value;
            }
        }

        public Chassis Chassis
        {
            get => chassis;
            set
            {
                CompareUtil.CheckFieldNotNull("Chassis", value);
                chassis = value;
            }
        }
        public Transmission Transmission
        {
            get => transmission;
            set
            {
                CompareUtil.CheckFieldNotNull("Transmission", value);
                transmission = value;
            }
        }
    }
}

