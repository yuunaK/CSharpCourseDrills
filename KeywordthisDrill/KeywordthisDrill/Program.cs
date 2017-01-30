using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeywordthisDrill
{
    class LinearEquation
    {
        class linearEquation
        {
            // declare two int variables that will be used in the program.
            public int x, y, z, c;

            // default constructor
            public linearEquation()
            {
                x = 0;
                y = 0;
                z = 0;
                c = 0;
            }

            //instance constructor with three parameters/inputs
            public linearEquation(int x, int y, int c)
            {
                this.x = x;
                this.y = y;
                this.c = c;
            }

            //method to solve linear equations given user input
            public int solveLinearEquation(int x, int y, int c)
            {
                // Two ways to print values to screen: one using 'this' keyword and another using the arguments that are passed.
                System.Console.WriteLine("The values are {0}, {1}, {2}", this.x, this.y, this.c);
                System.Console.WriteLine("The values you have provided are \nfor x is {0} \nfor y is {1}, \nfor c is {2}.", x, y, c);
                z = (x * y) + c;
                return z;
            }

        }


        static void Main(string[] args)
        {
            // Ask user for input and store user input into string variables.
            System.Console.WriteLine("I will help you solve a simple linear equation: xy + c = z");
            System.Console.WriteLine("Please provide values for x, y, and c. ");
            System.Console.Write("Please enter a value for x: ");
            string x = System.Console.ReadLine();
            System.Console.Write("Please enter a value for y: ");
            string y = System.Console.ReadLine();
            System.Console.Write("Please enter a value for c: ");
            string c = System.Console.ReadLine();

            //Convert user input strings into integers.
            int Ix;
            int.TryParse(x, out Ix);
            int Iy;
            int.TryParse(y, out Iy);
            int Ic;
            int.TryParse(c, out Ic);

            // Create an instance of class linearEquation and print to scree values provided by user.
            linearEquation eq1 = new linearEquation(Ix, Iy, Ic);
           

            //Use linear equation object to call the solveLinearEquation method.
            int sol = eq1.solveLinearEquation(Ix, Iy, Ic);

            //Print the linear equation with values provided.
            System.Console.WriteLine("The solution to the linear equation ( {0} * {1} ) + {2} is {3}.", x, y, c, sol);

            //Keep console window open until user wishes to exit
            System.Console.WriteLine("Please hit any key to exit. ");
            System.Console.ReadKey(true);



        


           

        }
    }
}
