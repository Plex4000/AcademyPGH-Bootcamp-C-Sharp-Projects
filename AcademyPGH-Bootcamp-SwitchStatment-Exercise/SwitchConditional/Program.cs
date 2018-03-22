using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchConditional
{
    class Program
    {
        static void Main(string[] args)
        {

            //while (true)
            //{
            //    Console.Write("What month were you born in?: ");

            //    string birthMonth = Console.ReadLine();

            //    switch (birthMonth)
            //    {
            //        case "september":
            //        case "october":
            //        case "november":
            //            Console.WriteLine("You were born in the Fall season.");
            //            break;
            //        case "december":
            //        case "january":
            //        case "february":
            //            Console.WriteLine("You were born in the Winter season.");
            //            break;
            //        case "march":
            //        case "april":
            //        case "may":
            //            Console.WriteLine("You were born in the Spring season.");
            //            break;
            //        case "june":
            //        case "july":
            //        case "august":
            //            Console.WriteLine("You were born in the Summer season.");
            //            break;
            //        default:
            //            Console.WriteLine("Your input was invalid.");
            //            break;

            //    }
            //}


            //int count = 1;
            //while (count <= 10)
            //{
            //    Console.Write("What month were you born in?: ");

            //    string birthMonth = Console.ReadLine();

            //    switch (birthMonth)
            //    {
            //        case "september":
            //        case "october":
            //        case "november":
            //            Console.WriteLine("You were born in the Fall season.");
            //            break;
            //        case "december":
            //        case "january":
            //        case "february":
            //            Console.WriteLine("You were born in the Winter season.");
            //            break;
            //        case "march":
            //        case "april":
            //        case "may":
            //            Console.WriteLine("You were born in the Spring season.");
            //            break;
            //        case "june":
            //        case "july":
            //        case "august":
            //            Console.WriteLine("You were born in the Summer season.");
            //            break;
            //        default:
            //            Console.WriteLine("Your input was invalid.");
            //            break;

            //    }
            //    Console.WriteLine($"The loop is in its {count}th iteration.");
            //    count++;
            //}

            string answer = "yes";
            while (answer == "yes")
            {
                Console.Write("What month were you born in?: ");

                string birthMonth = Console.ReadLine();

                switch (birthMonth)
                {
                    case "september":
                    case "october":
                    case "november":
                        Console.WriteLine("You were born in the Fall season.");
                        break;
                    case "december":
                    case "january":
                    case "february":
                        Console.WriteLine("You were born in the Winter season.");
                        break;
                    case "march":
                    case "april":
                    case "may":
                        Console.WriteLine("You were born in the Spring season.");
                        break;
                    case "june":
                    case "july":
                    case "august":
                        Console.WriteLine("You were born in the Summer season.");
                        break;
                    default:
                        Console.WriteLine("Your input was invalid.");
                        break;
                }

                Console.Write("Do you want to continue with another iteration? yes or no:");
                answer = Console.ReadLine().ToLower();

                while (answer != "yes" && answer != "no")
                {
                    Console.WriteLine("Please enter either yes or no.");
                    Console.Write("Do you want to continue with another iteration?");
                    answer = Console.ReadLine().ToLower();

                }
                
            }

           bool isInvalid;

            do {
                isInvalid = false;

                Console.Write("What month were you born in?: ");

                string birthMonth = Console.ReadLine().ToLower();

                switch (birthMonth)
                {
                    case "september":
                    case "october":
                    case "november":
                        Console.WriteLine("You were born during the fall season.");
                        break;
                    case "december":
                    case "january":
                    case "february":
                        Console.WriteLine("You were born during the winter season.");
                       
                        break;
                    case "march":
                    case "april":
                    case "may":
                        Console.WriteLine("You were born during the spring season.");
                        
                        break;
                    case "june":
                    case "july":
                    case "august":
                        Console.WriteLine("You were born during the summer season.");
                        
                        break;
                    default:
                        isInvalid = true;
                        Console.WriteLine("Please enter a valid input.");
                        break;

                }
            } while (isInvalid);
            
        }
    }
}
