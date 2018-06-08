SELECT Students.FirstName, Students.LastName, Count(StudentId) as TotalStudents
FROM Students
INNER JOIN StudentCourses
ON Courses.Id = StudentCourses.CourseId
Where CourseId = 1 
Group By Students.FirstName, Students.LastName;

Select count(StudentId) as TotalStudents From StudentCourses Where CourseId = 1 

select students.FirstName, students.LastName
from Students
inner join StudentCourses
on students.Id = StudentCourses.StudentId
where CourseId = 1

