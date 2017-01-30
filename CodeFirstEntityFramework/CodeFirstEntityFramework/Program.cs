// Title: C Sharp Code First Program to Create 
// SQL Database and Print Query Results to Console.

// Course: C# Course
// School: The Tech Academy (Portland, OR)

// Resources: 
//  Video: Entity Framework 5.0 - Code First, No Database - Part 1 of 2
//  Author: Fabio Scopel (https://www.youtube.com/watch?v=HbDOhCjjxSY)
//  
//  Video: Entity Framework: Code First to Existing Database (EF 6.1 Onwards)
//  Author: Rowan Miller (https://channel9.msdn.com/blogs/ef/code-first-to-existing-database-ef6-1-onwards-)
//
//  Article: Entity Framework Code First to an Existing Database
//  Author: Microsoft Developer Network (https://msdn.microsoft.com/en-us/library/jj200620(v=vs.113).aspx)


// Project Overview:
// This project does several things:
//  1. create a database in SQL Server.
//  2. create two tables and add records to them.
//  3. queries the students table in the Students Dataabse
//      and prints student names to console.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace EntityFrameworkCodeFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new StudentContext())
            {
                // create student objects to add to Students Table
                var student1 = new Student() { StudentName = "Penelope" };
                var student2 = new Student() { StudentName = "Erin" };
                var student3 = new Student() { StudentName = "Jane" };

                // create subject objects to add to Subjects Table
                var subject1 = new Subject() { SubjectName = "Mathematics" };
                var subject2 = new Subject() { SubjectName = "Science" };
                var subject3 = new Subject() { SubjectName = "Art History" };

                // Associate a subject to a student using List StudentSubjects 
                student1.StudentSubjects.Add(subject1);
                student2.StudentSubjects.Add(subject2);
                student3.StudentSubjects.Add(subject3);

                // Add student objects to Students table
                db.Students.Add(student1);
                db.Students.Add(student2);
                db.Students.Add(student3);

                db.SaveChanges();


                // Queries the table and prints names of students to Console.
                var query = from b in db.Students
                            orderby b.StudentName
                            select b;

                Console.WriteLine("Students in Database");
                foreach (var i in query)
                {
                    Console.WriteLine(i.StudentName);
                }

                Console.WriteLine("Press any key to exit....");
                Console.ReadKey(true);

            }
        }
    }

    public class Student
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }

        public virtual List<Subject> StudentSubjects { get; set; }

        public Student()
        {
            this.StudentSubjects = new List<Subject>();
        }
    }

    public class Subject
    {
        public int SubjectId { get; set; }
        public string SubjectName { get; set; }

        public virtual Student Student { get; set; }
    }

    class StudentContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Subject> Subjects { get; set; }
    }
}
