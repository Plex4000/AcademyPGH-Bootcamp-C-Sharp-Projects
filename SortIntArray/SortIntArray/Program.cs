using System;
using System.Numerics;

namespace SortIntArray
{
    class Program
    {
        static void Main(string[] args)
        {
            /* program takes in a list of user input numbers and sorts them in ascending order
               program uses BigInteger data type since the user can enter a big num which is too large for an int data type
            */

            Console.WriteLine("Please enter a list of numbers separated by spaces to sort in ascending order:");
            var inputNums = Console.ReadLine().Split(' ');
            BigInteger[] inputArray = Array.ConvertAll(inputNums, BigInteger.Parse);
            SortInputArray(inputArray);

        }

        static void SortInputArray(BigInteger[] numArray)
        {
            for (int i = 0; i < numArray.Length; i++)
            {
                for (int j = 0; j < numArray.Length; j++)
                {
                    if (numArray[j] > numArray[i])
                    {
                        BigInteger x = numArray[i];
                        numArray[i] = numArray[j];
                        numArray[j] = x;
                    }
                }
            }

            Console.Write("The array sorted in ascending order is: ");

            for (int i = 0; i < numArray.Length; i++)
            {
                Console.Write(numArray[i] + " ");
            }

            Console.ReadLine();
        }


    }
}
