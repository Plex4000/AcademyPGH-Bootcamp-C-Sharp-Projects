using System;
using System.Text.RegularExpressions;

namespace MorseCodeExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] morseCodeChart = new string[,] { { "a", ".-" }, { "b", "-..." }, { "c", "-.-." }, { "d", "-.." }, { "e", "." }, { "f", "..-." }, { "g", "--." }, { "h", "...." }, { "i", ".." }, { "j", ".---" }, { "k", "-.-" }, { "l", ".-.." }, { "m", "--" }, { "n", "-." }, { "o", "---" }, { "p", ".--." }, { "q", "--.-" }, { "r", ".-." }, { "s", "..." }, { "t", "-" }, { "u", "..-" }, { "v", "...-" }, { "w", ".--" }, { "x", "-..-" }, { "y", "-.--" }, { "z", "--.." }, { "1", ".----" }, { "2", "..---" }, { "3", "...--" }, { "4", "....-" }, { "5", "....." }, { "6", "-...." }, { "7", "--..." }, { "8", "---.." }, { "9", "----." }, { "0", "-----" } };


            Console.WriteLine("What is your message?");
            //read input from the user and lower case the string
            string input = Console.ReadLine().ToLower();

            ////string array to represent the alphabet
            //string[] alphabet = { "a", "b" };
            ////string array to represent each morse code
            //string[] morseCode = { ".-", "-..." };

            //looping through the alphabet array
            for (int x = 0; x < morseCodeChart.GetLength(0); x++)
            {
                //replace alphabet letter with morse code letter
                input = input.Replace(morseCodeChart[x, 0], morseCodeChart[x, 1]);
            }

            Console.WriteLine(input);


            //Console.WriteLine("What is your message? ");
            //string input = Console.ReadLine().ToLower();

            //Regex regexPattern = new Regex(@"^[a-zA-Z0-9]+$");

            //while (!regexPattern.IsMatch(input))
            //{
            //    Console.WriteLine("Please enter only letters and numbers: ");
            //    Console.WriteLine("What is your message? ");
            //    input = Console.ReadLine().ToLower();
            //}

            //for (int i = 0; i < input.Length; i++)
            //{
            //    switch (input[i])
            //    {
            //        case 'a':
            //            Console.Write(morseCodeChart[0, 1] + " ");
            //            break;
            //        case 'b':
            //            Console.Write(morseCodeChart[1, 1] + " ");
            //            break;
            //        case 'c':
            //            Console.Write(morseCodeChart[2, 1] + " ");
            //            break;
            //        case 'd':
            //            Console.Write(morseCodeChart[3, 1] + " ");
            //            break;
            //        case 'e':
            //            Console.Write(morseCodeChart[4, 1] + " ");
            //            break;
            //        case 'f':
            //            Console.Write(morseCodeChart[5, 1] + " ");
            //            break;
            //        case 'g':
            //            Console.Write(morseCodeChart[6, 1] + " ");
            //            break;
            //        case 'h':
            //            Console.Write(morseCodeChart[7, 1] + " ");
            //            break;
            //        case 'i':
            //            Console.Write(morseCodeChart[8, 1] + " ");
            //            break;
            //        case 'j':
            //            Console.Write(morseCodeChart[9, 1] + " ");
            //            break;
            //        case 'k':
            //            Console.Write(morseCodeChart[10, 1] + " ");
            //            break;
            //        case 'l':
            //            Console.Write(morseCodeChart[11, 1] + " ");
            //            break;
            //        case 'm':
            //            Console.Write(morseCodeChart[12, 1] + " ");
            //            break;
            //        case 'n':
            //            Console.Write(morseCodeChart[13, 1] + " ");
            //            break;
            //        case 'o':
            //            Console.Write(morseCodeChart[14, 1] + " ");
            //            break;
            //        case 'p':
            //            Console.Write(morseCodeChart[15, 1] + " ");
            //            break;
            //        case 'q':
            //            Console.Write(morseCodeChart[16, 1] + " ");
            //            break;
            //        case 'r':
            //            Console.Write(morseCodeChart[17, 1] + " ");
            //            break;
            //        case 's':
            //            Console.Write(morseCodeChart[18, 1] + " ");
            //            break;
            //        case 't':
            //            Console.Write(morseCodeChart[19, 1] + " ");
            //            break;
            //        case 'u':
            //            Console.Write(morseCodeChart[20, 1] + " ");
            //            break;
            //        case 'v':
            //            Console.Write(morseCodeChart[21, 1] + " ");
            //            break;
            //        case 'w':
            //            Console.Write(morseCodeChart[22, 1] + " ");
            //            break;
            //        case 'x':
            //            Console.Write(morseCodeChart[23, 1] + " ");
            //            break;
            //        case 'y':
            //            Console.Write(morseCodeChart[24, 1] + " ");
            //            break;
            //        case 'z':
            //            Console.Write(morseCodeChart[25, 1] + " ");
            //            break;
            //        case '1':
            //            Console.Write(morseCodeChart[26, 1] + " ");
            //            break;
            //        case '2':
            //            Console.Write(morseCodeChart[27, 1] + " ");
            //            break;
            //        case '3':
            //            Console.Write(morseCodeChart[28, 1] + " ");
            //            break;
            //        case '4':
            //            Console.Write(morseCodeChart[29, 1] + " ");
            //            break;
            //        case '5':
            //            Console.Write(morseCodeChart[30, 1] + " ");
            //            break;
            //        case '6':
            //            Console.Write(morseCodeChart[31, 1] + " ");
            //            break;
            //        case '7':
            //            Console.Write(morseCodeChart[32, 1] + " ");
            //            break;
            //        case '8':
            //            Console.Write(morseCodeChart[33, 1] + " ");
            //            break;
            //        case '9':
            //            Console.Write(morseCodeChart[34, 1] + " ");
            //            break;
            //        case '0':
            //            Console.Write(morseCodeChart[35, 1] + " ");
            //            break;
            //    }
            //}

            Console.ReadLine();

        }
    }
}

