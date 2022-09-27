using System;
using FlightCalculation.flyable_object;

namespace FlightCalculation
{
    class Program
    {
        static void Main(string[] args)
        {
            Bird bird = new Bird(new Coordinate(5, 6, 7));
            bird.FlyTo(new Coordinate(50, 60, 70));
            bird.GetFlyTime(new Coordinate(500, 600, 700));

            Airplane airplane = new Airplane(new Coordinate(1, 1, 1));
            airplane.GetFlyTime(new Coordinate(10, 10, 20));

            Drone drone = new Drone(new Coordinate(1, 1, 1));
            drone.GetFlyTime(new Coordinate(10, 10, 10));

        }
    }

}
