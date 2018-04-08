using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3FunctionsMath
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculateForLoop();
            CalculateWhileLoop();
           // CalculateRecursion(4);

        }

        public static void CalculateForLoop()
        {
            int[] numArray = new int[] { 1, 2, 3, 4, 5 };
            int total = 0;
            for (int i = 0; i < numArray.Length; i++)
            {
                total = total + numArray[i];
            }

            Console.WriteLine(total);
        }

        public static void CalculateWhileLoop()
        {
            int total = 0;
            int i = 0;
            int[] numArray = new int[] { 1, 2, 3, 4, 5 };
            while (i < numArray.Length)
            {
                total = total + numArray[i];
                i++;
            }
            Console.WriteLine(total);
        }

        //public static int CalculateRecursion(int i)
        //{
        //    int[] numArray = new int[] { 1, 2, 3, 4, 5 };
        //    i--;
        //    return numArray[4] + CalculateRecursion(numArray[i]);
        //}
    }
}
