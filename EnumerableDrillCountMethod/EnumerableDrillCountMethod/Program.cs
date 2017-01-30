using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumerableDrillCountMethod
{
    class Program
    {
        public class Flowers
        {
            //Create a string array to store the names of flowers.

            public static string[] flowers = { "violet", "primrose", "ranunculus", "gerbera", "peony", "tulip" };

            //Create a method to count the number of flowers in the flowers array.
            public static int numberOfFlowers()
            {
                int nFlowers = Program.Flowers.flowers.Count();
                return nFlowers;
            }

            //Create a method to search the array for user specified flower.
            public static bool findFlowers(string x)
            {
                bool searchFlower;
                searchFlower = flowers.Contains(x);
                return searchFlower;


            }



        }

       
        

        static void Main(string[] args)
        {

            //Create a variable to store number of flowers in array.
            //When using an Enumerable method, there is no need to create an instance
            //of the class before implementing a method in the class.
            //It is sufficient to create a variable to store the return value for
            //the method and to directly access the method using the name of the class
            //and the name of the method.
            int x = Flowers.numberOfFlowers();
            
            System.Console.WriteLine("There are {0} flowers in the array.", x);

            System.Console.WriteLine("Search the dataset to see if your flower is in the set.");
            System.Console.Write("Please enter a flower search term. ");
            string flowerSearchTerm = System.Console.ReadLine();

            bool y = Flowers.findFlowers(flowerSearchTerm);

            System.Console.WriteLine("Your flower {0} in the dataset. ", y ? "is" : "is not");

            System.Console.ReadKey(true);
        }

    }
}
