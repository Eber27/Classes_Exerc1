using System;
using System.Collections.Generic;

namespace ClassExerc1
{
    class Program
    {
        static void Main(string[] args)
        {
            var Car1 = new Car();
            Car1.Make = "BMW";
            Car1.Model = "X5";
            Car1.Year = 2017;

            // other ways to be done**

            var Car2 = new Car()
            {
                Make = "Chevy",
                Model = "Equinox",
                Year = 2014
            };
            
            var Car3 = new Car ("Nissan", "Pathfinder", 2016);

            var carList = new List<Car>() { Car1, Car2, Car3 };

            foreach (var vehicle in carList)
            {
                Console.WriteLine($"{vehicle.Make}, {vehicle.Model}, {vehicle.Year}");
            }
        }
    }
}
