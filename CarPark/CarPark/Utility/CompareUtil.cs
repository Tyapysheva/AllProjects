using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarPark.CarException;
using CarPark.transport_parts;
using CarPark.transport_type;

namespace CarPark.utility
{
    public static class CompareUtil
    {
        public static void CheckFieldWithSign(string fieldName, double obj, CompareSign sign, double num)
        {
            switch (sign)
            {
                case CompareSign.Greater:
                    if (obj < num)
                    {
                        throw new InitializationException($"{fieldName} value={obj} must be greater than {num}");
                    }
                    else
                    {
                        break;
                    }
                case CompareSign.Less:
                    if (obj > num)
                    {
                        throw new InitializationException($"{fieldName} value={obj} must be less than {num}");
                    }
                    else
                    {
                        break;
                    }

                default:
                    break;
            }
        }
        public static void CheckFieldNotNull(string fieldName, object obj)
        {
            if (obj.Equals(null))
            {
                throw new InitializationException($"{fieldName} must be not null");
            }
        }

        public static void CheckTypeEngine(string fieldName, object obj, TypeEngine type)
        {
            if (!obj.Equals(type))
            {
                throw new InitializationException($"{fieldName} must be {type}");
            }

        }

        public static void CheckTypeTransmission(string fieldName, Type obj, TypeTransmission type)
        {
            switch (type)
            {
                case TypeTransmission.Manual:
                case TypeTransmission.Automatic:

                    if (typeof(Scooter).Equals(obj))
                    {
                        throw new InitializationException($"{fieldName} must be {type}");
                    }
                    else
                    {
                        break;
                    }

                case TypeTransmission.ContinuoslyVariable:
                    if (obj.Equals(typeof(Truck)) || obj.Equals(typeof(Bus)))
                    {
                        throw new InitializationException($"{fieldName} must be {type}");
                    }
                    else
                    {
                        break;
                    }

                default:
                    break;
            }
        }
    }

    public enum CompareSign
    {
        Greater,
        Less
    }
}
