using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageStorageRetrieval
{
    class Program
    {
        static void Main(string[] args)
        {
            var count = 0;
            string[] messages = new string[20];
            string message;
            int messageID;

            while (true)
            {
                    Console.WriteLine("Would you like to [S]ave or [R]etrieve a message?");
                    var input = Console.ReadLine().ToLower();

                    while (input != "s" && input != "r")
                    {
                        Console.Write("please enter only s or r: ");
                        input = Console.ReadLine();
                    }
                    if (input == "s")
                    {
                        
                        if (count < 20)
                        {
                            
                            
                            Console.Write("What is your message? ");
                            message = Console.ReadLine();
                            messages[count] = message;
                            count++;
                        }
                        else
                        {
                        Console.WriteLine("You can only add 20 messages!");
                        } 
                        
                    }
                    if (input == "r")
                    {
                        Console.Write("Which message would you like?");
                        messageID = Convert.ToInt32(Console.ReadLine());
                        if (messages[messageID] == null)
                        {
                        Console.WriteLine("There is no message to retrieve");
                        }
                    else
                    {
                        Console.WriteLine("Your message is: " + messages[messageID]);
                    }
                       
                    }

                }

            }
        }
}
