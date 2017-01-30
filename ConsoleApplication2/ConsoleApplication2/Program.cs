using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class OverrideProgram
    {
        static void Main()
        {
            var MyFlower1 = new Flower2();
            var MyFlower2 = new Flower2();
            var MyGarland = MyFlower1.Garland("pink_rose", "white_rose", "pink_rose");
            System.Console.WriteLine(MyGarland);
            var MyWreath = MyFlower2.Wreath("eglantine", "peony", "rugosa");
            System.Console.WriteLine(MyWreath);
            System.Console.ReadKey(true);
        }


        public abstract class Flower
        {
            public abstract string Garland(string flower1, string flower2, string flower3);
            public abstract string Wreath(string flower1, string flower2, string flower3);
        }

        public class Flower2 : Flower
        {
            public override string Garland(string flower1, string flower2, string flower3)
            {
                string FlowerGarland = flower1 + "  " + flower2 + "  " + flower3;
                return FlowerGarland;
            }

            public override string Wreath(string flower1, string flower2, string flower3)
            {
                string FlowerWreath = flower1 + "  " + flower2 +  "  " + flower3 + "  " + flower1;
                return FlowerWreath;
            }
        }
    }
}
