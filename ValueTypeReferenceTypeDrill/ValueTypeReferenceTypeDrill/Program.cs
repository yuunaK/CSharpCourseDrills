using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueTypeReferenceTypeDrill
{
    class Program
    {
        static void Main(string[] args)
        {
            // Value Types
            int x;
            int y;
            x = 1;
            y = 1;
            y = x;

            System.Console.WriteLine("x = {0}",  x);
            System.Console.WriteLine("y = {0}", y);
            y = 2;
            System.Console.WriteLine("y = {0}", y);
            System.Console.WriteLine("x = {0}", x);

            // Reference Types
            dynamic e;
            dynamic d;
            e = 1;
            d = 3;
            e = d;
            System.Console.WriteLine("e = {0}", e);
            System.Console.WriteLine("d = {0}", d);
            d = 2;
            System.Console.WriteLine("d = {0}",  d);
            System.Console.WriteLine("e = {0}", e);
            

          
            System.Console.ReadKey(true);








        }
    }
}
