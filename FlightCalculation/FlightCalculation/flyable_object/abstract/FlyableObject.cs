namespace FlightCalculation.flyable_object.@abstract
{
    abstract class FlyableObject
    {
        protected Coordinate currentCoordinate;
        public FlyableObject(Coordinate currentCoordinate)
        {
            CurrentCoordinate = currentCoordinate;
        }

        internal Coordinate CurrentCoordinate { get => currentCoordinate; set => currentCoordinate = value; }
        public double CalculateDistance(Coordinate newCoordinate, Coordinate current)
        {
            double distance = Math.Sqrt(Math.Pow(newCoordinate.X - current.X, 2)
                + Math.Pow(newCoordinate.Y - current.Y, 2)
                + Math.Pow(newCoordinate.Z - current.Z, 2));
            return distance;
        }

        public abstract double GetChangableVelocity();

    }

}
