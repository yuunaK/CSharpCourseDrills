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
            using (var db = new Model1())
            {
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
