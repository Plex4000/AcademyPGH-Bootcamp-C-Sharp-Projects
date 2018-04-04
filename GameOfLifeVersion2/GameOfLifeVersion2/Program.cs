using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife_Evening
{
    class Program
    {
        static int Width = 5;
        static int Height = 5;
        static void Main(string[] args)
        {
            //DONE: 2x 2D grid:bool
            //DONE: infinite loop
            //DONE: logic for neighbors, if with offset
            //DONE: logic, state of the cell
            //DONE: logic, whether lives or dies
            //DONE: print grid
            //DONE: Init()
            //DONE: var width and height
            //FUNCTIONS:
            //DONE: void INit(bool[,])
            //DONE: void PrintGrid(bool[,])
            //DONE:int CountNeighbors(bool[,],int x, int y)

            bool[,] cells = new bool[Width, Height];
            bool[,] state = new bool[Width, Height];

            //Initializes the cells
            Init(cells);
            Init(state);


            while (true)
            {
                //Print Grid
                PrintGrid(cells);

                //loop through to check each of the states
                for (int posX = 0; posX < Width; posX++)
                {
                    for (int posY = 0; posY < Height; posY++)
                    {
                        //Count surrounding neighbors
                        int neighbors = CountNeighbors(cells, posX, posY);

                        if (cells[posX, posY]) //Alive
                        {
                            //check if over or under populated
                            if (neighbors > 3 || neighbors < 2)
                            {
                                state[posX, posY] = false;
                            }
                        }
                        else //Dead
                        {
                            //check for reproduction
                            if (neighbors == 3)
                            {
                                state[posX, posY] = true;
                            }
                        }
                    }
                }


                //modify the original cells state 
                for (int i = 0; i < Width; i++)
                {
                    for (int j = 0; j < Height; j++)
                    {
                        cells[i, j] = state[i, j];
                    }
                }

                Console.ReadLine();
            }
        }

        //Seed the initial grid
        static void Init(bool[,] grid)
        {
            grid[2, 1] = true;
            grid[2, 2] = true;
            grid[2, 3] = true;
        }

        //Output our grid to the console
        static void PrintGrid(bool[,] grid)
        {
            for (int x = 0; x < Width; x++)
            {
                for (int y = 0; y < Height; y++)
                {
                    if (grid[x, y])
                        Console.Write("O ");
                    else
                        Console.Write("X ");
                }
                Console.WriteLine();
            }
        }
        //Count our surrounding neighbors
        static int CountNeighbors(bool[,] grid, int x, int y)
        {
            int neighbors = 0;

            //OOO
            //OXO
            //OOO
            if (!OutOfBounds(x - 1, y - 1) && grid[x - 1, y - 1])
            {
                //XOO
                //OXO
                //OOO
                neighbors++;
            }
            if (!OutOfBounds(x, y - 1) && grid[x, y - 1])
            {
                //OXO
                //OXO
                //OOO
                neighbors++;
            }
            if (!OutOfBounds(x + 1, y - 1) && grid[x + 1, y - 1])
            {
                //OOX
                //OXO
                //OOO
                neighbors++;
            }
            if (!OutOfBounds(x - 1, y) && grid[x - 1, y])
            {
                //OOO
                //XXO
                //OOO
                neighbors++;
            }
            if (!OutOfBounds(x + 1, y) && grid[x + 1, y])
            {
                //OOO
                //OXX
                //OOO
                neighbors++;
            }
            if (!OutOfBounds(x - 1, y + 1) && grid[x - 1, y + 1])
            {
                //OOO
                //OXO
                //XOO
                neighbors++;
            }
            if (!OutOfBounds(x, y + 1) && grid[x, y + 1])
            {
                //OOO
                //OXO
                //OXO
                neighbors++;
            }
            if (!OutOfBounds(x + 1, y + 1) && grid[x + 1, y + 1])
            {
                //OOO
                //OXO
                //OOX
                neighbors++;
            }

            return neighbors;
        }

        //Make sure we stay in line #CheckYoSelf
        static bool OutOfBounds(int x, int y)
        {
            bool outOfBounds = false;

            if (x < 0 || y < 0 || x >= Width || y >= Height)
                outOfBounds = true;

            return outOfBounds;
        }
    }
}