// Title: Entity Framework 5.0 - Code First, No Database
// Author: Fabio Scopel

// Program Overview: Create a database in Microsoft's 
// SQL Server Management Studio by writing C# console
// application in Visual Studio.

// We will create a many-to-many relationship between
// the entities Student and Subject.

// We will create a database in SQL Server called Students Database.
// We will create two tables in the Students Database:
// Table 1: Students
// Table 2: Subjects

// This program will create the database and tables in the 
// Code First paradigm - we will write the code first in order
// to have SQL Server create the database and table.

// Below are namespaces used in this very simple application.
// The namespace System.Data.Entity is especially 
// important to include because it allows us to 
// write a class which can inherit from Db.Context.

using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace CodeFirst
{
    class Program
    {
        static void Main(string[] args)
        {

            // The keyword 'using' means: using the database, db,
            // we will populate two tables with the values entered.
            using (var db = new StudentContext())
            {
                // With this statement, we are adding a student to the student table.
                var student1 = new Student() { StudentName = "Yuuna Kaparti" };
                var student2 = new Student() { StudentName = "Bradley Proctor" };
                var student3 = new Student() { StudentName = "Nan Kempner" };


                // We are creating Subject objects.
                var mathematics= new Subject() { SubjectName = "Mathematics" };
                var science = new Subject() { SubjectName = "Science" };
                var artHistory = new Subject() { SubjectName = "Art History" };

                // We are associating with code, the classes in which the student 
                // is enrolled.
                student1.Subjects.Add(mathematics);
                student1.Subjects.Add(science);
                student2.Subjects.Add(artHistory);
                student2.Subjects.Add(science);
                student3.Subjects.Add(mathematics);
                student3.Subjects.Add(artHistory);


                // We are adding student to the Students table.

                db.Students.Add(student1);
                db.Students.Add(student2);
                db.Students.Add(student3);


                // We are adding subjects to the Subjects table.
                db.Subjects.Add(mathematics);
                db.Subjects.Add(science);
                db.Subjects.Add(artHistory);

                db.SaveChanges();
            }

            

        }
    }
// The Student class will create Student objects which will 
// fill the Students table.
// Each student will have two properties: StudentId and Name.
    public class Student
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }

        public virtual List<Subject> Subjects { get; set; }

        public Student()
        {
            this.Subjects = new List<Subject>();
        }

    }
 
    public class Subject
    {
        public int SubjectId { get; set; }
        public string  SubjectName { get; set; }

        // This virtual method is called Student and returns a Student object.
        public virtual Student Student { get; set; }
    }



    // StudentContext is a database.  It inherits from 
    // DbContext. StudentContext database has two tables: Students, Subjects
    class StudentContext : DbContext
    {

        public DbSet<Student> Students { get; set; }
        public DbSet<Subject> Subjects { get; set; }
 
    }


}
