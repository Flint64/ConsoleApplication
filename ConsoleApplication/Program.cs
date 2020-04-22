using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication {
    class Program {

        static void Main(string[] args) {

            string name = "Travis Aucoin";
            string location = "Rexburg ID";

            Console.WriteLine($"My name is { name } and I am currently in { location }");
            Console.WriteLine();

            DateTime currentDate = DateTime.UtcNow.Date;
            Console.WriteLine("Today is " + currentDate.ToString("d"));

            Console.WriteLine();

            //DateTime args: year, month, day, hour, min, sec
            var christmas2020 = new DateTime(2020, 12, 25);
            Console.WriteLine("There are only " + (christmas2020 - currentDate).TotalDays + " days left until Christmas!");

            Console.WriteLine();

            /*********************************************
             * Code from book
             *********************************************/
            double width, height, woodLength, glassArea;
            string widthString, heightString;

            Console.Write("Please enter width: ");
            widthString = Console.ReadLine();
            width = double.Parse(widthString);

            Console.Write("Please enter height: ");
            heightString = Console.ReadLine();
            height = double.Parse(heightString);

            woodLength = 2 * (width + height) * 3.25;
            glassArea = 2 * (width * height);

            Console.WriteLine();

            Console.WriteLine("The length of the wood is " + woodLength + " feet");
            Console.WriteLine("The area of the glass is " + glassArea + " square metres");

            Console.WriteLine();

            Console.Write("Press any key to exit...");
            Console.ReadKey();

        }
    }
}
