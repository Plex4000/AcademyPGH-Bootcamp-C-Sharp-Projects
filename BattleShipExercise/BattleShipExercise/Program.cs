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
                if (shipCount == 0)
                {
                    Console.WriteLine("You won the game!");
                    break;
                }
                else
                {
                    Console.WriteLine("Which coordinate do you want to shoot? example: 0 1");

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
                        Console.Write("You didn't hit a ship.");


                        if (intArray[0] == 0 && intArray[1] == 0)
                        {
                            if (shipGrid[intArray[0], intArray[1] + 1] == "*" || shipGrid[intArray[0] + 1, intArray[1]] == "*")
                            {
                                Console.Write(" But you were close!");
                            }
                        }

                        else if (intArray[0] == 0 && intArray[1] == 7)
                        {
                            if (shipGrid[intArray[0], intArray[1] - 1] == "*" || shipGrid[intArray[0] + 1, intArray[1]] == "*")
                            {
                                Console.Write(" But you were close!");
                            }
                        }

                        else if (intArray[0] == 7 && intArray[1] == 0)
                        {
                            if (shipGrid[intArray[0] - 1, intArray[1]] == "*" || shipGrid[intArray[0], intArray[1] + 1] == "*")
                            {
                                Console.Write(" But you were close!");
                            }
                        }

                        else if (intArray[0] == 7 && intArray[1] == 7)
                        {
                            if (shipGrid[intArray[0] - 1, intArray[1]] == "*" || shipGrid[intArray[0], intArray[1] - 1] == "*")
                            {
                                Console.Write(" But you were close!");
                            }
                        }

                        else if (intArray[0] == 0 && intArray[1] != 0 && intArray[1] != 7)
                        {
                            if (shipGrid[0, intArray[1] + 1] == "*" || shipGrid[0, intArray[1] - 1] == "*" || shipGrid[1, intArray[1]] == "*")
                            {
                                Console.Write(" But you were close!");
                            }
                        }

                        else if (intArray[0] == 7 && intArray[1] != 0 && intArray[1] != 7)
                        {
                            if (shipGrid[7, intArray[1] - 1] == "*" || shipGrid[7, intArray[1] + 1] == "*" || shipGrid[6, intArray[1]] == "*")
                            {
                                Console.Write(" But you were close!");
                            }
                        }

                        else if (intArray[1] == 0 && intArray[0] != 0 && intArray[0] != 7)
                        {
                            if (shipGrid[intArray[0], 1] == "*" || shipGrid[intArray[0] - 1, 0] == "*" || shipGrid[intArray[0] + 1, 0] == "*")
                            {
                                Console.Write(" But you were close!");
                            }
                        }

                        else if (intArray[1] == 7 && intArray[0] != 0 && intArray[0] != 7)
                        {
                            if (shipGrid[intArray[0], 6] == "*" || shipGrid[intArray[0] - 1, 7] == "*" || shipGrid[intArray[0] + 1, 7] == "*")
                            {
                                Console.Write(" But you were close!");

                            }
                        }
                        else
                        {
                            if (shipGrid[intArray[0] + 1, intArray[0]] == "*" || shipGrid[intArray[0] - 1, intArray[0]] == "*" || shipGrid[intArray[0], intArray[1] + 1]  == "*" || shipGrid[intArray[0], intArray[1] - 1] == "*")
                            {
                                Console.Write(" But you were close!");

                            }
                        }
                        Console.WriteLine();
                    }
                }
            }
        }
    }
}