using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSQLExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            bool male;

            Console.Write("Please enter your first name: ");
            var fName = Console.ReadLine();

            Console.Write("Please enter your last name: ");
            var lName = Console.ReadLine();

            Console.Write("Please enter your city: ");
            var city = Console.ReadLine();

            Console.Write("Please enter your state: ");
            var state = Console.ReadLine();

            Console.Write("Please enter your birth date in this format: mm/dd/yyyy ");
            var birthDate = Console.ReadLine();

            var date = Convert.ToDateTime(birthDate);

            Console.Write("Are you Male? yes or no ");
            var isMale = Console.ReadLine();

            if (isMale == "yes")
            {
                male = true;
            }
            else
            {
                male = false;
            }

            SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Saturn\Documents\GitHub\AcademyPGH-C-Sharp-Projects\AddressBookSQLExercise\AddressBookSQLExercise\Address_Book.mdf;Integrated Security=True");

            connection.Open();
            string sql = $"INSERT INTO AddressBook VALUES ('{fName}', '{lName}', '{city}', '{state}','{date}', '{male}')";
            SqlCommand command = new SqlCommand(sql, connection);

            command.ExecuteNonQuery();

            connection.Close();

            Console.WriteLine("Which city do you want to search?");
            var township = Console.ReadLine();
            string sql2 = $"Select * from AddressBook Where City = '{township}'";
            SqlCommand command2 = new SqlCommand(sql2, connection);

            connection.Open();
            SqlDataReader dataReader = command2.ExecuteReader();

            if (dataReader.HasRows)
            {
                while (dataReader.Read())
                {
                    string firstName = dataReader["FirstName"].ToString();
                    int id = Convert.ToInt32(dataReader["Id"]);
                    string lastName = dataReader["LastName"].ToString();
                    string town = dataReader["City"].ToString();
                    string stateOfResidence = dataReader["State"].ToString();
                    Console.WriteLine($"Id: {id}, First Name: {firstName}, Last Name: {lastName}, City: {town}, State: {stateOfResidence}");
                }
            }
            else
            {
                Console.WriteLine("There are no users in this city!");
            }
            dataReader.Close();

            connection.Close();



        }
    }
}
