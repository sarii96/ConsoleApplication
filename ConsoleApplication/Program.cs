using System;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            //optional 2
            string name;
            string location;

            Console.Write("What is your name: ");
            name = Console.ReadLine();

            Console.Write("Where are you from? ");
            location = Console.ReadLine();

            //3.
            Console.WriteLine($"Your name is {name}");
            Console.WriteLine($"You are from {location}");

            //4.
            var currentDate = DateTime.Now;
            Console.WriteLine($"The current date is {currentDate.ToLongDateString()}");

            //5.
            var nextChristmans = new DateTime(2021, 12, 25);
           
            
          //7.
            Console.ReadKey();

        }
    }
}
