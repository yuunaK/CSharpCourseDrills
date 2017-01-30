
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WritingToLogDrill
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

                string filePath = "c:\\users\\yk123\\documents\\visual studio 2015\\Projects\\WritingToLogDrill\\LogFile.txt";
                
                using (StreamWriter outputFile = new StreamWriter(filePath))
                {
                    outputFile.WriteLine(e);
                }

                System.Console.WriteLine(e);
                }


                finally
                {
                    Console.WriteLine("Quotient: {0}", quotient);
                }

            }

            static void Main(string[] args)
            {
                Dividing d = new Dividing();
                d.DividingMethod(6, 0);
                Console.ReadKey(true);

            }
        }
    }