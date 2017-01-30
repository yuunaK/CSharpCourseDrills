using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructDrill
{
    class StructsExample
    {
        //create a struct definition
        public struct Boxes
        {
            //properties
            public int length;
            public int width;
            public int height;

            //method to calculate volume
            public int BoxVolume(int l, int w, int h)
            {
                int volume = l * w * h;
                return volume; ;
            }
        }


        static void Main(string[] args)
        {
            //create an instance of the struct Boxes
            Boxes box1 = new Boxes();
            box1.length = 12;
            box1.width = 5;
            box1.height = 9;

            int box1Volume = box1.BoxVolume(12, 5, 9);

            //Print statements to screen
            System.Console.WriteLine("Box1 length is {0} inches.", box1.length);
            System.Console.WriteLine("Box1 width is {0} inches. ", box1.width);
            System.Console.WriteLine("Box1 height is {0} inches. ", box1.height);
            System.Console.WriteLine("Box1 volume is {0} cubic inches. ", box1Volume);
            System.Console.WriteLine("Press any key to exit. ");

            // Allow console window to remain open until user enters a key to exit.
            System.Console.ReadKey(true);



        }
    }
}
