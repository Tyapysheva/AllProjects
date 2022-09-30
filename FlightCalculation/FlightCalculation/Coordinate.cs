using FlightCalculation.ProjectException;

namespace FlightCalculation
{
    public class Coordinate
    {
        private double coordinateX;
        private double coordinateY;
        private double coordinateZ;
        public Coordinate(double coordinateX, double coordinateY, double coordinateZ)
        {
            this.CoordinateX = coordinateX;
            this.CoordinateY = coordinateY;
            this.CoordinateZ = coordinateZ;
        }
        public double CoordinateX
        {
            get => coordinateX;
            set
            {
                CheckPositiveNumber(value);
                coordinateX = value;
            }
        }
        public double CoordinateY
        {
            get => coordinateY;
            set
            {
                CheckPositiveNumber(value);
                coordinateY = value;
            }
        }
        public double CoordinateZ
        {
            get => coordinateZ;
            set
            {
                CheckPositiveNumber(value);
                coordinateZ = value;
            }
        }
        private void CheckPositiveNumber(double number)
        {
            if (number < 0)
            {
                throw new IllegalArgumentException($"{number} must be positive");
            }
        }
        public override string? ToString()
        {
            return $"Point[{CoordinateX},{CoordinateY},{CoordinateZ}]";
        }
    }

}
