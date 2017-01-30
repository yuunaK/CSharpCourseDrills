using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication_SealedClass
{
    class Program
    {
        static void Main()
        {
            var x = new Greeting();
            var y = new Greeting();
            var z = new Introduction();
            var s = new Introduction();
            var t = new Anecdote();

            var firstGreeting = x.Hello();
            var secondGreeting = y.Anyeong();
            var thirdGreeting = z.Hello();
            var fourthGreeting = s.Anyeong();
            var fifthGreeting = t.Anyeong();

            System.Console.WriteLine(firstGreeting);
            System.Console.WriteLine(secondGreeting);
            System.Console.WriteLine(thirdGreeting);
            System.Console.WriteLine(fourthGreeting);
            System.Console.WriteLine(fifthGreeting);

            System.Console.ReadKey(true);

        }

        class Greeting
        {
            public virtual string Hello()
            {
                string greeting = "Hello : - }";
                return greeting;
            }

            public virtual string Anyeong()
            {
                string greeting2 = "Anyeong : - ]";
                return greeting2;
            }
        }

        class Introduction: Greeting
        {
            public sealed override string Hello()
            {
                string greeting3 = "Hello : - }, My name is Winnie the Bear.";
                return greeting3;
            }

            public override string Anyeong()
            {
                string greeting4 = "Anyeong haseyo!";
                return greeting4;
            }
        }

        class Anecdote : Introduction
        {
            public override string Anyeong()
            {
                string greeting5 = "Once, I was greeted by a great bear with a great \n big bear hug.  We became good friends.";
                return greeting5;
            }
        }
    }
}
