using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortIntArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = new int[10] { 10, 6, 7, 9, 1, 3, 4, 8, 5, 2};

            SortTheIntArray(intArray);

        }

        static void SortTheIntArray(int[] na)
        {
          
                for (int i = 0; i < na.Length; i++)
                {
                    for (int j = 0; j < na.Length; j++)
                    {
                        if (na[j] > na[i])
                        {
                            int x = na[i];
                            na[i] = na[j];
                            na[j] = x;
                        }
                    }
                }

            for (int i = 0; i < na.Length; i++)
            {
                Console.WriteLine(na[i]);
            }
            
        }
    }
}
