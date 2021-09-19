using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            Console.Write("Please enter your name: ");
            name = Console.ReadLine();

            string location;
            Console.Write("Where are you from: ");
            location = Console.ReadLine();

            Console.WriteLine($"My name is {name}");
            Console.WriteLine($"I am from {location}");

            var currentDate = DateTime.Now;
            Console.WriteLine($"Current date is {currentDate.ToShortDateString()}");

            var christmasDate = new System.DateTime(2021, 12, 25, 0, 0, 0);

            var daysUntilChristmas = christmasDate.Subtract(currentDate);

            Console.WriteLine($"Days until Christmas: {daysUntilChristmas.Days + 1}");

            
            double width, height, woodLength, glassArea;
            string widthString, heightString;
            widthString = Console.ReadLine();
            width = double.Parse(widthString);
            heightString = Console.ReadLine();
            height = double.Parse(heightString);
            woodLength = 2 * (width + height) * 3.25;
            glassArea = 2 * (width * height);
            Console.WriteLine("The length of the wood is " +
            woodLength + " feet");
            Console.WriteLine("The area of the glass is " +
            glassArea + " square metres");


                Console.WriteLine("Press any key to quit");
            Console.ReadKey();
        }
    }
}
