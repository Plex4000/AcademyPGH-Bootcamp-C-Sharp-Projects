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

            data = Console.ReadLine().Split(' ');
            int area = Convert.ToInt32(data[0]) * Convert.ToInt32(data[1]);

            Console.WriteLine($"The area of your garden is {area} square feet.");

            int perimeter = Convert.ToInt32(data[0]) * 2 + Convert.ToInt32(data[1]) * 2;

            Console.WriteLine($"The perimeter of your garden is {perimeter} feet");

            double carrots = Math.Ceiling((area / 16.0) * 16);
            double corn = Math.Ceiling((area / 16.0) * 3);
            double beets = Math.Ceiling((area / 16.0) * 9);

            Console.WriteLine($"You can plant {carrots} carrots, {corn} ears of corn, and {beets} beets.");


            
        }
    }
}
