using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace CashRegsiterExercise
{
    public class Program
    {
        public static Random random = new Random();
        public static int CalculateDenominations(decimal change, double baseDenomination)
        {
            int numOfDenomination;

            decimal tempValue1 = change / Convert.ToDecimal(baseDenomination);
            if (tempValue1 < 1)
            {
               numOfDenomination = 0;
            }
            else
            {
                numOfDenomination = Convert.ToInt32(Math.Floor(tempValue1));
            }

            return numOfDenomination;
        }

        public static Tuple<int, decimal> RandomDenominationGenerator(int numOfDenomination, int randNumOfDenomination, decimal denominationAmount, decimal randomizeChange, decimal totalChange, decimal subRunningTotal)
        {
            int tempValue;
            decimal runningTotal;
            //if (loopCount == 1)
            //{
            //    int num = numOfDenomination + 1;
            //    randNumOfDenomination = rand.Next(1, num);
            //    randomizeChange = randomizeChange - randNumOfDenomination * denominationAmount;
            //}
            //else
            //{
            //    int tempValue = randNumOfDenomination + 1;

            //    if (randomizeChange - tempValue * denominationAmount >= 0)
            //    {
            //        randNumOfDenomination++;
            //        randomizeChange = randomizeChange - randNumOfDenomination * denominationAmount;
            //    }
            //    if (randNumOfDenomination > numOfDenomination)
            //    {
            //        tempValue = rand.Next(numOfDenomination, randNumOfDenomination);
            //    }
            //    else
            //    {
            //        tempValue = rand.Next(randNumOfDenomination, numOfDenomination);
            //    }
            //    if ((tempValue + randNumOfDenomination) * denominationAmount <= randomizeChange)
            //    {
            //        randNumOfDenomination += tempValue;
            //        randomizeChange = randomizeChange - randNumOfDenomination * denominationAmount;
            //    }

            int maxValue = numOfDenomination + 1;
            tempValue = random.Next(0, maxValue);
            runningTotal = ((tempValue + randNumOfDenomination) * denominationAmount) + subRunningTotal;
            if (runningTotal < totalChange)
            {
                if (tempValue > 0)
                {
                    randNumOfDenomination = randNumOfDenomination + tempValue;
                    randomizeChange = randomizeChange - (randNumOfDenomination * denominationAmount);
                }

            }
            else if (runningTotal == totalChange)
            {
                randNumOfDenomination += tempValue;
                randomizeChange = 0m;
            }
            
            return new Tuple<int, decimal>(randNumOfDenomination, randomizeChange);
        }

           

        
        static void Main(string[] args)
        {
            int numOf20s, numOf10s, numOf5s, numOf1s, numOfQuarters, numOfDimes, numOfNickles, numOfPennies;
            decimal cost, pay, change, randomizeChange;

            Console.Write("How much did it cost?: ");
            cost = Convert.ToDecimal(Console.ReadLine());

            Console.Write("How much did they pay?: ");
            pay = Convert.ToDecimal(Console.ReadLine());

            change = cost - pay;
            randomizeChange = change;


            Console.WriteLine("They get $" + change + " in change.");

            //$20 bills

            numOf20s = CalculateDenominations(change, 20);
            change = change - numOf20s * 20;

            //$10 bills

            numOf10s = CalculateDenominations(change, 10);
            change = change - numOf10s * 10;

            //$5 bills

            numOf5s = CalculateDenominations(change, 5);
            change = change - numOf5s * 5;

            //1$ bills

            numOf1s = Convert.ToInt32(Math.Floor(change));
            change = change - numOf1s;

            //Quarters
            numOfQuarters = CalculateDenominations(change, .25);
            change = change - numOfQuarters * Convert.ToDecimal(.25);

            //Dimes

            numOfDimes = CalculateDenominations(change, .10);
            change = change - numOfDimes * Convert.ToDecimal(.10);

            //Nickles

            numOfNickles = CalculateDenominations(change, .05);
            change = change - numOfNickles * Convert.ToDecimal(.05);

            //Pennies

            numOfPennies = Convert.ToInt32(change * 100);

            //Print out the change in denominations

            if(numOf20s == 1)
            {
                Console.Write(numOf20s + " twenty, ");
            }
            else if (numOf20s > 1)
            {
                Console.Write(numOf20s + " twenties, ");
            }

            if (numOf10s == 1)
            {
                Console.Write(numOf10s + " ten, ");
            }
            else if (numOf10s > 1)
            {
                Console.Write(numOf10s + " tens, ");
            }

            if (numOf5s == 1)
            {
                Console.Write(numOf5s + " five, ");
            }
            else if (numOf5s > 1)
            {
                Console.Write(numOf5s + " fives, ");
            }

            if (numOf1s == 1)
            {
                Console.Write(numOf1s + " one, ");
            }
            else if (numOf1s > 1)
            {
                Console.Write(numOf1s + " ones, ");
            }

            if (numOfQuarters == 1)
            {
                Console.Write(numOfQuarters + " quarter, ");
            }
            if (numOfQuarters > 1)
            {
                Console.Write(numOfQuarters + " quarters, ");
            }

            if (numOfDimes == 1)
            {
                Console.Write(numOfDimes + " dime, ");
            }
            if (numOfDimes > 1)
            {
                Console.Write(numOfDimes + " dimes, ");
            }

            if (numOfNickles == 1)
            {
                Console.Write(numOfNickles + " nickle, ");
            }
            if (numOfNickles > 1)
            {
                Console.Write(numOfNickles + " nickles, ");
            }

            if (numOfPennies == 1)
            {
                Console.Write(numOfPennies + " penny");
            }
            if (numOfPennies > 1)
            {
                Console.Write(numOfPennies + " pennies");
            }

            //Bonus: Randomize change denomination output
            Console.WriteLine();

            int randNumOf20s = 0, randNumOf10s = 0, randNumOf5s = 0, randNumOf1s = 0, randNumOfQuarters = 0, randNumOfDimes = 0, randNumOfNickles = 0, randNumOfPennies = 0, tempValue, loopCount = 1, randNum;

            decimal subRunningTotal;
            decimal totalChange = randomizeChange;
            Tuple<int, decimal> tuple;
            // Random random = new Random();

            while (randomizeChange > 0)
            {
                if (numOf20s != 0)
                {
                    subRunningTotal = (randNumOf10s * 10) + (randNumOf5s * 5) + randNumOf1s + (randNumOfQuarters * .25m) + (randNumOfDimes * .10m) + (randNumOfNickles * .05m) + (randNumOfPennies * .01m);
                    tuple = RandomDenominationGenerator(numOf20s, randNumOf20s, 20, randomizeChange, totalChange, subRunningTotal);
                    randNumOf20s = tuple.Item1;
                    randomizeChange = tuple.Item2;
                    if (randomizeChange == 0)
                        break;
                }

                if (numOf10s != 0)
                {
                    subRunningTotal = (randNumOf20s * 20)  + (randNumOf5s * 5) + randNumOf1s + (randNumOfQuarters * .25m) + (randNumOfDimes * .10m) + (randNumOfNickles * .05m) + (randNumOfPennies * .01m);
                    tuple = RandomDenominationGenerator(numOf10s, randNumOf10s, 10, randomizeChange, totalChange, subRunningTotal);
                    randNumOf10s = tuple.Item1;
                    randomizeChange = tuple.Item2;
                    if (randomizeChange == 0)
                        break;
                }

                if (numOf5s != 0)
                {
                    subRunningTotal = (randNumOf20s * 20) + (randNumOf10s * 10) + randNumOf1s + (randNumOfQuarters * .25m) + (randNumOfDimes * .10m) + (randNumOfNickles * .05m) + (randNumOfPennies * .01m);
                    tuple = RandomDenominationGenerator(numOf5s, randNumOf5s, 5, randomizeChange, totalChange, subRunningTotal);
                    randNumOf5s = tuple.Item1;
                    randomizeChange = tuple.Item2;
                    if (randomizeChange == 0)
                        break;
                }

                if (numOf1s != 0)
                {
                    subRunningTotal = (randNumOf20s * 20) + (randNumOf10s * 10) + (randNumOf5s * 5) +  (randNumOfQuarters * .25m) + (randNumOfDimes * .10m) + (randNumOfNickles * .05m) + (randNumOfPennies * .01m);
                    tuple = RandomDenominationGenerator(numOf1s, randNumOf1s, 1, randomizeChange, totalChange, subRunningTotal);
                    randNumOf1s = tuple.Item1;
                    randomizeChange = tuple.Item2;
                    if (randomizeChange == 0)
                        break;
                }

                if (numOfQuarters != 0)
                {
                    subRunningTotal = (randNumOf20s * 20) + (randNumOf10s * 10) + (randNumOf5s * 5) + randNumOf1s +  (randNumOfDimes * .10m) + (randNumOfNickles * .05m) + (randNumOfPennies * .01m);
                    tuple = RandomDenominationGenerator(numOfQuarters, randNumOfQuarters, .25m, randomizeChange, totalChange, subRunningTotal);
                    randNumOfQuarters = tuple.Item1;
                    randomizeChange = tuple.Item2;
                    if (randomizeChange == 0)
                        break;
                }

                if (numOfDimes != 0)
                {
                    subRunningTotal = (randNumOf20s * 20) + (randNumOf10s * 10) + (randNumOf5s * 5) + randNumOf1s + (randNumOfQuarters * .25m)  + (randNumOfNickles * .05m) + (randNumOfPennies * .01m);
                    tuple = RandomDenominationGenerator(numOfDimes, randNumOfDimes, .10m, randomizeChange, totalChange, subRunningTotal);
                    randNumOfDimes = tuple.Item1;
                    randomizeChange = tuple.Item2;
                    if (randomizeChange == 0)
                        break;
                }

                if (numOfNickles != 0)
                {
                    subRunningTotal = (randNumOf20s * 20) + (randNumOf10s * 10) + (randNumOf5s * 5) + randNumOf1s + (randNumOfQuarters * .25m) + (randNumOfDimes * .10m) + (randNumOfPennies * .01m);
                    tuple = RandomDenominationGenerator(numOfNickles, randNumOfNickles, .05m, randomizeChange, totalChange, subRunningTotal);
                    randNumOfNickles = tuple.Item1;
                    randomizeChange = tuple.Item2;
                    if (randomizeChange == 0)
                        break;
                }

                if (numOfPennies != 0)
                {
                    subRunningTotal = (randNumOf20s * 20) + (randNumOf10s * 10) + (randNumOf5s * 5) + randNumOf1s + (randNumOfQuarters * .25m) + (randNumOfDimes * .10m) + (randNumOfNickles * .05m);
                    tuple = RandomDenominationGenerator(numOfPennies, randNumOfPennies, .05m, randomizeChange, totalChange, subRunningTotal);
                    randNumOfPennies = tuple.Item1;
                    randomizeChange = tuple.Item2;
                    if (randomizeChange == 0)
                        break;
                }

            }

            //int randNumOf20s = 0, randNumOf10s = 0, randNumOf5s = 0, randNumOf1s = 0, randNumOfQuarters = 0, randNumOfDimes = 0, randNumOfNickles = 0, randNumOfPennies = 0, tempValue, loopCount = 1, randNum;
            //Random random = new Random();


            //    while (true)
            //    {
            //        randNum = random.Next(1, 9);

            //        switch (randNum)
            //        {
            //            case 1:
            //                if (numOf20s != 0)
            //                {
            //                    if (randomizeChange - 20 >= 0)
            //                    {
            //                        randomizeChange = randomizeChange - 20;
            //                        randNumOf20s++;
            //                    }
            //                }
            //                break;
            //            case 2:
            //                if (numOf10s != 0)
            //                {
            //                    if (randomizeChange - 10 >= 0)
            //                    {
            //                        randomizeChange = randomizeChange - 10;
            //                        randNumOf10s++;
            //                    }

            //                }
            //                break;
            //            case 3:
            //                if (numOf5s != 0)
            //                {
            //                    if (randomizeChange - 5 >= 0)
            //                    {
            //                        randomizeChange = randomizeChange - 5;
            //                        randNumOf5s++;
            //                    }


            //                }
            //                break;
            //            case 4:
            //                if (numOf1s != 0)
            //                {
            //                    if (randomizeChange - 1 >= 0)
            //                    {
            //                        randomizeChange = randomizeChange - 1;
            //                        randNumOf1s++;
            //                    }

            //                }
            //                break;
            //            case 5:
            //                if (numOfQuarters != 0)
            //                {
            //                    if (randomizeChange - .25m >= 0)
            //                    {
            //                        randomizeChange = randomizeChange - .25m;
            //                        randNumOfQuarters++;
            //                    }

            //                }
            //                break;
            //            case 6:
            //                if (numOfDimes != 0)
            //                {
            //                    if (randomizeChange - .10m >= 0)
            //                    {
            //                        randomizeChange = randomizeChange - .10m;
            //                        randNumOfDimes++;
            //                    }

            //                }
            //                break;
            //            case 7:
            //                if (numOfNickles != 0)
            //                {
            //                    if (randomizeChange - .05m >= 0)
            //                    {
            //                        randomizeChange = randomizeChange - .05m;
            //                        randNumOfNickles++;
            //                    }

            //                }
            //                break;
            //            case 8:
            //                if (numOfPennies != 0)
            //                {
            //                    if (randomizeChange - .01m >= 0)
            //                    {
            //                        randomizeChange = randomizeChange - .01m;
            //                        randNumOfPennies++;
            //                    }

            //                }
            //                break;

            //        }

            //        if (randomizeChange == 0) { break; }
            //    }


            if (randNumOf20s == 1)
            {
                Console.Write(randNumOf20s + " twenty, ");
            }
            else if (randNumOf20s > 1)
            {
                Console.Write(randNumOf20s + " twenties, ");
            }

            if (randNumOf10s == 1)
            {
                Console.Write(randNumOf10s + " ten, ");
            }
            else if (randNumOf10s > 1)
            {
                Console.Write(randNumOf10s + " tens, ");
            }

            if (randNumOf5s == 1)
            {
                Console.Write(randNumOf5s + " five, ");
            }
            else if (randNumOf5s > 1)
            {
                Console.Write(randNumOf5s + " fives, ");
            }

            if (randNumOf1s == 1)
            {
                Console.Write(randNumOf1s + " one, ");
            }
            else if (randNumOf1s > 1)
            {
                Console.Write(randNumOf1s + " ones, ");
            }

            if (randNumOfQuarters == 1)
            {
                Console.Write(randNumOfQuarters + " quarter, ");
            }
            if (randNumOfQuarters > 1)
            {
                Console.Write(randNumOfQuarters + " quarters, ");
            }

            if (randNumOfDimes == 1)
            {
                Console.Write(randNumOfDimes + " dime, ");
            }
            if (randNumOfDimes > 1)
            {
                Console.Write(randNumOfDimes + " dimes, ");
            }

            if (randNumOfNickles == 1)
            {
                Console.Write(randNumOfNickles + " nickle, ");
            }
            if (randNumOfNickles > 1)
            {
                Console.Write(randNumOfNickles + " nickles, ");
            }

            if (randNumOfPennies == 1)
            {
                Console.Write(randNumOfPennies + " penny");
            }
            if (randNumOfPennies > 1)
            {
                Console.Write(randNumOfPennies + " pennies");
            }

            //Console.WriteLine();

            //int randNumOf20s = 0, randNumOf10s = 0, randNumOf5s = 0, randNumOf1s = 0, randNumOfQuarters = 0, randNumOfDimes = 0, randNumOfNickles = 0, randNumOfPennies = 0, tempValue, loopCount = 1, randNum;

            //Tuple<int, decimal> tuple;

            //if (numOfPennies == 3)
            //{
            //    while (randomizeChange > 0)
            //    {
            //        if (numOf20s != 0)
            //        {
            //            tuple = RandomDenominationGenerator(loopCount, numOf20s, randNumOf20s, 20, randomizeChange);
            //            randNumOf20s = tuple.Item1;
            //            randomizeChange = tuple.Item2;
            //        }

            //        if (numOf10s != 0)
            //        {
            //            tuple = RandomDenominationGenerator(loopCount, numOf10s, randNumOf10s, 10, randomizeChange);
            //            randNumOf10s = tuple.Item1;
            //            randomizeChange = tuple.Item2;
            //        }

            //        if (numOf5s != 0)
            //        {
            //            tuple = RandomDenominationGenerator(loopCount, numOf5s, randNumOf5s, 5, randomizeChange);
            //            randNumOf5s = tuple.Item1;
            //            randomizeChange = tuple.Item2;
            //        }

            //        if (numOf1s != 0)
            //        {
            //            tuple = RandomDenominationGenerator(loopCount, numOf1s, randNumOf1s, 1, randomizeChange);
            //            randNumOf1s = tuple.Item1;
            //            randomizeChange = tuple.Item2;
            //        }

            //        if (numOfQuarters != 0)
            //        {
            //            tuple = RandomDenominationGenerator(loopCount, numOfQuarters, randNumOfQuarters, .25m, randomizeChange);
            //            randNumOfQuarters = tuple.Item1;
            //            randomizeChange = tuple.Item2;
            //        }

            //        if (numOfDimes != 0)
            //        {
            //            tuple = RandomDenominationGenerator(loopCount, numOfDimes, randNumOfDimes, .10m, randomizeChange);
            //            randNumOfDimes = tuple.Item1;
            //            randomizeChange = tuple.Item2;
            //        }

            //        if (numOfNickles != 0)
            //        {
            //            tuple = RandomDenominationGenerator(loopCount, numOfNickles, randNumOfNickles, .05m, randomizeChange);
            //            randNumOfNickles = tuple.Item1;
            //            randomizeChange = tuple.Item2;
            //        }

            //        if (numOfPennies != 0)
            //        {
            //            tuple = RandomDenominationGenerator(loopCount, numOfPennies, randNumOfPennies, .01m, randomizeChange);
            //            randNumOfPennies = tuple.Item1;
            //            randomizeChange = tuple.Item2;
            //        }

            //        loopCount++;

            //    }


            // Dictionary<string, int> denominationsDict = new Dictionary<string, int> { { "20 bills", numOf20s }, { "10 bills", numOf10s }, { "5 bills", numOf5s }, { "1 bills", numOf1s }, { "quarters", numOfQuarters }, { "dimes", numOfDimes }, { "nickles", numOfNickles }, { "pennies", numOfPennies } };

            // Random rand = new Random();
            // KeyValuePair<string, int> randomEntry;
            // String randomKey;
            // int randomValue;


            // Console.WriteLine();

            // for (int i = 1; i <= 8; i++)
            // {
            //     randomEntry = denominationsDict.ElementAt(rand.Next(0, denominationsDict.Count));
            //     randomKey = randomEntry.Key;
            //     randomValue =  randomEntry.Value;
            //     denominationsDict.Remove(randomKey);

            //     if (randomKey == "20 bills" && randomValue == 1)
            //     {
            //         Console.Write(randomValue + " twenty, ");
            //     }
            //     else if (randomKey == "20 bills" && randomValue > 1)
            //     {
            //         Console.Write(randomValue + " twenties, ");
            //     }


            //     randNumOfPennies = Convert.ToInt32(randomizeChange * 100);

            //     if (randNumOf20s == 1)

            //     if (randomKey == "10 bills" && randomValue == 1)

            //     {
            //         Console.Write(randomValue + " ten, ");
            //     }
            //     else if (randomKey == "10 bills" && randomValue > 1)
            //     {
            //         Console.Write(randomValue + " tens, ");
            //     }

            //     if (randomKey == "5 bills" && randomValue == 1)
            //     {
            //         Console.Write(randomValue + " five, ");
            //     }
            //     else if (randomKey == "5 bills" && randomValue > 1)
            //     {
            //         Console.Write(randomValue + " fives, ");
            //     }

            //     if (randomKey == "1 bills" && randomValue == 1)
            //     {
            //         Console.Write(randomValue + " one, ");
            //     }
            //     else if (randomKey == "1 bills" && randomValue > 1)
            //     {
            //         Console.Write(randomValue + " ones, ");
            //     }

            //     if (randomKey == "quarters" && randomValue == 1)
            //     {
            //         Console.Write(randomValue + " quarter, ");
            //     }
            //     else if (randomKey == "quarters" && randomValue > 1)
            //     {
            //         Console.Write(randomValue + " quarters, ");
            //     }

            //     if (randomKey == "dimes" && randomValue == 1)
            //     {
            //         Console.Write(randomValue + " dime, ");
            //     }
            //     else if (randomKey == "dimes" && randomValue > 1)
            //     {
            //         Console.Write(randomValue + " dimes, ");
            //     }

            //     if (randomKey == "nickles" && randomValue == 1)
            //     {
            //         Console.Write(randomValue + " nickle, ");
            //     }
            //     else if (randomKey == "nickles" && randomValue > 1)
            //     {
            //         Console.Write(randomValue + " nickles, ");
            //     }

            //     if (randomKey == "pennies" && randomValue == 1)
            //     {
            //         Console.Write(randomValue + " penny, ");
            //     }
            //     else if (randomKey == "pennies" && randomValue > 1)
            //     {

            //         Console.Write(randNumOfNickles + " nickles, ");
            //Console.Write(randomValue + " pennies, ");

            //     }

            // }

            Console.ReadLine();
        }

    }
}
