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
            //var count = 0;
            //int id = 0;
            //string[] messages = new string[20];
            string message;
            int messageID;

            SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Saturn\Documents\GitHub\AcademyPGH-C-Sharp-Projects\MessageStorageRetrieval\MessageStorageRetrieval\messaging_database.mdf;Integrated Security=True");


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


                        Console.Write("What is your message? ");
                        message = Console.ReadLine();

                        //connection.Open();
                        //string sql = "Select top 1 id from Messages Order By id Desc";
                        //SqlCommand command = new SqlCommand(sql, connection);
                        //int id = command.ExecuteNonQuery();
                        //id++;
                        //Console.WriteLine(id);
                        //connection.Close();

                        connection.Open();
                        string sql2 = $"INSERT INTO Messages (Message) VALUES ('{message}'); SELECT @@Identity AS ID";
                        SqlCommand command2 = new SqlCommand(sql2, connection);

                    SqlDataReader reader;
                    reader = command2.ExecuteReader();
                    if (reader.HasRows)
                    {
                        //Should only ever have one row
                        reader.Read();
                        Console.WriteLine("Your message ID is: " + reader["ID"]);
                    }
                    //command2.ExecuteNonQuery();
                    connection.Close();

                   
                    

                    connection.Close();
                    //  messages[count] = message;
                    //count++;
                }



                if (input == "r")
                {
                    Console.Write("Which message would you like: enter the id of the message?");
                    messageID = Convert.ToInt32(Console.ReadLine());

                    //string sql = "Select top 1 id from Messages Order By id Desc";

                    
                    string sql = $"Select Message From Messages Where id = '{messageID}'";
                    SqlCommand command = new SqlCommand(sql, connection);
                    connection.Open();
                    SqlDataReader dataReader = command.ExecuteReader();

                    if (dataReader.HasRows)
                    {
                        while (dataReader.Read())
                        {
                            Console.WriteLine(dataReader["Message"]);
                        }
                    }
                    dataReader.Close();

                    connection.Close();

                }

            }

            }
        }
}
