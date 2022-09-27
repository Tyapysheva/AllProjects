using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightCalculation.@interface
{
    internal interface IFlyable
    {
        public double FlyTo(Coordinate newCoordinate);
        public double GetFlyTime(Coordinate newCoordinate);
    }
}
