using PacktLibrary;
using System;
using static System.Console;

namespace PeopleApp
{
    class Program
    {
        //Enum
        enum Day { Sun, Mon, Tue, Wed, Thu, Fri, Sat};

        static void Main(string[] args)
        {
            var p1 = new Person();
            p1.Name = "Bob Smith";
            p1.DateOfBirth = new DateTime(1985, 6, 28);
            WriteLine($"{p1.Name} was born on " +
                $"{p1.DateOfBirth:dddd, d MMMM yyyy}");

            //OBJECT INITIALIZER
            var p2 = new Person
            {
                Name = "Stephon Reese",
                DateOfBirth = new DateTime(1992, 4, 23)
            };
            WriteLine($"{p2.Name} was born on {p2.DateOfBirth: d MMM yy} on the day of {Day.Sat}");

            //Demo List
            p1.Children.Add(new Person { Name = "Cindy" });
            p1.Children.Add(new Person { Name = "John" });
            p1.Children.Add(new Person { Name = "Mary" });
            WriteLine($"{p1.Name} has {p1.Children.Count} children.");
        }
    }
}
