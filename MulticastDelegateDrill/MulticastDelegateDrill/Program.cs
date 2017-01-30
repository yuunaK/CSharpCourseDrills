using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MulticastDelegateDrill
{
    delegate void Greeting(string s);

    class Program
    {
        static void Christmas(string s)
        {
            System.Console.WriteLine("{0}, Merry Christmas!", s);
        }

        static void NewYear(string s)
        {
            System.Console.WriteLine("{0},Happy New Year!!!", s); 
        }

        static void Main(string[] args)
        {
            Greeting xmas, newyr, multicast_bothGreetings, multiMinusnweyr;

            xmas = Christmas;
            newyr = NewYear;
            multicast_bothGreetings = xmas - newyr;
            multiMinusnweyr = xmas = newyr;

            System.Console.WriteLine("Invoking delegate xmas: ");
            xmas("A");
            System.Console.WriteLine("Invoking delegate newyr: ");
            newyr("B");
            System.Console.WriteLine("Invoking delegate multicast_bothGreetings");
            multicast_bothGreetings("C");
            System.Console.WriteLine("Invoking multiMinusnewyr:  ");
            multiMinusnweyr("D");

            System.Console.ReadKey(true);



        }
    }
}
