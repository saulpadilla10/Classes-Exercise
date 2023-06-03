using System;
using System.Collections.Generic;

namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            var vehicle = new Car()
            {
                Make = "Dodge",
                Model = "Dart",
                Year = 1985
            };

            var carList = new List<Car>() { vehicle };

            Console.WriteLine($"{vehicle.Make} {vehicle.Model} {vehicle.Year}");


        }
    }
}
