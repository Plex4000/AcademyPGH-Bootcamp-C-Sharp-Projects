using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrailExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your message?");
            string input = Console.ReadLine().ToLower();
            //string[] brailAlphabet = new string[] { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z"};
            string[,,] brailSymbols = new string[,,] { { {".","0" },{"0","0"},{"0", "0"} }, { {".", "0" }, {".","0" }, {"0","0"}}};

            //int x = 0;
            //while (x < 2)
            //{
            //    input = input.Replace(brailAlphabet[x], brailSymbols[x]);
            //    x++;
            //}

            //Console.Write(input);
            string top = "";
            string middle = "";
            string bottom = "";

            for (int i = 0;i < input.Count();i++)
            {
                switch (input[0])
                {
                    case 'a':
                        top = top + brailSymbols[0, 0, 0] + brailSymbols[0, 0, 1];
                        middle = middle + brailSymbols[0, 1, 0] + brailSymbols[0, 1, 1];
                        bottom = bottom + brailSymbols[0, 2, 0] + brailSymbols[0, 2, 1];
                        break;
                    case 'b':
                        top = top + brailSymbols[1, 0, 0] + brailSymbols[1, 0, 1];
                        middle = middle + brailSymbols[1, 1, 0] + brailSymbols[1, 1, 1];
                        bottom = bottom + brailSymbols[1, 2, 0] + brailSymbols[1, 2, 1];
                        break;
                    default:
                        break;
                }
            }

            Console.WriteLine(top);
            Console.WriteLine(middle);
            Console.WriteLine(bottom);

        }
    }
}
