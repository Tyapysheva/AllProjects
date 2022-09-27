using FlightCalculation.exception;
using FlightCalculation.flyable_object.@abstract;
using FlightCalculation.@interface;

namespace FlightCalculation.flyable_object
{
    class Drone : FlyableObject,IFlyable
    {
        private double velocity = 260;
        private double distance;
        private double time = 0;
        public Drone(Coordinate currentCoordinate) : base(currentCoordinate)
        {
        }

        public double Velocity { set => velocity = value; }

        public double FlyTo(Coordinate newCoordinate)
        {
            distance = base.CalculateDistance(newCoordinate, CurrentCoordinate);
            Console.WriteLine($"\nDrone fly from {CurrentCoordinate} to {newCoordinate} and distance = {distance}");
            CurrentCoordinate = newCoordinate;
            if (distance > 1000)
            {
                throw new IllegalArgumentException($"Drone distance can not be more than [{distance}]");
            }
            return distance;
        }

        public double GetFlyTime(Coordinate newCoordinate)
        {
            time = FlyTo(newCoordinate) / velocity;
            double waitingTime = Math.Ceiling(time * 6);
            time = time + waitingTime/60;
            Console.WriteLine($"\nDrone fly distance = {distance} in time = {time}");
            return time;
        }

        public override double GetChangableVelocity()
        {
            return this.velocity;
        }
    }

}
