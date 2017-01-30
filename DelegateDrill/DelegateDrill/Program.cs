using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateDrill
{
    class Program
    {
        //create a delegate signature
        public delegate string MessageMaker(string s1);

        //create a class
        public class MakingStrings
        {
            //create a method that will be associated with an instance of the delegate
            public static string messageMaker(string s1)
            {
                return s1;
            }

        }


        static void Main(string[] args)
        {

            //create an instance of delegate and associate it with method messageMaker
            MessageMaker messageString1;

            // associate the delegate object that references a method

            messageString1 = new MessageMaker(Program.MakingStrings.messageMaker);
            string s = messageString1("hello");

            System.Console.WriteLine(s);

            System.Console.ReadKey(true);
        }
    }
}

    

