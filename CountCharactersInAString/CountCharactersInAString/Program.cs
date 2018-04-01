using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountCharactersInAString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a message: ");
            string input = Console.ReadLine();
            var count = CountCharacters(input, 'a');

            Console.WriteLine(count);
        }

        public static int CountCharacters(string message, char letter)
        {
            int charCount = 0;

            for (int i = 0; i < message.Length; i++)
            {
                if(message[i] == letter)
                {
                    charCount++;
                }
            }
            return charCount;
        }
    }
}
