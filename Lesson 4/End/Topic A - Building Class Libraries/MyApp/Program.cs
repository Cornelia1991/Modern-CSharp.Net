using MyLibrary;
using System;

namespace MyApp
{
    class Program
    {
        const string productType = "Fancy Cars";
        static void Main(string[] args)
        {
            //DemoCar();
            DemoOptionalParameters("Jump", 12.8, true);
        }

        private static void DemoCar()
        {
            Car greenCar = new Car(2121);
            greenCar.CarName = "SuperCool";
            Console.WriteLine($"My car is called: {greenCar.CarName}; " +
                $"The car year {greenCar.Year}");


            Car.WriteSomething();
            //CarV2.CarName = "Super Cool";
            //Console.WriteLine($"My car is called: {CarV2.CarName}" );
        }

        static public void DemoOptionalParameters(string command = "Run!",
            double number = 0.0,
            bool active = true)
        {
            Console.WriteLine($"command is {command}, number is {number}, active is {active}");
        }
    }
}
