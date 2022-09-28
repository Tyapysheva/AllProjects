using FlightCalculation.ProjectException;

namespace FlightCalculation
{
    class Coordinate
    {
        double x;
        double y;
        double z;

        public Coordinate(double x, double y, double z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        public double X
        {
            get => x;
            set
            {
                CheckPositiveNumber(value);
                x = value;
            }
        }
        public double Y
        {
            get => y;
            set
            {
                CheckPositiveNumber(value);
                y = value;
            }
        }
        public double Z
        {
            get => z;
            set
            {
                CheckPositiveNumber(value);
                z = value;
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
            return $"Point[{X},{Y},{Z}]";
        }
    }

}
