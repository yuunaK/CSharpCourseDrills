using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullableTypesDrill
{
    class NullableTypes
    {
        static void Main(string[] args)
        {
            bool? value = null;

            if(value.HasValue)
            {
                System.Console.WriteLine("bool = " + value.Value);
            }
            else
            {
                System.Console.WriteLine("bool = null");
            }

            int? x = null;
            System.Console.WriteLine("The value of x is null 
                {0}. ", x);

            int y = x ?? -1;
            System.Console.WriteLine("The value of y is {0}. ", y);

            x = 3;
            System.Console.WriteLine("The value of x is {0}. ", x);

            y = x ?? -1;
            System.Console.WriteLine("The value of y is {0}. ", y);


            System.Console.ReadKey(true);
        }
    }
}
