using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciCalculation
{
    class Program
    {
        static List<int> nums = new List<int>();
        
        static void Main(string[] args)
        {
            //Console.WriteLine(Fibonacci(10));
            //Console.WriteLine(nums[9]);
            //var result = FibonacciCalculations();

            //for (int i = 0; i < result.Count(); i++)
            //{
            //    Console.Write(result[i] + " ");
            //}
        }

        public static List<int> FibonacciCalculations()
        {
            int[] temp = new int[3];
            List<int> fibonacci = new List<int>
            {
                0,
                1
            };
            temp[0] = 0;
            temp[1] = 1;
            int tempVar = 0;
            int tempVar2 = 0;
            for (int i = 0; i < 20; i++)
            {
                tempVar = temp[0] + temp[1];
                fibonacci.Add(tempVar);
                tempVar = tempVar + temp[1];
                fibonacci.Add(tempVar);
                temp[0] = temp[1];
                temp[1] = tempVar;
            }
            return fibonacci;
        }
        //public static int Fibonacci(int number)
        //{

        //    if (number <= 1)
        //    {
        //        return 1;
        //    }
        //    else
        //    {
        //        nums.Add(Fibonacci(number - 2) + Fibonacci(number - 1));
        //        return Fibonacci(number - 2) + Fibonacci(number - 1);

        //    }
        //}

    }
}
