using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShipExercise
{
    class Program
    {
        static void Main(string[] args)
        {

            var shipCount = 13;
            string[,] shipGrid = new string[8, 8]
                {
                { "0", "0", "0", "0", "0", "0", "0", "0"},
                { "0", "0", "0", "0", "*", "0", "0", "0"},
                { "0", "0", "*", "*", "0", "0", "0", "0"},
                { "0", "0", "0", "0", "0", "0", "0", "0"},
                { "0", "0", "0", "*", "*", "0", "0", "0"},
                { "*", "0", "*", "0", "0", "0", "0", "0"},
                { "0", "0", "0", "0", "0", "0", "*", "*"},
                { "0", "0", "*", "*", "*", "*", "0", "0"}
                };

            while (true)
            {
                if(shipCount == 0)
                {
                    Console.WriteLine("You won the game!");
                    break;
                }
                else
                {
                    Console.WriteLine("Which coordinate do you want to shoot?");

                    string input = Console.ReadLine();
                    string[] inputArray = input.Split();
                    int[] intArray = Array.ConvertAll(inputArray, s => int.Parse(s));

                    if (shipGrid[intArray[0], intArray[1]] == "*")
                    {
                        Console.WriteLine("Yay! you hit a ship!");
                        shipGrid[intArray[0], intArray[1]] = "0";
                        shipCount--;
                    }
                    else if (shipGrid[intArray[0], intArray[1]] != "*")
                    {
                        Console.WriteLine("You didn't hit a ship. Try again!");

                        if (shipGrid[intArray[0] - 1, intArray[1]] != null && shipGrid[intArray[0]-1, intArray[1]] == "*")
                        {
                            Console.WriteLine("close!");
                        }
                        else if(shipGrid[intArray[0] + 1, intArray[1]] != null && shipGrid[intArray[0] + 1, intArray[1]] == "*")
                        {
                            Console.WriteLine("close!");
                        }
                        else if (shipGrid[intArray[0], intArray[1] + 1] != null && shipGrid[intArray[0], intArray[1] + 1] == "*")
                        {
                            Console.WriteLine("close!");
                        }
                        else if (shipGrid[intArray[0] + 1, intArray[1] - 1] != null && shipGrid[intArray[0] + 1, intArray[1] - 1] == "*")
                        {
                            Console.WriteLine("close!");
                        }

                    }
                }
            }
        }
    }
}
