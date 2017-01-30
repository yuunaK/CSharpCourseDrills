using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumerableDrillAnyMethod
{
    class PeoplewithHatsandGloves
    {
        class Hat
        {
            public string HColor { get; set; }
            public string HFabric { get; set; }

        }

        class Glove
        {
            public string GColor { get; set; }
            public string GFabric { get; set; }

        }

        class Person
        {
            public string Name { get; set; }
            public Hat[] Hats { get; set; }
            public Glove[] Gloves { get; set; }
        }

        public static dynamic AnyHatsandGloves()
        {
            List<Person> people = new List<Person>
            {
                new Person
                {
                    Name = "Ella",
                    Hats = new Hat[]
                    {
                        new Hat {HColor = "taupe", HFabric = "wool" }
                    },
                    Gloves = new Glove[]
                    {
                        new Glove {GColor = "taupe", GFabric = "wool" }
                    }
                },

                new Person
                {
                    Name = "Belle",
                    Hats = new Hat[]
                    {
                        new Hat {HColor = "pink", HFabric = "angora" }
                    },
                    Gloves = new Glove[]
                    {
                        new Glove {GColor = "pink", GFabric = "angora" }
                    }
                }
            };

            IEnumerable<string> names = from person in people
                                        where person.Hats.Any()
                                        select person.Name;


            
            bool yesORno = names.Any();
            int numberofPeople = names.Count();

            return names;
        }

        static void Main(string[] args)
        {
            
          
            

            System.Console.WriteLine("There {0} individuals with hats and gloves in the dataset.", 
              yesORno ? "are" : "are no"  );

            if (yesORno == true)
            {
                System.Console.WriteLine("These are the individuals with hats and gloves: \n{0}", Names );
            }

            System.Console.ReadKey(true);
        }
            

        
    }
}
     
