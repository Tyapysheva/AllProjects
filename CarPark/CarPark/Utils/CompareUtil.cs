using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarPark.CarException;
using CarPark.TransportParts.Enum;
using CarPark.TransportType;

namespace CarPark.Utils
{
    public static class CompareUtil
    {
        public static void CheckFieldWithSign(string fieldName, double currentValue, CompareSign sign, double number)
        {
            switch (sign)
            {
                case CompareSign.Greater:
                    if (currentValue < number)
                    {
                        throw new InitializationException($"{fieldName} value={currentValue} must be greater than {number}");
                    }
                    else
                    {
                        break;
                    }
                case CompareSign.Less:
                    if (currentValue > number)
                    {
                        throw new InitializationException($"{fieldName} value={currentValue} must be less than {number}");
                    }
                    else
                    {
                        break;
                    }
                default:
                    break;
            }
        }
        public static void CheckFieldNotNull(string fieldName, object fieldValue)
        {
            if (fieldValue.Equals(null))
            {
                throw new InitializationException($"{fieldName} must be not null");
            }
        }
        public static void CheckTypeEngine(string fieldName, object fieldValue, TypeEngine type)
        {
            if (!fieldValue.Equals(type))
            {
                throw new InitializationException($"{fieldName} must be {type}");
            }
        }
        public static void CheckTypeTransmission(string fieldName, Type type, TypeTransmission currentType)
        {
            switch (currentType)
            {
                case TypeTransmission.Manual:
                case TypeTransmission.Automatic:
                    if (typeof(Scooter).Equals(type))
                    {
                        throw new InitializationException($"{fieldName} must be {currentType}");
                    }
                    else
                    {
                        break;
                    }
                case TypeTransmission.ContinuoslyVariable:
                    if (type.Equals(typeof(Truck)) || type.Equals(typeof(Bus)))
                    {
                        throw new InitializationException($"{fieldName} must be {currentType}");
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
