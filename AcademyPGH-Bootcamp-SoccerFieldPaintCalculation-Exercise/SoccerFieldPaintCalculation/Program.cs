using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoccerFieldPaintCalculation
{
    class Program
    {
        static void Main(string[] args)
        {
            int radius;

            Console.Write("Please enter the radius of the circle in feet: ");
            radius = Convert.ToInt32(Console.ReadLine());
            double area = Math.PI * Math.Pow(radius, 2);

            Console.WriteLine("Which color of paint do you want to use? Red, Blue, Green, or Yellow:");

            string color = Console.ReadLine().ToLower();

            switch (color)
            {
                case "red":
                    double redBuckets = Math.Ceiling(area/100);
                    decimal redCost = (decimal)(redBuckets * 25);
                    Console.WriteLine($"You will need {redBuckets} buckets of Red paint and it will cost ${redCost}");
                    break;
                case "blue":
                    double blueBuckets = Math.Ceiling(area / 120);
                    decimal blueCost = (decimal)(blueBuckets * 28);
                    Console.WriteLine($"You will need {blueBuckets} buckets of Red paint and it will cost ${blueCost}");
                    break;
                case "green":
                    double greenBuckets = Math.Ceiling(area / 90);
                    decimal greenCost = (decimal)(greenBuckets * 33);
                    Console.WriteLine($"You will need {greenBuckets} buckets of Red paint and it will cost {greenCost}");
                    break;
                case "yellow":
                    double yellowBuckets = Math.Ceiling(area / 70);
                    decimal yellowCost = (decimal)(yellowBuckets * 22);
                    Console.WriteLine($"You will need {yellowBuckets} buckets of Red paint and it will cost {yellowCost}");
                    break;
            }




        }
    }
}
