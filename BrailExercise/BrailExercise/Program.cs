using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrailExercise
{
    class Program
    {
        public static string topRow;
        public static string middleRow;
        public static string bottomRow;

        static void Main(string[] args)
        {
            Console.WriteLine("What is your message?");
            string input = Console.ReadLine().ToLower();

            string[,,] brailSymbols = new string[,,] 
            { 
            { {".","0" },{"0","0"},{"0", "0"} },
            { {".","0" },{".","0"},{"0", "0"} },
            { {".","." },{"0","0"},{"0", "0"} },
            { {".","." },{"0","."},{"0", "0"} },
            { {".","0" },{"0","."},{"0", "0"} },
            { {".","." },{".","0"},{"0", "0"} },
            { {".","." },{".","."},{"0", "0"} },
            { {".","0" },{".","."},{"0", "0"} },
            { {"0","." },{".","0"},{"0", "0"} },
            { {"0","." },{".","."},{"0", "0"} },
            { {".","0" },{"0","0"},{".", "0"} },
            { {".","0" },{".","0"},{".", "0"} },
            { {".","." },{"0","0"},{".", "0"} },
            { {".","." },{"0","."},{".", "0"} },
            { {".","0" },{"0","."},{".", "0"} },
            { {".","." },{".","0"},{".", "0"} },
            { {".","." },{".","."},{".", "0"} },
            { {".","0" },{".","."},{".", "0"} },
            { {"0","." },{".","0"},{".", "0"} },
            { {"0","." },{".","."},{".", "0"} },
            { {".","0" },{"0","0"},{".", "."} },
            { {".","0" },{".","0"},{".", "."} },
            { {"o","." },{".","."},{"0", "."} },
            { {".","." },{"0","0"},{".", "."} },
            { {".","." },{"0","."},{".", "."} },
            { {".","0" },{"0","."},{".", "."} },
            };

            for (int i = 0;i < input.Count();i++)
            {
                switch (input[i])
                {
                    case 'a':
                        BuildBrailRows(0, brailSymbols);
                        break;
                    case 'b':
                        BuildBrailRows(1, brailSymbols);
                        break;
                    case 'c':
                        BuildBrailRows(2, brailSymbols);
                        break;
                    case 'd':
                        BuildBrailRows(3, brailSymbols);
                        break;
                    case 'e':
                        BuildBrailRows(4, brailSymbols);
                        break;
                    case 'f':
                        BuildBrailRows(5, brailSymbols);
                        break;
                    case 'g':
                        BuildBrailRows(6, brailSymbols);
                        break;
                    case 'h':
                        BuildBrailRows(7, brailSymbols);
                        break;
                    case 'i':
                        BuildBrailRows(8, brailSymbols);
                        break;
                    case 'j':
                        BuildBrailRows(9, brailSymbols);
                        break;
                    case 'k':
                        BuildBrailRows(10, brailSymbols);
                        break;
                    case 'l':
                        BuildBrailRows(11, brailSymbols);
                        break;
                    case 'm':
                        BuildBrailRows(12, brailSymbols);
                        break;
                    case 'n':
                        BuildBrailRows(13, brailSymbols);
                        break;
                    case 'o':
                        BuildBrailRows(14, brailSymbols);
                        break;
                    case 'p':
                        BuildBrailRows(15, brailSymbols);
                        break;
                    case 'q':
                        BuildBrailRows(16, brailSymbols);
                        break;
                    case 'r':
                        BuildBrailRows(17, brailSymbols);
                        break;
                    case 's':
                        BuildBrailRows(18, brailSymbols);
                        break;
                    case 't':
                        BuildBrailRows(19, brailSymbols);
                        break;
                    case 'u':
                        BuildBrailRows(20, brailSymbols);
                        break;
                    case 'v':
                        BuildBrailRows(21, brailSymbols);
                        break;
                    case 'w':
                        BuildBrailRows(22, brailSymbols);
                        break;
                    case 'x':
                        BuildBrailRows(23, brailSymbols);
                        break;
                    case 'y':
                        BuildBrailRows(24, brailSymbols);
                        break;
                    case 'z':
                        BuildBrailRows(25, brailSymbols);
                        break;
                }
            }

            Console.WriteLine(topRow);
            Console.WriteLine(middleRow);
            Console.WriteLine(bottomRow);

        }

        public static void BuildBrailRows(int brailLetterIndex, string[,,] brailSymbols)
        {
            topRow = topRow + brailSymbols[brailLetterIndex, 0, 0] + brailSymbols[brailLetterIndex, 0, 1];
            middleRow = middleRow + brailSymbols[brailLetterIndex, 1, 0] + brailSymbols[brailLetterIndex, 1, 1];
            bottomRow = bottomRow + brailSymbols[brailLetterIndex, 2, 0] + brailSymbols[brailLetterIndex, 2, 1];
        }
    }
}
