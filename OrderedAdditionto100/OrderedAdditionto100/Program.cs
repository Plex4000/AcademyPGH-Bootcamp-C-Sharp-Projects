using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsecutiveNumAdditionEqualto100
{
    class Program
    {
        static void Main(string[] args)
        {

            int[][] possibleNums = { new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, new int[] { 12, 23, 34, 45, 56, 67, 78, 89 } };

            string[] mathOperator = new string[] { "plus", "minus" };
            Random rand = new Random();
            int randomNum;

            while (true)
            {

                ArrayList pickedNums = new ArrayList();
                for (int i = 0; i < 9; i++)
                {
                    randomNum = rand.Next(1, 3);

                    if (randomNum == 1 && i == 0)
                    {
                        // Console.Write("(" + randomNum + ")");
                        pickedNums.Add("1");

                        // Console.Write("1");

                    }
                    else if (randomNum == 2 && i == 0)
                    {
                        // Console.Write("(" + randomNum + ")");
                        pickedNums.Add("12");

                        //Console.Write("12");

                    }
                    else if (randomNum == 1 && i > 0)
                    {
                        // Console.Write("(" +randomNum + ")");
                        string temp = pickedNums[pickedNums.Count - 1].ToString();
                        string temp2 = "";
                        if (temp.Length == 1)
                        {
                            temp2 = temp[0].ToString();
                        }
                        else if (temp.Length == 2)
                        {
                            temp2 = temp[1].ToString();
                        }

                        switch (temp2)
                        {
                            case "1":
                                pickedNums.Add("2");

                                //Console.Write("2");
                                break;


                            case "2":
                                pickedNums.Add("3");

                                // Console.Write("3");
                                break;

                            case "3":
                                pickedNums.Add("4");

                                // Console.Write("4");
                                break;

                            case "4":
                                pickedNums.Add("5");

                                // Console.Write("5");
                                break;

                            case "5":
                                pickedNums.Add("6");

                                //  Console.Write("6");
                                break;

                            case "6":
                                pickedNums.Add("7");

                                // Console.Write("7");
                                break;


                            case "7":
                                pickedNums.Add("8");

                                // Console.Write("8");
                                break;

                            case "8":
                                pickedNums.Add("9");

                                //  Console.Write("9");

                                break;
                        }


                    }

                    else if (randomNum == 2 && i > 0)
                    {

                        // Console.Write("(" + randomNum + ")");
                        string temp = pickedNums[pickedNums.Count - 1].ToString();
                        string temp2 = "";
                        if (temp.Length == 1)
                        {
                            temp2 = temp[0].ToString();
                        }
                        else if (temp.Length == 2)
                        {
                            temp2 = temp[1].ToString();
                        }

                        switch (temp2)
                        {
                            case "2":
                                pickedNums.Add("34");
                                ++i;
                                //  Console.Write("34");
                                break;

                            case "3":

                                pickedNums.Add("45");
                                ++i;
                                //  Console.Write("45");
                                break;

                            case "4":
                                pickedNums.Add("56");
                                ++i;
                                //  Console.Write("56");
                                break;

                            case "5":
                                pickedNums.Add("67");
                                ++i;
                                //  Console.Write("67");
                                break;

                            case "6":
                                pickedNums.Add("78");
                                ++i;
                                // Console.Write("78");
                                break;

                            case "7":
                                pickedNums.Add("89");
                                ++i;
                                //  Console.Write("89");
                                break;

                            case "8":
                                pickedNums.Add("9");
                                ++i;
                                //  Console.Write("9");
                                break;
                        }
                    }

                }

                Console.WriteLine(String.Join(" ", pickedNums.ToArray()));
                //Console.WriteLine(pickedNums.Count);

                string[] array = pickedNums.ToArray(typeof(string)) as string[];
                
                int total = 0;
                int randNum;
                for (int i = 0; i < array.Length; i++)
                {
                    randNum = rand.Next(1, 3);
                    if (i == 0)
                    {
                        total = Convert.ToInt32(array[0]);
                    }
                    
                    else if(i > 1 && randNum == 1)
                    {
                        total += Convert.ToInt32(array[i]);
                    }
                    else if (i > 1 && randNum == 2)
                    {
                        total -= Convert.ToInt32(array[i]);
                    }

                }

               // Console.ReadLine();
               if(total == 100)
                {
                    Console.WriteLine(total);
                    break;
                }


            }
        }
    }
}

