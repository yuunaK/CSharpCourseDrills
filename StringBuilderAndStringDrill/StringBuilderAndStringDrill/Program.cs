using System;
using System.Text;




namespace StringBuilderAndStringDrill
{
    class Program
    {
    
        static void Main(string[] args)
        {
            string flowerName = "Hellebore";
            flowerName = "Anemone";
            StringBuilder sbGreeting = new StringBuilder("I like roses.");
            System.Console.WriteLine(sbGreeting);
            System.Console.WriteLine(flowerName);


            sbGreeting.Append("I also like daisies.");
            string flowerName2 = "Helleborus Orientalis";
            
            System.Console.WriteLine(sbGreeting);
            System.Console.WriteLine(flowerName2);
            System.Console.WriteLine();

            System.Console.ReadKey(true);


        }
    }
}
