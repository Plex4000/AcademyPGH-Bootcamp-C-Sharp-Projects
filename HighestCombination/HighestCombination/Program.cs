using System;
using System.Collections.Generic;

namespace HighestCombination
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a list of numbers separated by spaces.");
            //convert the entered numbers into an array of string numbers
            string[] userNums = Console.ReadLine().Split(' ');

            //calculate the maximum number of possible combinations of the numbers given by the user
            int numOfComboPossible = GetComboFactorial(userNums.Length);

            Console.WriteLine("The largest combination is: " + GetLargestCombination(numOfComboPossible, userNums));
        }

        public static int GetComboFactorial(int number)
        {
            if (number == 0)
            {
                return 1;
            }
            return number * GetComboFactorial(number - 1);
        }

        public static long GetLargestCombination(int numOfComboPossible, string[] userNums)
        {
            List<string> combinedList = new List<string>();
            List<string> indexCombos = new List<string>();
            int comboCount = 0;
            Random rand = new Random();
            int randomIndex;
            string randomIndexCombo = "";

            while (comboCount < numOfComboPossible)
            {
                string tempStringNum = "";
                List<int> indexList = new List<int>();

                for (int i = 0; i < userNums.Length; i++)
                {
                    randomIndex = rand.Next(0, userNums.Length);

                    while (indexList.Contains(randomIndex))
                    {
                        randomIndex = rand.Next(0, userNums.Length);
                    }

                    tempStringNum += userNums[randomIndex];
                    indexList.Add(randomIndex);
                    randomIndexCombo += randomIndex + " ";

                }

                if (!indexCombos.Contains(randomIndexCombo))
                {
                    indexCombos.Add(randomIndexCombo);
                    combinedList.Add(tempStringNum);
                    tempStringNum = "";
                    randomIndexCombo = "";
                    comboCount++;
                }
                else
                {
                    tempStringNum = "";
                    randomIndexCombo = "";
                }

            }

            //convert string array to long datatype array
            long[] finalArray = Array.ConvertAll(combinedList.ToArray(), long.Parse);

            //sort array in ascending order
            Array.Sort(finalArray);

            //return the last number in the array
            return finalArray[finalArray.Length - 1];

        }
    }
}
