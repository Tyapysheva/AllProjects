using FlightCalculation.exception;
using FlightCalculation.flyable_object.@abstract;
using FlightCalculation.@interface;

namespace FlightCalculation.flyable_object
{
    class Airplane : FlyableObject, IFlyable
    {
        private double velocity = 200;
        private double distance;
        private double time = 0;
        public Airplane(Coordinate currentCoordinate) : base(currentCoordinate)
        {
        }

        public double FlyTo(Coordinate newCoordinate)
        {
            distance = base.CalculateDistance(newCoordinate, CurrentCoordinate);
            Console.WriteLine($"\nAirplane fly from {CurrentCoordinate} to {newCoordinate} and distance = {distance}");
            CurrentCoordinate = newCoordinate;
            if (distance > 41467)
            {
                throw new IllegalArgumentException($"Airplane distance can not be more than [{distance}]");
            }
            return distance;
        }
        public double GetFlyTime(Coordinate newCoordinate)
        {
            distance = FlyTo(newCoordinate);
            time = distance / GetChangableVelocity();
            Console.WriteLine($"\nAirplane fly distnace [{distance}] in [{time}] at a average speed of [{velocity}]");
            return time;
        }

        public override double GetChangableVelocity()
        {
            double increase = Math.Ceiling(distance / 10);
            double sum = 200;
            for (int i = 1; i < increase; i++)
            {
                sum = sum + 10;
                velocity = velocity + sum;

            }
            velocity = velocity / increase;
            if (velocity > 900) {
                velocity = 900;
            }
          
            return velocity;
        }
    }

}
