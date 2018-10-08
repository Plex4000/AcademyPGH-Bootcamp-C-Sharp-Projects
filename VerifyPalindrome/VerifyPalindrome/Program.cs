using System;

namespace VerifyPalindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a word to check if it is a palindrome");
            var input = Console.ReadLine();

            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            var revword = new string(charArray);

            if (input == revword)
            {
                Console.WriteLine("The word is a palindrome!");
            }
            else
            {
                Console.WriteLine("The word is not a palindrome");
            }

        }
    }
}
