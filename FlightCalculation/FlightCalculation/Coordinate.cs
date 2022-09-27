using FlightCalculation.exception;

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
                checkPositiveNumber(value);
                x = value;
            }
        }
        public double Y
        {
            get => y;
            set
            {
                checkPositiveNumber(value);
                y = value;
            }
        }
        public double Z
        {
            get => z;
            set
            {
                checkPositiveNumber(value);
                z = value;
            }
        }
        private void checkPositiveNumber(double number)
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
