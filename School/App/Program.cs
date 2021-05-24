using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            var database = new SchoolContext();

            Console.WriteLine("List of Students");
            database.Students.ToList().ForEach(student => 
                Console.WriteLine($"Student Name: {student.FirstName} {student.LastName}")
                );

            Console.WriteLine("\nList of Barry Allens Grades");
            //using eager loading
            database.Students.Include(student => student.Grades).Where(student => student.FirstName == "Barry")
            .FirstOrDefault().Grades.ToList().ForEach(grade => 
                Console.WriteLine($"Course Name: {grade.CourseName} - Grade: {grade.Value} ")
                );

            Console.Write("\nBarry Allens Avg Grade : ");
            var gpa = database.Students.Include(student => student.Grades).Where(student => student.FirstName == "Barry")
            .FirstOrDefault().Grades.Select(grade => grade.Value).Average();
            Console.WriteLine(gpa);

            // Console.Write("\nFind Student With Highest Avg Grade");
            // var max_gpa = database.Students.Include(student => student.Grades)
            // .Select(students => new {name = students.FirstName, gpa = students.Grades.GroupBy(test => test.StudentId).Average()});
            // Console.WriteLine(max_gpa);

            Console.WriteLine("\nFind Students With No Classes");
            database.Students.Include(student => student.Grades).Where(student => student.Grades.Count == 0).ToList().ForEach(student =>
                Console.WriteLine($"Student Name: {student.FirstName} {student.LastName}")
            );
        }
    }
}

// Show a list of all the students
// Given a student's name, show their grades
// Given a student's name find their average grade among all their courses
// Find the student with the highest average grade
// Find the student that took the most number of courses
// Find a student that didn't take any courses
// Count the number of Freshmen
// Find the average grade for all Sophomores