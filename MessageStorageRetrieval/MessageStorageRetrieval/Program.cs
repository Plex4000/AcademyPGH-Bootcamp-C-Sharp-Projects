using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
            //int id = 0;
            //string[] messages = new string[20];
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
                    SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Saturn\Documents\GitHub\AcademyPGH-C-Sharp-Projects\MessageStorageRetrieval\MessageStorageRetrieval\messaging_database.mdf;Integrated Security=True");
                    

                    


                    if (count < 20)
                        {
                      

                        Console.Write("What is your message? ");
                        message = Console.ReadLine();

                        connection.Open();
                        string sql = "Select top 1 id from Messages Order By id Desc";
                        SqlCommand command = new SqlCommand(sql, connection);
                        int id = command.ExecuteNonQuery();
                        id++;
                        Console.WriteLine(id);
                        connection.Close();

                        connection.Open();
                        string sql2 = $"INSERT INTO Messages (id, Message) VALUES ({id}, '{message}')";
                        SqlCommand command2 = new SqlCommand(sql2, connection);
                        command2.ExecuteNonQuery();
                        connection.Close();
                        //  messages[count] = message;
                        count++;
                        }
                        else
                        {
                        Console.WriteLine("You can only add 20 messages!");
                        } 
                        
                    }
                    //if (input == "r")
                    //{
                    //    Console.Write("Which message would you like?");
                    //    messageID = Convert.ToInt32(Console.ReadLine());
                    //    if (messages[messageID] == null)
                    //    {
                    //    Console.WriteLine("There is no message to retrieve");
                    //    }
                    //else
                    //{
                    //    Console.WriteLine("Your message is: " + messages[messageID]);
                    //}
                       
                    //}

                }

            }
        }
}
