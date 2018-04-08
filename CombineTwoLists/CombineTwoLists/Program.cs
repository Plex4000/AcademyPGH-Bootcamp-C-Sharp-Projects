using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombineTwoLists
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] alphabet = new string[]{"a", "b", "c"};
            string[] numbers = new string[]{ "1","2","3"};
            List<string> combined = CombineLists(alphabet, numbers);

            for (int i = 0; i < combined.Count(); i++)
            {
                Console.Write(combined[i] + "");
            }
            Console.WriteLine();
         

        }
        public static List<string> CombineLists(string[] a, string[] b)
        {
            List<string> combined = new List<string>();

            combined.Add(a[0]);
            combined.Add(b[0]);
            combined.Add(a[1]);
            combined.Add(b[1]);
            combined.Add(a[2]);
            combined.Add(b[2]);

            return combined;
        }
    }
}
