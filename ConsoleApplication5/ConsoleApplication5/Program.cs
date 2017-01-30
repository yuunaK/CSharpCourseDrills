using System;


namespace ConsoleApplication5
{
    class OverloadProgram
    {
        static void Main()
        {
            System.Console.WriteLine("Hello. I have designed a program that will \nhelp you calculate the perimeter of a square.");
            System.Console.Write("Please enter the length of a  side of a square. ");
            string str_squareLength = System.Console.ReadLine();
            int intSquareLength;
            float fltSquareLength;
            if (int.TryParse(str_squareLength, out intSquareLength) == false)
            {
                float.TryParse(str_squareLength, out fltSquareLength);
                float fltPerimeter = PerimeterCalculator(fltSquareLength);
                System.Console.WriteLine("The perimeter of a square whose side is length {0} is {1}.", fltSquareLength, fltPerimeter);
                System.Console.ReadKey(true);
            }
           else
            {
                int perimeter = PerimeterCalculator(intSquareLength);
                System.Console.WriteLine("The perimeter of a square whose side is length {0} is {1}.", intSquareLength, perimeter);
                System.Console.ReadKey(true);
            } 
        }

        static int PerimeterCalculator(int x)
        {
            int SquarePerimeter;
            SquarePerimeter = 4 * x;
            return SquarePerimeter;
        }
        
       static float PerimeterCalculator(float y)
        {
            float SquarePerimeter;
            SquarePerimeter = 4 * y;
            return SquarePerimeter;
        }
        
           

    }
    
}

