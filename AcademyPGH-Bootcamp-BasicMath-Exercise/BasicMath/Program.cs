using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicMath
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(1 + 1);
            Console.WriteLine(1 + 1 * 8);
            Console.WriteLine((1 + 1) * 8);
            Console.WriteLine(3 / 2 * 4.0);
            Console.WriteLine(3 / (2 * 4));

            Console.WriteLine("area of circle: Pi*r^2 " + 0.2 * 2 + 12);
            //long temp = 1000 * 299792458;

            var h = (long)299792458 * (long)2997925458;
            Console.WriteLine("Einstein's Formula E = MC^2: " + 1000 * h);
            Console.WriteLine("Distance = Velocity * Time: " + 60 * 3);
            
        }
    }
}
