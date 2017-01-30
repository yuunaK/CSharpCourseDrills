using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiersDrill
{
    class Program
    {
        class AccessModifiers
        {
            public string textString = "Hello, World!";
            internal int x = 3;
            protected internal int y = 2;
            protected static bool trueValue = true;
            public bool TFvalue = false;
            public bool tfValue = false || trueValue;
            private static float w = 4.29f;
            public static float q = 2.3f;
            public float d = w + q;
            
        }
        static void Main(string[] args)
        {
            AccessModifiers test = new AccessModifiers();
            System.Console.WriteLine(test.textString);
            System.Console.WriteLine(test.x);
            System.Console.WriteLine(test.y);
            System.Console.WriteLine(test.tfValue);
            System.Console.WriteLine(test.d);
            System.Console.ReadKey(true);
        }
    }
}
