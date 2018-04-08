using System;
using System.Collections.Generic;
using System.Linq;

namespace FibonacciCalculation
{
    class Program
    {
        static List<int> nums = new List<int>();
        
        static void Main(string[] args)
        {
            var result = FibonacciCalculations();

            for (int i = 0; i < result.Count(); i++)
            {
                Console.Write(result[i] + " ");
            }
        }

        public static List<long> FibonacciCalculations()
        {
            long[] temp = new long[2];
            List<long> fibonacci = new List<long>();
            fibonacci.Add(0);
            fibonacci.Add(1);
            temp[0] = 0;
            temp[1] = 1;
            long tempVar = 0;
            long tempVar2 = 0;

            for (int i = 0; i < 48; i++)
            {
                tempVar = temp[0] + temp[1];
                fibonacci.Add(tempVar);
                temp[0] = temp[1];
                temp[1] = tempVar;  
            }
            return fibonacci;
        }
    }
}
