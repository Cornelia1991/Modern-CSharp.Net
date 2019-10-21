using System;

namespace MyLibrary
{
    public class Car
    {
        public readonly int Year;
        public Car(int year)
        {
            Year = year;
        }

        public string CarName { get; set; }

        static public void WriteSomething() {
            Console.WriteLine("Something");
        }
    }


    //using static
    static public class CarV2
    {
        static public readonly int Year;

        static public string CarName { get; set; }
    }
}
