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
            string fullName = "Justen Neeley";
            string location = "Bonneville County";
            DateTime todayDate = DateTime.Now.Date;
            DateTime christmasDay = new DateTime(DateTime.Now.Year, 12, 25);
            var daysTilChristmas = christmasDay - todayDate;
            Console.WriteLine($"My name is {fullName}.");
            Console.WriteLine($"I live in {location}");
            Console.WriteLine("Today is: "+ todayDate.ToString("MMMM dd yyyy"));
            Console.WriteLine("Days til Christmas: "+ daysTilChristmas.ToString("%d"));

            double width, height, woodLength, glassArea;
            string widthString, heightString;
            Console.Write("Please enter the width:");
            widthString = Console.ReadLine();
            width = double.Parse(widthString);
            Console.Write("Please enter the Height:");
            heightString = Console.ReadLine();
            height = double.Parse(heightString);
            woodLength = 2 * (width + height) * 3.25;
            glassArea = 2 * (width * height);
            Console.WriteLine("The length of the wood is " +
            woodLength + " feet");
            Console.WriteLine("The area of the glass is " +
            glassArea + " square metres");            Console.ReadKey();
        }
    }
}
