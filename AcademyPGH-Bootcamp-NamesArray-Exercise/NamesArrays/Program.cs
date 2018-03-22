using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NamesArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[10];

            for (int i = 1; i <= names.Length; i++)
            {
                Console.WriteLine($"Please enter a name for slot {i}");
                names[i-1] = Console.ReadLine();
            }

            Console.WriteLine($"Welcome {names[0]}, {names[1]}, {names[2]}, {names[3]}, {names[4]}, {names[5]}, {names[6]}, {names[7]}, {names[8]}, {names[9]}");
        }
    }
}
