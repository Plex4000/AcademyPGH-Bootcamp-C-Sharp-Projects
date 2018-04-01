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
            Console.Write("How many rows do you want? ");
            int rows = Convert.ToInt32(Console.ReadLine());
            Console.Write("How many rows do you want? ");
            int length = Convert.ToInt32(Console.ReadLine());
            string[,] carray = new string[rows, length];
            string[,] narray = new string[rows, length];
            Random roll = new Random();
            int rand;
            //Fill up current array
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    //Randomly pick alive or dead cell based on outcome of RNG of 0 or 1
                    rand = roll.Next(0, 2);
                    if (rand == 1)
                        carray[i, j] = "O";
                    else
                        carray[i, j] = "X";
                }
            }


            while (true)
            {
                //Print current array (pause after)
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < length; j++)
                    {
                        Console.Write(carray[i, j]);
                    }
                    Console.WriteLine();
                }


                //Evaluate surrounding cells of current index
                int count;
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < length; j++)
                    {
                        count = 0;
                        
                        //left side
                        if (j == 0 && i != 0 && i != rows - 1)
                        {
                            if (carray[i + 1, 0] == "O")
                            {
                                count++;
                            }
                            if (carray[i, 1] == "O")
                            {
                                count++;
                            }
                            if (carray[i - 1, 0] == "O")
                            {
                                count++;
                            }
                            if (carray[i + 1, 1] == "O")
                            {
                                count++;
                            }
                            if (carray[i - 1, 1] == "O")
                            {
                                count++;
                            }
                        }
                        //right side
                        else if (j == 4 && i != 0 && i != rows - 1)
                        {
                            if (carray[i + 1, length - 1] == "O")
                            {
                                count++;
                            }
                            if (carray[i, length - 2] == "O")
                            {
                                count++;
                            }
                            if (carray[i - 1, length - 1] == "O")
                            {
                                count++;
                            }
                            if (carray[i + 1, length - 2] == "O")
                            {
                                count++;
                            }
                            if (carray[i - 1, length - 2] == "O")
                            {
                                count++;
                            }
                        }
                        //top
                        else if (i == 0 && j != 0 && j != length - 1)
                        {
                            if (carray[0, j - 1] == "O")
                            {
                                count++;
                            }
                            if (carray[0, j + 1] == "O")
                            {
                                count++;
                            }
                            if (carray[1, j] == "O")
                            {
                                count++;
                            }
                            if (carray[1, j - 1] == "O")
                            {
                                count++;
                            }
                            if (carray[1, j + 1] == "O")
                            {
                                count++;
                            }
                        }
                        //bottom
                        else if (i == rows - 1 && j != 0 && j != length - 1)
                        {
                            if (carray[rows - 1, j - 1] == "O")
                            {
                                count++;
                            }
                            if (carray[rows, j + 1] == "O")
                            {
                                count++;
                            }
                            if (carray[rows - 2, j] == "O")
                            {
                                count++;
                            }
                            if (carray[rows - 2, j - 1] == "O")
                            {
                                count++;
                            }
                            if (carray[rows - 2, j + 1] == "O")
                            {
                                count++;
                            }
                        }
                        //top left corner
                        else if (i == 0 && j == 0)
                        {
                            if (carray[0, 1] == "O")
                            {
                                count++;
                            }
                            if (carray[1, 0] == "O")
                            {
                                count++;
                            }
                            if (carray[1, 1] == "O")
                            {
                                count++;
                            }
                        }
                        //top right corner
                        else if (i == 0 && j == length - 1)
                        {
                            if (carray[0, length - 2] == "O")
                            {
                                count++;
                            }
                            if (carray[1, length - 1] == "O")
                            {
                                count++;
                            }
                            if (carray[1, length - 2] == "O")
                            {
                                count++;
                            }
                        }
                        //bottom left corner
                        else if (i == rows - 1 && j == 0)
                        {
                            if (carray[rows - 1, 1] == "O")
                            {
                                count++;
                            }
                            if (carray[rows - 2, 0] == "O")
                            {
                                count++;
                            }
                            if (carray[rows - 2 , 1] == "O")
                            {
                                count++;
                            }
                        }
                        //bottom right corner
                        else if (i == rows - 1 && j == length - 1)
                        {
                            if (carray[rows - 1, length - 2] == "O")
                            {
                                count++;
                            }
                            if (carray[rows - 2, length - 1] == "O")
                            {
                                count++;
                            }
                            if (carray[rows - 2, length - 2] == "O")
                            {
                                count++;
                            }
                        }
                        //all other cells
                        else
                        {
                            if (carray[i, j - 1] == "O")
                            {
                                count++;
                            }
                            if (carray[i, j + 1] == "O")
                            {
                                count++;
                            }
                            if (carray[i + 1, j] == "O")
                            {
                                count++;
                            }
                            if (carray[i - 1, j] == "O")
                            {
                                count++;
                            }
                            if (carray[1 + 1, j - 1] == "O")
                            {
                                count++;
                            }
                            if (carray[1 + 1, j + 1] == "O")
                            {
                                count++;
                            }
                            if (carray[1 - 1, j - 1] == "O")
                            {
                                count++;
                            }
                            if (carray[1 - 1, j + 1] == "O")
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

                        /* 
                         1. live with < 2 live neighbors dies
                         2. live with 2 or 3 live neighbors lives
                         3. live with > 3 live neighbors dies
                         4. dead with 3 live n becomes live cell
                         
                         */

                        //Determine next state for current index
                        if (carray[i, j] == "O")
                        { //current index is alive
                            if (count > 3 || count < 2)
                            {
                                narray[i, j] = "X";//next state is dead
                            }
                            else
                            {
                                narray[i, j] = "O";
                            }

                            if (count == 2 || count == 3)
                            {
                                narray[i, j] = "O";
                            }
                            else
                            {
                                narray[i, j] = "X";
                            }
                        }
                   
                        else if (carray[i, j] == "X")
                        {
                            if (count == 3)
                            {
                                narray[i, j] = "O";
                            }

                            else
                            {
                                narray[i, j] = "X";
                            }
                                
                        }
                           



                    }
                }//Evaluate current index loops

                //Write the next state to the current state
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < length; j++)
                    {
                        carray[i, j] = narray[i, j];
                    }
                }

                Console.ReadLine();

            }//Loop entire program
        } //Main
    }
}
