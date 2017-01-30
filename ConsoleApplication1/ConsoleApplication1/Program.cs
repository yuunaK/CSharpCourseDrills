using System;


namespace ConsoleApplication1
{
    class TestProgram
    {
        public static void Main()
        {
            int x = 12 * 30;
            Console.WriteLine("12 * 30 = " + x);
            Console.Write("What is your age? ");
            string age = Console.ReadLine();
            Console.WriteLine("You are {0} years old.", age);

            Console.WriteLine();
    
            int counter = 1;
            while(counter <= 5)
            {
                Console.WriteLine("*****\n\n");
                counter++;
            }

            int a = 10;
            float z = 12.5f;
            string textVar = "C# programming";
            Console.WriteLine(a);
            Console.WriteLine(z);
            Console.WriteLine(textVar);

            Console.Write("Hello. What is your name? ");
            string name = Console.ReadLine();
            Console.WriteLine("Hi, {0}.", name);


            Console.ReadLine();

            return;










        }
    }
}
