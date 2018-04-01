using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conway
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create arrays for current state and next state arrays
            // "X" = dead cell
            // "O" = alive cell
            int length = 10;
            int height = 10;
            string[,] carray = new string[height, length];
            string[,] narray = new string[height, length];
            Random roll = new Random();

            //Fill up current array
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    //Randomly pick alive or dead cell based on outcome of RNG of 0 or 1
                    int rand = roll.Next(0, 2);
                    if (rand == 1)
                        carray[i, j] = "O";
                    else
                        carray[i, j] = "X";
                }
            }


            while (true)
            {
                //Print current array (pause after)
                for (int i = 0; i < height; i++)
                {
                    for (int j = 0; j < length; j++)
                    {
                        Console.Write(carray[i, j]);
                    }
                    Console.WriteLine();
                }
                Console.ReadLine();

                //Evaluate surrounding cells of current index
                int count = 0;
                for (int i = 0; i < height; i++)
                {
                    for (int j = 0; j < length; j++)
                    {
                        count = 0;

                        //left side
                        if(j == 0 && i != 0 && i != 9)
                        {
                            if (carray[i + 1, 0] == "0")
                            {
                                count++;
                            }
                            if (carray[i, 1] == "0")
                            {
                                count++;
                            }
                            if (carray[i - 1, 0] == "0")
                            {
                                count++;
                            }
                            if (carray[i + 1, 1] == "0")
                            {
                                count++;
                            }
                            if (carray[i - 1, 1] == "0")
                            {
                                count++;
                            }
                        }
                        //right side
                        else if (j == 9 && i != 0 && i != 9)
                        {
                            if (carray[i + 1, 9] == "0")
                            {
                                count++;
                            }
                            if (carray[i, 8] == "0")
                            {
                                count++;
                            }
                            if (carray[i - 1, 9] == "0")
                            {
                                count++;
                            }
                            if (carray[i + 1, 8] == "0")
                            {
                                count++;
                            }
                            if (carray[i - 1, 8] == "0")
                            {
                                count++;
                            }
                        }
                        //top
                        else if (i == 0 && j != 0 && j != 9)
                        {
                            if (carray[0, j - 1] == "0")
                            {
                                count++;
                            }
                            if (carray[0, j + 1] == "0")
                            {
                                count++;
                            }
                            if (carray[1, j] == "0")
                            {
                                count++;
                            }
                            if (carray[1, j - 1] == "0")
                            {
                                count++;
                            }
                            if (carray[1, j + 1] == "0")
                            {
                                count++;
                            }
                        }
                        //bottom
                        else if (i == 9 && j != 0 && j != 9)
                        {
                            if (carray[9, j - 1] == "0")
                            {
                                count++;
                            }
                            if (carray[9, j + 1] == "0")
                            {
                                count++;
                            }
                            if (carray[8, j] == "0")
                            {
                                count++;
                            }
                            if (carray[8, j - 1] == "0")
                            {
                                count++;
                            }
                            if (carray[8, j + 1] == "0")
                            {
                                count++;
                            }
                        }
                        //top left corner
                        else if (i == 0 && j == 0)
                        {
                            if (carray[0, 1] == "0")
                            {
                                count++;
                            }
                            if (carray[1, 0] == "0")
                            {
                                count++;
                            }
                            if (carray[1, 1] == "0")
                            {
                                count++;
                            }
                        }
                        //top right corner
                        else if (i == 0 && j == 9)
                        {
                            if (carray[0, 8] == "0")
                            {
                                count++;
                            }
                            if (carray[1, 9] == "0")
                            {
                                count++;
                            }
                            if (carray[1, 8] == "0")
                            {
                                count++;
                            }
                        }
                        //bottom left corner
                        else if (i == 9 && j == 0)
                        {
                            if (carray[9, 1] == "0")
                            {
                                count++;
                            }
                            if (carray[8, 0] == "0")
                            {
                                count++;
                            }
                            if (carray[8, 1] == "0")
                            {
                                count++;
                            }
                        }
                        //bottom right corner
                        else if (i == 9 && j == 9)
                        {
                            if (carray[9, 8] == "0")
                            {
                                count++;
                            }
                            if (carray[8, 9] == "0")
                            {
                                count++;
                            }
                            if (carray[8, 8] == "0")
                            {
                                count++;
                            }
                        }
                        else
                        {
                            if (carray[i, j - 1] == "0")
                            {
                                count++;
                            }
                            if (carray[i, j + 1] == "0")
                            {
                                count++;
                            }
                            if (carray[i + 1, j] == "0")
                            {
                                count++;
                            }
                            if (carray[i - 1, j] == "0")
                            {
                                count++;
                            }
                            if (carray[1 + 1, j - 1] == "0")
                            {
                                count++;
                            }
                            if (carray[1 + 1, j + 1] == "0")
                            {
                                count++;
                            }
                            if (carray[1 - 1, j - 1] == "0")
                            {
                                count++;
                            }
                            if (carray[1 - 1, j + 1] == "0")
                            {
                                count++;
                            }
                        }

                        //Left and Right 
                        //if (j - 1 > 0) //left
                        //    if (carray[j - 1, i] == "O")
                        //        count++;
                        //if (j + 1 < length) //right
                        //    if (carray[j + 1, i] == "O")
                        //        count++;
                        ////Above and Below
                        //if (i - 1 > 0) //bottom
                        //    if (carray[j, i - 1] == "O")
                        //        count++;
                        //if (i + 1 < height) //top
                        //    if (carray[j, i + 1] == "O")
                        //        count++;
                        ////Corners
                        //if ((i + 1 < height) && (j - 1 > 0))   //Top left corner
                        //    if (carray[i + 1, j - 1] == "O")
                        //        count++;
                        //if ((i + 1 < height) && (j + 1 > length))   //Top right corner
                        //    if (carray[i + 1, j + 1] == "O")
                        //        count++;
                        //if ((i - 1 > 0) && (j - 1 > 0))   //Bottom left corner
                        //    if (carray[i - 1, j - 1] == "O")
                        //        count++;
                        //if ((i - 1 > 0) && (j + 1 < length))   //Top right corner
                        //    if (carray[i - 1, j + 1] == "O")
                        //        count++;

                        /* 1.Any live cell with fewer than two live neighbors dies, as if caused by underpopulation.
         2.Any live cell with two or three live neighbors lives on to the next generation.
         3.Any live cell with more than three live neighbors dies, as if by overpopulation
         4.Any dead cell with exactly three live neighbors becomes a live cell, as if by reproduction. */

                        //Determine next state for current index
                        if (carray[i, j] == "O") //current index is alive
                            if (count > 3)
                                narray[j, i] = "X";//next state is dead
                            else
                                narray[j, i] = "O";//next state is alive
                        else if (carray[j, i] == "X")
                            if (count == 3)
                                narray[j, i] = "O";
                            else
                                narray[j, i] = "X";



                    }
                }//Evaluate current index loops

                //Write the next state to the current state
                for (int i = 0; i < height; i++)
                {
                    for (int j = 0; j < length; j++)
                    {
                        carray[j, i] = narray[j, i];
                    }
                }

            }//Loop entire program
        } //Main
    }
}
