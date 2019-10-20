using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Person;

namespace Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            // WriteStatement();
            //SaySomething("Rey");
            Female female = new Female();
            female.Name = "Cindy";
            Console.WriteLine($"Her name is {female.Name}");

        }

        //OVERLOADING
        //Demonstration for overloading
  
        static void SaySomething()
        {
            Console.WriteLine("I don't even know your name. Don't order me");
        }

        static void SaySomething(string first)
        {
            Console.WriteLine($"Cheers, {first}");
        }

        static void SaySomething(string first, string last)
        {
            Console.WriteLine($"Cheers, {first} {last}");
        }

        //This method will write a statement
        private static void WriteStatement()
        {
            var firstName = "Cornelia";
            var lastName = "Johnson";
            var fullName = firstName + " " + lastName;
            Console.Write("My name is " + fullName);
        }
    }
}

namespace Person
{
    public class Female
    {
        public string Name {get; set;}
    }
}
