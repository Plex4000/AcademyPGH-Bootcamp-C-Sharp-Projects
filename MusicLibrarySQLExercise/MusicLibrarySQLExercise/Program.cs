using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicLibrarySQLExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Saturn\Documents\GitHub\AcademyPGH-C-Sharp-Projects\MusicLibrarySQLExercise\MusicLibrarySQLExercise\Music_Library.mdf;Integrated Security=True");

            int albumId = 0;
            while (true)
            {
                Console.WriteLine("Do you want to retreive, input information or exit? [R]etrieve, [I]nput, [E]xit ");
                var answer = ReadLine().ToLower();
                if(answer == "i")
                {
                    Console.Write("What is the name of the album? ");
                    string albumName = ReadLine();
                    Console.Write("What is the name of the artist? ");
                    string albumArist = ReadLine();


                    SqlCommand command = new SqlCommand($"INSERT INTO Albums VALUES ('{albumName}', '{albumArist}'); SELECT @@Identity AS ID", connection);
                    connection.Open();
                    SqlDataReader reader;
                    reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        //Should only ever have one row
                        reader.Read();
                       albumId = Convert.ToInt32(reader["ID"]);
                    }
                    connection.Close();

                    var answer2 = "y"; 
                    while (answer2 == "y")
                    {
                        Console.Write("What is the name of the song? ");
                        string songName = ReadLine();
                        Console.Write("What is the duration of the song? ");
                        string duration = ReadLine();

                        SqlCommand command2 = new SqlCommand($"INSERT INTO Songs VALUES ('{songName}', '{duration}', '{albumId}')", connection);
                        connection.Open();
                        command2.ExecuteNonQuery();
                        connection.Close();

                        Console.Write("Do you want to add another song? [y]es or [n]o ");
                        answer2 = ReadLine().ToLower();
                    }
                        
                }

                if(answer == "r")
                {
                    Console.WriteLine("Do you want to retrieve all albums [A]lbums, all [S]ongs or display all songs from only one albumb [O]ne");

                    var selection = ReadLine().ToLower();  

                    if(selection == "a")
                    {
                        SqlCommand command = new SqlCommand("SELECT * from Albums", connection);
                        connection.Open();
                        SqlDataReader dataReader = command.ExecuteReader();

                        if (dataReader.HasRows)
                        {
                            while (dataReader.Read())
                            {
                           
                                int id = Convert.ToInt32(dataReader["Id"]);
                                string AlbumbName = dataReader["AlbumName"].ToString();
                                string ArtistName = dataReader["ArtistName"].ToString();
                                
                                Console.WriteLine($"{id}, {AlbumbName}, {ArtistName}");
                            }
                        }
                        dataReader.Close();
                        connection.Close();
                    }

                    else if (selection == "s")
                    {
                        SqlCommand command = new SqlCommand("SELECT * from Songs", connection);
                        connection.Open();
                        SqlDataReader dataReader = command.ExecuteReader();

                        if (dataReader.HasRows)
                        {
                            while (dataReader.Read())
                            {

                                int id = Convert.ToInt32(dataReader["Id"]);
                                int Albumid = Convert.ToInt32(dataReader["AlbumId"]);
                                string SongName = dataReader["SongName"].ToString();
                                string SongDuration = dataReader["SongDuration"].ToString();

                                Console.WriteLine($"{SongName}, {SongDuration}");
                            }
                        }
                        dataReader.Close();
                        connection.Close();
                    }

                    else if (selection == "o")
                    {
                        Console.WriteLine("Please enter the id of the album");
                        var aId = ReadLine();
                        
                        SqlCommand command = new SqlCommand($"select * from Songs inner join Albums On Albums.id = Songs.AlbumId Where Albums.Id = {aId}", connection);
                        connection.Open();
                        SqlDataReader dataReader = command.ExecuteReader();

                        if (dataReader.HasRows)
                        {
                            while (dataReader.Read())
                            {

                                int id = Convert.ToInt32(dataReader["Id"]);
                                int Albumid = Convert.ToInt32(dataReader["AlbumId"]);
                                string SongName = dataReader["SongName"].ToString();
                                string SongDuration = dataReader["SongDuration"].ToString();

                                Console.WriteLine($"{SongName}, {SongDuration}");
                            }
                        }
                        dataReader.Close();
                        connection.Close();
                    }




                }

                else if (answer == "e")
                {
                    break;
                }

            }

        }

        public static string ReadLine()
        {
            return Console.ReadLine().Replace("'", "''");
        }
    }
}
