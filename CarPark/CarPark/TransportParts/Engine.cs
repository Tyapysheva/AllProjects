using CarPark.utility;

namespace CarPark.transport_parts
{
    public class Engine
    {
        public float power;
        private float capacity;
        private TypeEngine typeEngine;
        private long serialNumber;

        public Engine()
        {
        }

        public Engine(float power, float capacity, TypeEngine typeEngine, long serialNumber)
        {
            Power = power;
            Capacity = capacity;
            TypeEngine = typeEngine;
            SerialNumber = serialNumber;
        }

        public float Power
        {
            get => power;
            set
            {
                CompareUtil.CheckFieldWithSign("Power", value, CompareSign.Greater, 0);
                power = value;
            }
        }
        public float Capacity
        {
            get => capacity;
            set
            {
                CompareUtil.CheckFieldWithSign("Capacity", value, CompareSign.Greater, 0);
                capacity = value;
            }
        }
        public TypeEngine TypeEngine
        {
            get => typeEngine;
            set
            {
                CompareUtil.CheckFieldNotNull("Type Engine", value);
                typeEngine = value;
            }
        }
        public long SerialNumber
        {
            get => serialNumber;
            set
            {
                CompareUtil.CheckFieldWithSign("Serial Number", value, CompareSign.Greater, 0);
                serialNumber = value;
            }
        }
        public override string? ToString()
        {
            return "\nEngine: \nType = " + TypeEngine +
                "; Capacity = " + Capacity + "; Power = " + Power + "; Serial number = " + SerialNumber;
        }

    }


}

