using System;
using System.Collections.Generic;

namespace BattleShipExercise
{
    class Program
    { 
        static void Main(string[] args)
        {
            Random rand = new Random();
            string[,] shipGrid = new string[8, 8];

            //initialize the grid with 0s
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    shipGrid[i, j] = "0";
                }
            }

            int row;
            int col;
            bool skipCoor = false;

            //create array for different ship lengths
            int[][,] ships = new int[4][,] 
            {
               new int[4,2] { {0,1},{0,0},{0,0},{0,0} },
               new int[3,2] { {0,0},{0,0},{0,0} },
               new int[2,2] { {0,0}, {0,0} },
               new int[1,2] { {0,0} }
            };

            Console.WriteLine(ships[1].GetLength(0));

            for (int i = 0; i < ships.GetLength(0); i++)
            {
                for (int j = 0; j < ships[i].GetLength(0); j++)
                {

                }
            }

            //randomly place ships on grid and populate the ships array
            for (int i = 1; i <= 4; i++)
            {
                if (i == 1)
                {
                    col = rand.Next(0, 7);

                    while (col == 5 || col == 6 || col == 7)
                    {
                        col = rand.Next(0, 7);
                    }

                    row = rand.Next(0, 7);
                    shipGrid[row, col] = "*";
                    shipGrid[row, col + 1] = "*";
                    shipGrid[row, col + 2] = "*";
                    shipGrid[row, col + 3] = "*";

                    ships[0][0, 0] = row;
                    ships[0][0, 1] = col;

                    ships[0][1, 0] = row;
                    ships[0][1, 1] = col + 1;

                    ships[0][2, 0] = row;
                    ships[0][2, 1] = col + 2;

                    ships[0][3, 0] = row;
                    ships[0][3, 1] = col + 3;

                }

                if (i == 2)
                {
                    row = rand.Next(0, 7);
                    col = rand.Next(0, 7);

                    while (col == 6 || col == 7 || GetCoordExistsFirstShip(ships, col, row))
                    {
                        row = rand.Next(0, 7);
                        col = rand.Next(0, 7);
                    }

                    shipGrid[row, col] = "*";
                    shipGrid[row, col + 1] = "*";
                    shipGrid[row, col + 2] = "*";

                    ships[1][0, 0] = row;
                    ships[1][0, 1] = col;

                    ships[1][1, 0] = row;
                    ships[1][1, 1] = col + 1;

                    ships[1][2, 0] = row;
                    ships[1][2, 1] = col + 2;



                }

                if (i == 3)
                {
                    row = rand.Next(0, 7);
                    col = rand.Next(0, 7);

                    while (col == 7 || GetCoordExistsFirstShip(ships, col, row) || GetCoordExistsSecondShip(ships, col, row))
                    {
                        row = rand.Next(0, 7);
                        col = rand.Next(0, 7);
                    }


                    shipGrid[row, col] = "*";
                    shipGrid[row, col + 1] = "*";

                    ships[2][0, 0] = row;
                    ships[2][0, 1] = col;

                    ships[2][1, 0] = row;
                    ships[2][1, 1] = col + 1;
                }

                if (i == 4)
                {
                    row = rand.Next(0, 7);
                    col = rand.Next(0, 7);

                    while (GetCoordExistsFirstShip(ships, col, row) || GetCoordExistsSecondShip(ships, col, row) || GetCoordExistsThirdShip(ships, col, row))
                    {
                        row = rand.Next(0, 7);
                        col = rand.Next(0, 7);
                    }

                    shipGrid[row, col] = "*";

                    ships[3][0, 0] = row;
                    ships[3][0, 1] = col;

                }
            }

            //print out the grid with the ships
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    Console.Write(shipGrid[i, j]);
                }
                Console.WriteLine();
            }

            var shipCount = 4;
            //play game
            while (shipCount != 0)
            {

                Console.WriteLine("Which coordinate do you want to shoot at? example: 0 1");

                string input = Console.ReadLine();
                string[] inputArray = input.Split();
                int[] intArray = Array.ConvertAll(inputArray, s => int.Parse(s));

                if (shipGrid[intArray[0], intArray[1]] == "*")
                {
                    Console.WriteLine("Yay! you hit a ship!");
                    shipGrid[intArray[0], intArray[1]] = "X";

                    if (GetCoordExistsFirstShip(ships, intArray[1], intArray[0]))
                    {
                        int index = Array.IndexOf(ships[0], intArray[0]);
                        

                    }


                    shipCount--;

                    for (int i = 0; i < 8; i++)
                    {
                        for (int j = 0; j < 8; j++)
                        {
                            Console.Write(shipGrid[i, j]);
                        }
                        Console.WriteLine();
                    }

                }
                else if (shipGrid[intArray[0], intArray[1]] != "*")
                {
                    Console.WriteLine("You didn't hit a ship.");


                    if (intArray[0] == 0 && intArray[1] == 0)
                    {
                        if (shipGrid[intArray[0], intArray[1] + 1] == "*" || shipGrid[intArray[0] + 1, intArray[1]] == "*")
                        {
                            Console.Write("But you were close!");
                        }
                    }

                    else if (intArray[0] == 0 && intArray[1] == 7)
                    {
                        if (shipGrid[intArray[0], intArray[1] - 1] == "*" || shipGrid[intArray[0] + 1, intArray[1]] == "*")
                        {
                            Console.Write("But you were close!");
                        }
                    }

                    else if (intArray[0] == 7 && intArray[1] == 0)
                    {
                        if (shipGrid[intArray[0] - 1, intArray[1]] == "*" || shipGrid[intArray[0], intArray[1] + 1] == "*")
                        {
                            Console.Write("But you were close!");
                        }
                    }

                    else if (intArray[0] == 7 && intArray[1] == 7)
                    {
                        if (shipGrid[intArray[0] - 1, intArray[1]] == "*" || shipGrid[intArray[0], intArray[1] - 1] == "*")
                        {
                            Console.Write("But you were close!");
                        }
                    }

                    else if (intArray[0] == 0 && intArray[1] != 0 && intArray[1] != 7)
                    {
                        if (shipGrid[0, intArray[1] + 1] == "*" || shipGrid[0, intArray[1] - 1] == "*" || shipGrid[1, intArray[1]] == "*")
                        {
                            Console.Write("But you were close!");
                        }
                    }

                    else if (intArray[0] == 7 && intArray[1] != 0 && intArray[1] != 7)
                    {
                        if (shipGrid[7, intArray[1] - 1] == "*" || shipGrid[7, intArray[1] + 1] == "*" || shipGrid[6, intArray[1]] == "*")
                        {
                            Console.Write("But you were close!");
                        }
                    }

                    else if (intArray[1] == 0 && intArray[0] != 0 && intArray[0] != 7)
                    {
                        if (shipGrid[intArray[0], 1] == "*" || shipGrid[intArray[0] - 1, 0] == "*" || shipGrid[intArray[0] + 1, 0] == "*")
                        {
                            Console.Write("But you were close!");
                        }
                    }

                    else if (intArray[1] == 7 && intArray[0] != 0 && intArray[0] != 7)
                    {
                        if (shipGrid[intArray[0], 6] == "*" || shipGrid[intArray[0] - 1, 7] == "*" || shipGrid[intArray[0] + 1, 7] == "*")
                        {
                            Console.Write("But you were close!");

                        }
                    }
                    else
                    {
                        if (shipGrid[intArray[0] + 1, intArray[0]] == "*" || shipGrid[intArray[0] - 1, intArray[0]] == "*" || shipGrid[intArray[0], intArray[1] + 1] == "*" || shipGrid[intArray[0], intArray[1] - 1] == "*")
                        {
                            Console.Write("But you were close!");

                        }
                    }

                }

            }
            Console.WriteLine("You won the game!");
        }

        public static bool GetCoordExistsFirstShip(int[][,] ships, int col, int row)
        {
            bool skipCoord = true;
           
                for (int i = 0; i < ships[0].GetLength(0); i++)
                {
                    if (ships[0][i, 1] == col && ships[0][i, 0] == row)
                    {
                        skipCoord = true;
                    }
                    else
                    {
                        skipCoord = false;
                    }
                }
            
            return skipCoord;
        }
        public static bool GetCoordExistsSecondShip(int[][,] ships, int col, int row)
        {
            bool skipCoord = true;
          
                for (int i = 0; i < ships[1].GetLength(0); i++)
                {
                    if (ships[1][i, 1] == col && ships[1][i, 0] == row)
                    {
                        skipCoord = true;
                    }
                    else
                    {
                        skipCoord = false;
                    }
                }
            
            return skipCoord;
        }

        public static bool GetCoordExistsThirdShip(int[][,] ships, int col, int row)
        {
            bool skipCoord = true;

            for (int i = 0; i < ships[2].GetLength(0); i++)
            {
                if (ships[2][i, 1] == col && ships[2][i, 0] == row)
                {
                    skipCoord = true;
                }
                else
                {
                    skipCoord = false;
                }
            }

            return skipCoord;
        }

    }
}