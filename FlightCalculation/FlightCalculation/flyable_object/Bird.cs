using FlightCalculation.flyable_object.@abstract;
using FlightCalculation.@interface;

namespace FlightCalculation.flyable_object

{
    class Bird : FlyableObject, IFlyable
    {
        private double velocity;
        private double distance;
        private double time = 0;
        public Bird(Coordinate currentCoordinate) : base(currentCoordinate)
        {
        }

        public override double GetChangableVelocity()
        {
            Random rnd = new Random();
            velocity = rnd.Next(1, 20);
            return velocity;
        }

        public double FlyTo(Coordinate newCoordinate)
        {
            distance = base.CalculateDistance(newCoordinate, CurrentCoordinate);
            Console.WriteLine($"\nBird fly from {CurrentCoordinate} to {newCoordinate} and distance = {distance}");
            CurrentCoordinate = newCoordinate;
            return distance;
        }
        public double GetFlyTime(Coordinate newCoordinate)
        {
            distance = FlyTo(newCoordinate);
            time = distance / GetChangableVelocity();
            Console.WriteLine($"\nBird started from {CurrentCoordinate} will reach the {newCoordinate} in [{time}] at a speed of [{velocity}]");
            CurrentCoordinate = newCoordinate;
            return time;
        }
    }

}
