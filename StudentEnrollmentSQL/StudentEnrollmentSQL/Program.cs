using System;
using System.Data.SqlClient;


namespace StudentEnrollmentSQL
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Saturn\Documents\GitHub\AcademyPGH-C-Sharp-Projects\StudentEnrollmentSQL\StudentEnrollmentSQL\Student_Enrollment.mdf;Integrated Security=True");

            connection.Open();
            var input = "";

            while (input != "q")
            {
                Console.WriteLine("[E]nroll students in courses");
                Console.WriteLine("[R]emove students from courses");
                Console.WriteLine("View [S]tudents details");
                Console.WriteLine("View [C]lass details");
                Console.WriteLine("[Q]uit");

                input = Console.ReadLine().ToLower();

                switch (input)
                {
                    case "e":
                        Console.WriteLine();
                        Console.Write("please enter a student ID: ");
                        var studentId = Convert.ToInt32(Console.ReadLine());
                        Console.Write("please enter a course ID: ");
                        var courseId = Convert.ToInt32(Console.ReadLine());
                        SqlCommand command = new SqlCommand();
                        command.Connection = connection;
                        command.CommandText = $"Insert into StudentCourses Values ('{studentId}', '{courseId}')";
                        command.ExecuteNonQuery();
                        break;
                    case "r":
                        Console.WriteLine();
                        Console.Write("please enter a student ID: ");
                        studentId = Convert.ToInt32(Console.ReadLine());
                        Console.Write("please enter a course ID: ");
                        courseId = Convert.ToInt32(Console.ReadLine());
                        SqlCommand command2 = new SqlCommand();
                        command2.Connection = connection;
                        command2.CommandText = $"DELETE FROM StudentCourses WHERE StudentId = '{studentId}' AND CourseId = '{courseId}'";
                        command2.ExecuteNonQuery();
                        break;
                    case "s":
                        Console.WriteLine();
                        SqlCommand command3 = new SqlCommand();
                        command3.Connection = connection;
                        command3.CommandText = $@"SELECT Students.FirstName, Students.LastName, Count(CourseId) as TotalCourses
                            FROM Students
                            INNER JOIN StudentCourses
                            ON Students.Id = StudentCourses.StudentId
                            Group By Students.FirstName, Students.LastName;";
                        SqlDataReader reader = command3.ExecuteReader();
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                var firstname = reader["FirstName"].ToString();
                                var lastName = reader["LastName"].ToString();
                                var courseCount = Convert.ToInt32(reader["TotalCourses"]);
                                Console.WriteLine($"{firstname} {lastName}, is enrolled in {courseCount} courses.");

                            }
                            Console.WriteLine();
                        }
                        reader.Close();
                        break;
                    case "c":
                        Console.WriteLine();
                        Console.Write("Please enter a course ID: ");
                        var courseID = Console.ReadLine();
                        Console.WriteLine();
                        SqlCommand command4 = new SqlCommand();
                        command4.Connection = connection;
                        command4.CommandText = $"Select * From Courses Where Id = '{courseID}'";
                        SqlDataReader reader2 = command4.ExecuteReader();
                        if (reader2.HasRows)
                        {
                            while (reader2.Read())
                            {
                                var courseName = reader2["CourseName"].ToString();
                                var classRoom = reader2["Classroom"].ToString();
                                var startTime = reader2["StartTime"].ToString();
                                var endTime = reader2["EndTime"].ToString();
                                Console.WriteLine($"{courseName}, is located at Classroom {classRoom}.The course is from {startTime} to {endTime}");
                            }
                        }
                        reader2.Close();

                        SqlCommand command5 = new SqlCommand();
                        command5.Connection = connection;
                        command5.CommandText = $"Select count(StudentId) as TotalStudents From StudentCourses Where CourseId = '{courseID}'";
                        var totalStudents = command5.ExecuteScalar().ToString();

                        Console.WriteLine($"There are currently {totalStudents} student(s) enrolled in the course:");


                        SqlCommand command6 = new SqlCommand();
                        command6.Connection = connection;
                        command6.CommandText = $@"select students.FirstName, students.LastName
                                                from Students
                                                inner join StudentCourses
                                                on students.Id = StudentCourses.StudentId
                                                where CourseId = {courseID}";

                        SqlDataReader reader3 = command6.ExecuteReader();
                        if (reader3.HasRows)
                        {
                            while (reader3.Read())
                            {
                                var firstName = reader3["FirstName"].ToString();
                                var lastName = reader3["LastName"].ToString();
                                
                                Console.WriteLine($"{firstName} {lastName}");
                            }
                        }
                        Console.WriteLine();
                        reader3.Close();
                        break;

                    default:
                        break;
                }
            }
            
            connection.Close();
            Console.ReadLine();

        }
        
       
    }
}
