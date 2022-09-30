namespace FlightCalculation.FlyableObjects.Abstract
{
    public abstract class FlyableObject
    {
        protected Coordinate currentCoordinate;
        public FlyableObject(Coordinate currentCoordinate)
        {
            CurrentCoordinate = currentCoordinate;
        }
        internal Coordinate CurrentCoordinate { get => currentCoordinate; set => currentCoordinate = value; }
        public double CalculateDistance(Coordinate newCoordinate, Coordinate current)
        {
            double distance = Math.Sqrt(Math.Pow(newCoordinate.CoordinateX - current.CoordinateX, 2)
                + Math.Pow(newCoordinate.CoordinateY - current.CoordinateY, 2)
                + Math.Pow(newCoordinate.CoordinateZ - current.CoordinateZ, 2));
            return distance;
        }
        public abstract double GetChangableVelocity();
    }

}
