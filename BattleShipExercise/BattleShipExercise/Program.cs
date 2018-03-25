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

            string[,] shipGrid = new string[8, 8];
            var shipCount = 13;

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    shipGrid[i, j] = "0";
                }
            }

            shipGrid[1, 4] = "*";
            shipGrid[2, 2] = "*";
            shipGrid[2, 3] = "*";
            shipGrid[4, 3] = "*";
            shipGrid[4, 4] = "*";
            shipGrid[5, 0] = "*";
            shipGrid[5, 2] = "*";
            shipGrid[6, 6] = "*";
            shipGrid[6, 7] = "*";
            shipGrid[7, 2] = "*";
            shipGrid[7, 3] = "*";
            shipGrid[7, 4] = "*";
            shipGrid[7, 5] = "*";

            while (shipCount != 0)
            {
               
                    Console.WriteLine("Which coordinate do you want to shoot at? example: 0 1");

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
                            if (shipGrid[intArray[0] + 1, intArray[0]] == "*" || shipGrid[intArray[0] - 1, intArray[0]] == "*" || shipGrid[intArray[0], intArray[1] + 1] == "*" || shipGrid[intArray[0], intArray[1] - 1] == "*")
                            {
                                Console.Write(" But you were close!");

                            }
                        }
                        
                    }
                
            }
            Console.WriteLine("You won the game!");
        }
    }
}