using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MadLibExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] questionWords = new string[] { "Male Celebrity", "Verb", "Verb", "Adjective", "Noun", "Verb", "Noun"};
            string[] answers = new string[7];
            

            for (int i = 0; i < 7; i++)
            {
                Console.Write($"please enter a/an {questionWords[i]}: ");
                string input = Console.ReadLine();
                answers[i] = input;
            }

            System.IO.StreamReader file = new System.IO.StreamReader(@"C:\text\text.txt");

            Console.WriteLine(file);

            //Console.WriteLine($@" {answers[0]} {answers[1]} coke bottles on the sidewalk.  
            //                    He then {answers[2]} the {answers[3]} {answers[4]} at the police car. 
            //                    The police came over and {answers[5]} him a {answers[6]}.");

        }
    }
}
