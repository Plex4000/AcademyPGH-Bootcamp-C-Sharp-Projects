using System;

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

            var change = pay - cost;

            Console.WriteLine("They get $" + change + " in change.");

            //Perform some calculations to determine if change ends in a 3
            var threeEnd = 0m;
            var wholeDollars = Convert.ToInt32(Math.Floor(change));
            if (change - wholeDollars != 0)
            {
                threeEnd = (((change - wholeDollars) * 100) - 3) % 10;
            }
            else if (change - wholeDollars == 0)
            {
                threeEnd = (change - 3) % 10;
            }

            //if threeEnd is greater than 0 then the change does not end in a 3. So, give non-randomized denominations in change
            if (threeEnd > 0)
            {
                // $100 bills

                hundreds = CalculateDenominations(change, 100);
                change = change - hundreds * 100;

                // $50 bills

                fifties = CalculateDenominations(change, 50);
                change = change - fifties * 50;

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

            }

            /* if threeEnd equals 0 then the change ends in a 3. So, give randomized denominations in change 
               There is repeated code here which can be consolidated into a single method/function, but chose not to 
               because Zach has not covered functions yet*/

            else if (threeEnd == 0)
            {

                while (change > 0)
                {
                    //random number of $100 bills

                    Tuple<int, decimal> tuple = GetRandomDenominations(hundreds, change);
                    hundreds = tuple.Item1;
                    change = tuple.Item2;

                    //random number of $50 bills

                    Tuple<int, decimal> tuple2 = GetRandomDenominations(fifties, change);
                    fifties = tuple2.Item1;
                    change = tuple2.Item2;

                    //random number of $20 bills

                    Tuple<int, decimal> tuple3 = GetRandomDenominations(twenties, change);
                    twenties = tuple3.Item1;
                    change = tuple3.Item2;

                    //random number of $10 bills

                    Tuple<int, decimal> tuple4 = GetRandomDenominations(tens, change);
                    tens = tuple4.Item1;
                    change = tuple4.Item2;

                    //random number of $5 bills

                    Tuple<int, decimal> tuple5 = GetRandomDenominations(fives, change);
                    fives = tuple5.Item1;
                    change = tuple5.Item2;

                    //random number of $1 bills

                    Tuple<int, decimal> tuple6 = GetRandomDenominations(ones, change);
                    ones = tuple6.Item1;
                    change = tuple6.Item2;

                    //random number of quarters

                    Tuple<int, decimal> tuple7 = GetRandomDenominations(quarters, change);
                    quarters = tuple7.Item1;
                    change = tuple7.Item2;

                    //random number of dimes

                    Tuple<int, decimal> tuple8 = GetRandomDenominations(dimes, change);
                    dimes = tuple8.Item1;
                    change = tuple8.Item2;

                    //random number of nickles

                    Tuple<int, decimal> tuple9 = GetRandomDenominations(nickles, change);
                    nickles = tuple9.Item1;
                    change = tuple9.Item2;

                    //random number of pennies

                    Tuple<int, decimal> tuple10 = GetRandomDenominations(pennies, change);
                    pennies = tuple10.Item1;
                    change = tuple10.Item2;

                }
            }

            //Print out the change in denominations

            if (hundreds == 1)
            {
                Console.Write(hundreds + " hundred, ");
            }
            else if (hundreds > 1)
            {
                Console.Write(hundreds + " hundreds, ");
            }

            if (fifties == 1)
            {
                Console.Write(fifties + " fifty, ");
            }
            else if (fifties > 1)
            {
                Console.Write(fifties + " fifties, ");
            }

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

            Console.ReadLine();
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

        static int tempValue;

        static Random random = new Random();
        public static Tuple<int, decimal> GetRandomDenominations(int numOfDenominations, decimal change)
        {
            tempValue = random.Next(0, numOfDenominations + 10);
            if (tempValue * 100 < change)
            {
                numOfDenominations += tempValue;
                change -= tempValue * 100;
            }
            if (tempValue * 100 == change)
            {
                numOfDenominations += tempValue;
                change = 0;
            }
            return new Tuple<int, decimal>(numOfDenominations, change);
        }

    }
}

