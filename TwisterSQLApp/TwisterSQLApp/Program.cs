using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwisterSQLApp
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Saturn\Documents\GitHub\AcademyPGH-C-Sharp-Projects\TwisterSQLApp\TwisterSQLApp\Twister_Database.mdf;Integrated Security=True");

            Console.Write("Would you like to [L]ogin or [C]reate a new account? ");
            var selection = Console.ReadLine().ToLower();

            string userName = "";
            Console.WriteLine("Please enter a username.");

            userName = Console.ReadLine();

            int userId = 0;

            if (selection == "c")
            {

                SqlCommand command = new SqlCommand($"INSERT INTO Users VALUES ('{userName}'); SELECT @@Identity AS ID", connection);
                connection.Open();
                SqlDataReader reader;
                reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    //Should only ever have one row
                    reader.Read();
                    userId = Convert.ToInt32(reader["Id"]);
                }
                connection.Close();
               

                Console.Write("Would you like to add a tweet? [Y]es or [N]o? ");
                var isTweetSelection = Console.ReadLine().ToLower();

                while (isTweetSelection == "y")
                {
                    AddTweet(connection, userId);

                    Console.Write("Would you like to add a tweet? [Y]es or [N]o? ");
                    isTweetSelection = Console.ReadLine().ToLower();
                }

            }
            else if (selection == "l")
            {
                SqlCommand command = new SqlCommand($"select * from Tweets inner join Users On Tweets.UserId = Users.Id Where UserName = '{userName}'", connection);
                connection.Open();
                SqlDataReader dataReader = command.ExecuteReader();

                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {

                        int id = Convert.ToInt32(dataReader["Id"]);
                        userId = Convert.ToInt32(dataReader["UserId"]);
                        string tweet = dataReader["Tweet"].ToString();
                        string tweetDateTime = dataReader["TweetDateTime"].ToString();

                        Console.WriteLine($"{id}, {userId}, {tweet}, {tweetDateTime}");
                    }
                }
                dataReader.Close();
                connection.Close();
            }




        }

        public static void AddTweet(SqlConnection connection, int userId)
        {
            Console.WriteLine("Please enter your tweet.");
            var tweet = Console.ReadLine();
            DateTime time = DateTime.Now;              // Use current time
            string format = "yyyy-MM-dd HH:mm:ss";    // modify the format depending upon input required in the column in database 

            SqlCommand command2 = new SqlCommand($"INSERT INTO Tweets VALUES ('{tweet}', '{time.ToString(format)}', '{userId}')", connection);
            connection.Open();
            command2.ExecuteNonQuery();
            connection.Close();
        }
    }
}
