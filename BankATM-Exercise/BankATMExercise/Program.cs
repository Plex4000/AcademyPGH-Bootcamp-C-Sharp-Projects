using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankATMExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Zach's Bank!");
            decimal balance = 100.00m;
            while (true)
            {
                Console.WriteLine("Please select an action:");
                Console.WriteLine("[D]eposit");
                Console.WriteLine("[W]ithdraw");
                Console.WriteLine("[A]ccount Summary");

                string input = Console.ReadLine().ToLower();

                while (input != "a" && input != "w" && input != "d")
                {
                    Console.WriteLine("Please enter a valid input.");
                    Console.WriteLine("Please select an action:");
                    Console.WriteLine("[D]eposit");
                    Console.WriteLine("[W]ithdraw");
                    Console.WriteLine("[A]ccount Summary");
                }

                if (input == "a")
                {
                    Console.WriteLine("Your account balance is " + balance + ".");
                }
                if (input == "d")
                {
                    Console.Write("How much do you want to deposit? ");
                    decimal depositAmount = Convert.ToDecimal(Console.ReadLine());

                    balance = balance + depositAmount;

                    Console.WriteLine("Your new balance is " + balance + ".");
                }
                if(input == "w")
                {
                    if(balance == 0)
                    {
                        Console.WriteLine("You have a zero dollar balance! You cannot withdraw money from your account.");
                    }
                    else
                    {
                        Console.Write("How much do you want to withdraw? ");
                        decimal withdrawAmount = Convert.ToDecimal(Console.ReadLine());

                        if(withdrawAmount > balance)
                        {
                            Console.WriteLine("You do not have enough money in the account to complete the transaction!");
                        }
                        else
                        {
                            balance = balance - withdrawAmount;

                            Console.WriteLine("Your new balance is " + balance + ".");
                        }
                    } 
                }
                Console.Write("Would you like another transaction? Yes or No: ");
                string answer = Console.ReadLine().ToLower();
                if (answer == "no")
                    break;
            }
        }
    }
}
