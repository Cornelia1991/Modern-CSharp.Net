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
    }
}
