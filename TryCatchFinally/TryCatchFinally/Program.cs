using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatchFinally
{
    class Dividing 
    {
        int quotient;
        public int Quotient()
        {
            quotient = 0;
            return quotient;
        }

        public void DividingMethod(int num1, int num2)
        {
            try
            {
                quotient = num1 / num2;

            }

            catch (DivideByZeroException e)
            {
                Console.WriteLine("Exception: {0} ", e);
            }

            finally
            {
                Console.WriteLine("Quotient: {0}", quotient);
            }
        
        }

        static void Main(string[] args)
        {
            Dividing d = new Dividing();
            d.DividingMethod(6, 3);
            Console.ReadKey(true);

        }
    }
}
