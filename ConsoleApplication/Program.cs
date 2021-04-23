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
            var nextChristmas = new DateTime(2021, 12, 25);
            var numberOfDays = (nextChristmas - currentDate).TotalDays;
            Console.WriteLine((int)numberOfDays + " days until Christmas");
          //6. 

            double width, height, woodLength, glassArea;
             string widthString, heightString;
            Console.Write("Enter the width:  ");
              widthString = Console.ReadLine();
              width = double.Parse(widthString);
            Console.Write("Enter the height:  ");
              heightString = Console.ReadLine();
             height = double.Parse(heightString);
            woodLength = 2 * ( width + height ) * 3.25 ;
             glassArea = 2 * ( width * height ) ;
             Console.WriteLine ( "The length of the wood is " + 
             woodLength + " feet" ) ;
             Console.WriteLine( "The area of the glass is " + 
              glassArea + " square metres" ) ;

            //7.
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();

        }
    }
}
