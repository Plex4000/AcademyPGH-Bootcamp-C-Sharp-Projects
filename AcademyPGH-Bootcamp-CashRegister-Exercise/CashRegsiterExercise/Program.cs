using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading;

namespace CashRegsiterExercise
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int hundreds = 0;
            int fifties = 0;
            int twenties = 0;
            int tens = 0;
            int fives = 0;
            int ones = 0;
            int quarters = 0;
            int dimes = 0;
            int nickles = 0;
            int pennies = 0;


            Console.Write("How much did it cost? ");
            var cost = Convert.ToDecimal(Console.ReadLine());

            Console.Write("How much did they pay? ");
            var pay = Convert.ToDecimal(Console.ReadLine());

            var change = cost - pay;
            var randomizeChange = change;

            Console.WriteLine("They get $" + change + " in change.");


            // $20 bills

            twenties = CalculateDenominations(change, 20);
            change = change - twenties * 20;

            //$10 bills

            tens = CalculateDenominations(change, 10);
            change = change - tens * 10;

            //$5 bills

            fives = CalculateDenominations(change, 5);
            change = change - fives * 5;

            //1$ bills

            ones = Convert.ToInt32(Math.Floor(change));
            change = change - ones;

            //Quarters
            quarters = CalculateDenominations(change, .25);
            change = change - quarters * Convert.ToDecimal(.25);

            //Dimes

            dimes = CalculateDenominations(change, .10);
            change = change - dimes * Convert.ToDecimal(.10);

            //Nickles

            nickles = CalculateDenominations(change, .05);
            change = change - nickles * Convert.ToDecimal(.05);

            //Pennies

            pennies = Convert.ToInt32(change * 100);

            //Print out the change in denominations

            if (twenties == 1)
            {
                Console.Write(twenties + " twenty, ");
            }
            else if (twenties > 1)
            {
                Console.Write(twenties + " twenties, ");
            }

            if (tens == 1)
            {
                Console.Write(tens + " ten, ");
            }
            else if (tens > 1)
            {
                Console.Write(tens + " tens, ");
            }

            if (fives == 1)
            {
                Console.Write(fives + " five, ");
            }
            else if (fives > 1)
            {
                Console.Write(fives + " fives, ");
            }

            if (ones == 1)
            {
                Console.Write(ones + " one, ");
            }
            else if (ones > 1)
            {
                Console.Write(ones + " ones, ");
            }

            if (quarters == 1)
            {
                Console.Write(quarters + " quarter, ");
            }
            if (quarters > 1)
            {
                Console.Write(quarters + " quarters, ");
            }

            if (dimes == 1)
            {
                Console.Write(dimes + " dime, ");
            }
            if (dimes > 1)
            {
                Console.Write(dimes + " dimes, ");
            }

            if (nickles == 1)
            {
                Console.Write(nickles + " nickle, ");
            }
            if (nickles > 1)
            {
                Console.Write(nickles + " nickles, ");
            }

            if (pennies == 1)
            {
                Console.Write(pennies + " penny");
            }
            if (pennies > 1)
            {
                Console.Write(pennies + " pennies");
            }

            Console.WriteLine();

            //Bonus: Randomize change denomination output
            Console.WriteLine();

            int randNumOf20s = 0, randNumOf10s = 0, randNumOf5s = 0, randNumOf1s = 0, randNumOfQuarters = 0, randNumOfDimes = 0, randNumOfNickles = 0, randNumOfPennies = 0, tempValue, loopCount = 1, randNum;
            Random random = new Random();


            while (true)
            {
                randNum = random.Next(1, 9);

                switch (randNum)
                {
                    case 1:
                        if (twenties != 0)
                        {
                            if (randomizeChange - 20 >= 0)
                            {
                                randomizeChange = randomizeChange - 20;
                                randNumOf20s++;
                            }
                        }
                        break;
                    case 2:
                        if (tens != 0)
                        {
                            if (randomizeChange - 10 >= 0)
                            {
                                randomizeChange = randomizeChange - 10;
                                randNumOf10s++;
                            }

                        }
                        break;
                    case 3:
                        if (fives != 0)
                        {
                            if (randomizeChange - 5 >= 0)
                            {
                                randomizeChange = randomizeChange - 5;
                                randNumOf5s++;
                            }


                        }
                        break;
                    case 4:
                        if (ones != 0)
                        {
                            if (randomizeChange - 1 >= 0)
                            {
                                randomizeChange = randomizeChange - 1;
                                randNumOf1s++;
                            }

                        }
                        break;
                    case 5:
                        if (quarters != 0)
                        {
                            if (randomizeChange - .25m >= 0)
                            {
                                randomizeChange = randomizeChange - .25m;
                                randNumOfQuarters++;
                            }

                        }
                        break;
                    case 6:
                        if (dimes != 0)
                        {
                            if (randomizeChange - .10m >= 0)
                            {
                                randomizeChange = randomizeChange - .10m;
                                randNumOfDimes++;
                            }

                        }
                        break;
                    case 7:
                        if (nickles != 0)
                        {
                            if (randomizeChange - .05m >= 0)
                            {
                                randomizeChange = randomizeChange - .05m;
                                randNumOfNickles++;
                            }

                        }
                        break;
                    case 8:
                        if (pennies != 0)
                        {
                            if (randomizeChange - .01m >= 0)
                            {
                                randomizeChange = randomizeChange - .01m;
                                randNumOfPennies++;
                            }

                        }
                        break;

                }

                if (randomizeChange == 0) { break; }
            }


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

        }
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
    }
    }

