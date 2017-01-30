// Title: C# Program Using ADO.NET to Query a Database and Print to the Console
// Course: C# Course
// School: The Tech Academy, Portland OR
// Prepared by: Yuuna Kaparti
// Resources:
//  a. Video: "Entity Framework: Code First to Existing Database 
//      (EF6.1 Onwards) by Rowan Miller 
//      (https://channel9.msdn.com/blogs/ef/code-first-to-existing-database-ef6-1-onwards-)
//  b. Tutorial: Entity Framework Code First to an Existing Database
//      (https://msdn.microsoft.com/en-us/library/j/200620(v=vs.113.aspx)


// Project Overview
//
// This program will retrieve information from an existing database and 
// print the information to the console.  

// In order to do this, we use the ADO.NET Entity Data Model template.
// Using this template creates an application which modifies the App.Config 
// file so that the Connection Strings tags will have the correct information.
// Other things this template does automatically for the developer is to create
// a database object which is a replica of the original database.  Using this 
// database object, we can query tables from the database.

// For this exercise, I want to print the names of students in the database.






using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFinalProject
{
    class Program
    {
        static void Main(string[] args)
        {
            // Class Model1 inherits from DbContext.
            // db is an instance/object of class(type) Model1
            // All this is managed by ADO.NET. If we don't use
            // ADO.NET we would have to write the code. 
            // This program takes advantage of this and focuses
            // on C# code to query and run through an array.
            using (var db = new Model1()) 
            {
                // the variable 'query' is an array and stores
                // all the names of students returned by the query.

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
}
