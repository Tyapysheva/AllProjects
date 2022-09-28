using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightCalculation.Interface
{
    internal interface IFlyable
    {
        public double FlyTo(Coordinate newCoordinate);
        public double GetFlyTime(Coordinate newCoordinate);
    }
}
