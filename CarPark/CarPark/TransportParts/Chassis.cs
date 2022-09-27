using CarPark.utility;

namespace CarPark.transport_parts
{
    public class Chassis
    {
        public int numberOfWheels;
        private long number;
        private float permissibleLoad;


        public Chassis()
        {

        }

        public Chassis(int numberOfWheels, long number, float permissibleLoad)
        {
            NumberOfWheels = numberOfWheels;
            Number = number;
            PermissibleLoad = permissibleLoad;
        }

        public virtual int NumberOfWheels { get => numberOfWheels; 
            set
            {
                CompareUtil.CheckFieldWithSign("Number Of Wheels", value, CompareSign.Greater, 0);
                numberOfWheels = value;
            }
        }
        public virtual long Number { get => number; 
            set
            {
                CompareUtil.CheckFieldWithSign("Number", value, CompareSign.Greater, 0);
                number = value;
            }
        }
        public virtual float PermissibleLoad { get => permissibleLoad; 
            set
            {
                CompareUtil.CheckFieldWithSign("Permissible Load", value, CompareSign.Greater, 0);
                permissibleLoad = value;
            }
        }
        public override string? ToString()
        {

            return "\nChassis: \nNumber = " + Number +
                "; Number Of Wheels = " + NumberOfWheels + "; Permissible Load = " + PermissibleLoad;
        }
    }
}

