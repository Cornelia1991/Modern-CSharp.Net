using MyLibrary;
using System;

namespace MyApp
{
    class Program
    {
        const string productType = "Fancy Cars";
        static void Main(string[] args)
        {
            Car greenCar = new Car(2121);
            greenCar.CarName = "SuperCool";
            Console.WriteLine($"My car is called: {greenCar.CarName}; " +
                $"The car year {greenCar.Year}");
        }
    }
}
