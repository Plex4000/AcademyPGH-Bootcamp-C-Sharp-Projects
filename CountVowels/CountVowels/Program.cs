using System;

namespace CountVowels
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter word to count vowels");
            var input = Console.ReadLine();
            var chararray = input.ToCharArray();

            int a, e, i, o, u;
            a = e = i = o = u = 0;

            for (int j = 0; j < chararray.Length; j++)
            {
                switch (chararray[j])
                {
                    case 'a':
                        a++;
                        break;
                    case 'e':
                        e++;
                        break;
                    case 'i':
                        i++;
                        break;
                    case 'o':
                        o++;
                        break;
                    case 'u':
                        u++;
                        break;
                }
            }

            Console.WriteLine($"Your word has {a} a's, {e} e's, {i} i's, {o} o's, {u} u's");

        }
    }
}
