using GardenCalculationsWithAClass;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GardenCalculations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is the length and width of your garden in feet?: ");
            string[] data = new string[2];
            int[] units = new int[2];

            data = Console.ReadLine().Split(' ');

            units = Array.ConvertAll(data, int.Parse);

            int length = units[0];
            int height = units[1];

            GardenCalc calc = new GardenCalc(length, height);
            int Area = calc.GetArea();
            int perimeter = calc.GetPerimeter();

            Console.WriteLine($"The area of your garden is {Area}" );
            Console.WriteLine($"The perimeter of your garden is {perimeter}.");
            Console.WriteLine($"You can plant {calc.GetNumOfCarrots()} carrots.");
            Console.WriteLine($"You can plant {calc.GetNumOfCorn()} ears of corn.");
            Console.WriteLine($"You can plant {calc.GetNumOfBeets()} beets.");
            Console.WriteLine("Congratulations! Now you can cook your vegetables! :)");

        }
    }
}
