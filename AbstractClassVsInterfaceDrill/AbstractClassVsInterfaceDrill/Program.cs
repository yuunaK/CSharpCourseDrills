using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassVsInterfaceDrill
{
    class Program
    {
       abstract public class WorkingWithTriangles
        {
            bool AcuteTriangle, ObtuseTriangle, RightTriangle;
            double AngleA, AngleB, AngleC;
            double SideA, SideB, SideC;

            abstract public bool CheckToSeeIfSidesFormTriangle(double SideA, double SideB, double SideC);

            abstract public double SolveForAreaofTriangle(double Base, double Height);

        }

        interface OptionsToSolveForTheSideofRigthTriangle
        {
            double SolveForHypotenuseofRightTriangle(double Base, double Height);
            double SolveForHeightGivenBaseandHypotenuse(double Base, double Hypotenuse);
            double SolveForBaseGivenHeightandHypotenuse(double Height, double Hypotenuse);
        }

        interface OptionsToSolveForAnglesinRightTriangle
        {
            double SolveForAngleAofRightTriangleUsingSine(double Height, double Hypotenuse);

            double SolveForAngleBofRightTriangleUsingSine(double Base, double Hypotenuse);

            double SolveForAngleAofRightTriangleUsingCosine(double Base, double Hypotenuse);

            double SolveForAngleBofRightTriangleUsingCosine(double Height, double Hypotenuse);

            double SolveForAngleAofRightTriangleUsingTangent(double Base, double Height);

            double SolveForAngleBofRightTriangleUsingTangent(double Base, double Height);
        }



        public class RightTriangles : WorkingWithTriangles, OptionsToSolveForAnglesinRightTriangle, OptionsToSolveForTheSideofRigthTriangle
        {
            double SideBase, SideHeight, SideHypotenuse;


            public override bool CheckToSeeIfSidesFormTriangle(double SideA, double SideB, double SideC)
            {
                double x = SideA + SideB;
                double y = SideB + SideC;
                double z = SideC + SideA;

                if (x > SideC && y > SideA && z > SideB)
                {
                    return true;
                }
                return false;    
            }

            override public double SolveForAreaofTriangle(double Base, double Height)
            {
                SideBase = Base;
                SideHeight = Height;
                double areaOfTriangle = (0.5 * SideBase * SideHeight);
                return areaOfTriangle;
            }

            double OptionsToSolveForTheSideofRigthTriangle.SolveForHypotenuseofRightTriangle(double Base, double Height)
            {
                SideBase = Base;
                SideHeight = Height;
                SideHypotenuse = (Math.Sqrt(Math.Pow(SideBase, 2) + Math.Pow(SideHeight, 2)));
                return SideHypotenuse;
            }

            double OptionsToSolveForTheSideofRigthTriangle.SolveForHeightGivenBaseandHypotenuse(double Base, double Hypotenuse)
            {
                SideBase = Base;
                SideHypotenuse = Hypotenuse;

                SideHeight = (Math.Sqrt(Math.Pow(SideHypotenuse, 2) - Math.Pow(SideBase, 2)));
                return SideHeight;
            }

            double OptionsToSolveForTheSideofRigthTriangle.SolveForBaseGivenHeightandHypotenuse(double Height, double Hypotenuse)
            {
                SideHeight = Height;
                SideHypotenuse = Hypotenuse;

                SideBase = (Math.Sqrt(Math.Pow(SideHypotenuse, 2) - Math.Pow(SideHeight, 2)));
                return SideBase;
            }

            double OptionsToSolveForAnglesinRightTriangle.SolveForAngleAofRightTriangleUsingSine(double Height, double Hypotenuse)
            {
                SideHeight = Height;
                SideHypotenuse = Hypotenuse;

                double AngleA = (90.0 * (SideHeight / SideHypotenuse));

                return AngleA;
            }

            double OptionsToSolveForAnglesinRightTriangle.SolveForAngleBofRightTriangleUsingSine(double Base, double Hypotenuse)
            {
                SideBase = Base;
                SideHypotenuse = Hypotenuse;

                double AngleB = (90.0 * (SideBase / SideHypotenuse));

                return AngleB;
            }

            double OptionsToSolveForAnglesinRightTriangle.SolveForAngleAofRightTriangleUsingCosine(double Base, double Hypotenuse)
            {
                SideBase = Base;
                SideHypotenuse = Hypotenuse;

                double AngleA = (90.0 * (SideBase / SideHypotenuse));
                return AngleA;
            }

            double OptionsToSolveForAnglesinRightTriangle.SolveForAngleBofRightTriangleUsingCosine(double Height, double Hypotenuse)
            {
                SideHeight = Height;
                SideHypotenuse = Hypotenuse;

                double AngleB = (90.0 * (SideHeight / SideHypotenuse));
                return AngleB;
            }

            double OptionsToSolveForAnglesinRightTriangle.SolveForAngleAofRightTriangleUsingTangent(double Base, double Height)
            {
                SideBase = Base;
                SideHeight = Height;

                double TanAngleA = (90.0 * (SideHeight / SideBase));

                return TanAngleA;

            }

            double OptionsToSolveForAnglesinRightTriangle.SolveForAngleBofRightTriangleUsingTangent(double Base, double Height)
            {
                SideBase = Base;
                SideHeight = Height;

                double TanAngleB = (90.0 * (SideBase / SideHeight));

                return TanAngleB;
            }

  

        }


        static void Main(string[] args)
        {
            System.Console.WriteLine("This program provides basic missing information about right triangles.");
            System.Console.WriteLine("Please enter information available about your right triangle.");

            System.Console.Write("\nLength of base: ");
            string StringBase = System.Console.ReadLine();
            double DoubleBase;
            double.TryParse(StringBase, out DoubleBase);

            System.Console.Write("Length of height: ");
            string StringHeight = System.Console.ReadLine();
            double DoubleHeight;
            double.TryParse(StringHeight, out  DoubleHeight);

            System.Console.Write("Length of hypotenuse: ");
            string StringHypotenuse = System.Console.ReadLine();
            double DoubleHypotenuse;
            double.TryParse(StringHypotenuse, out DoubleHypotenuse);


            RightTriangles rt1 = new RightTriangles();
            OptionsToSolveForTheSideofRigthTriangle rt2 = new RightTriangles();
            OptionsToSolveForAnglesinRightTriangle rt3 = new RightTriangles();



            if ((DoubleBase != 0) && (DoubleHypotenuse != 0))
            {
                double HeightofRightTriangle = rt2.SolveForHeightGivenBaseandHypotenuse(DoubleBase, DoubleHypotenuse);
                double AreaOfRightTriangle = rt1.SolveForAreaofTriangle(DoubleBase, HeightofRightTriangle);
                double AngleA = rt3.SolveForAngleAofRightTriangleUsingCosine(HeightofRightTriangle, DoubleHypotenuse);
                double AngleB = rt3.SolveForAngleBofRightTriangleUsingSine(DoubleBase, DoubleHypotenuse);

                if (AngleA + AngleB > 90)
                {
                    double i = 0.1;
                    while (AngleA + AngleB != 90)
                    {
                        AngleA = AngleA - (AngleA * i);
                        AngleB = AngleB - (AngleB * i);
                        i = i + .00001;
                    }
                }



                System.Console.WriteLine("\nYou have provided the following information: \nbase, {0} \nhypotenuse {1}.", DoubleBase, DoubleHypotenuse);
                System.Console.WriteLine("\n\nThe height of your right triangle is {0}.", HeightofRightTriangle);
                System.Console.WriteLine("The area of triangle is {0}.", AreaOfRightTriangle);
                System.Console.WriteLine("The measure of the angle between the hypotenuse and base is {0}.", AngleA);
                System.Console.WriteLine("The measure of the angle between the hypotenuse and height is {0}.", AngleB);
                System.Console.ReadKey(true);
            }
            
            if ((DoubleHeight != 0) && (DoubleHypotenuse != 0))
            {
                double BaseofRightTriangle = rt2.SolveForBaseGivenHeightandHypotenuse(DoubleHeight, DoubleHypotenuse);
                double AreaOfRightTriangle = rt1.SolveForAreaofTriangle(BaseofRightTriangle, DoubleHeight);
                double AngleA = rt3.SolveForAngleAofRightTriangleUsingSine(DoubleHeight, DoubleHypotenuse);
                double AngleB = rt3.SolveForAngleBofRightTriangleUsingCosine(BaseofRightTriangle, DoubleHypotenuse);
                System.Console.WriteLine("\nYou have provided the following information:\n height, {0} \nhypotenuse {1}.", DoubleHeight, DoubleHypotenuse);
                System.Console.WriteLine("\n\nThe base of your right triangle is {0}.", BaseofRightTriangle);
                System.Console.WriteLine("The area of the right triangle is {0}.", AreaOfRightTriangle);
                System.Console.WriteLine("The measure of the angle between the hypotenuse and base is {0}.", AngleA);
                System.Console.WriteLine("The measure of the angle between the hypotenuse and height is {0}.", AngleB);
                System.Console.ReadKey(true);

            }

            if ((DoubleBase != 0) && (DoubleHeight != 0))
            {
                double HypotenuseofRightTriangle = rt2.SolveForHypotenuseofRightTriangle(DoubleBase, DoubleHeight);
                double AreaOfRightTriangle = rt1.SolveForAreaofTriangle(DoubleBase, DoubleHeight);
                double AngleA = rt3.SolveForAngleAofRightTriangleUsingTangent(DoubleBase, DoubleHeight);
                double AngleB = rt3.SolveForAngleBofRightTriangleUsingTangent(DoubleBase, DoubleHeight);
                System.Console.WriteLine("\nYou have provided the following information:\n base, {0} \nheight {1}.", DoubleBase, DoubleHeight);
                System.Console.WriteLine("\n\nThe hypotenuse of your right triangle is {0}.", HypotenuseofRightTriangle);
                System.Console.WriteLine("The area of the right triangle is {0}.", AreaOfRightTriangle);
                System.Console.WriteLine("The measure of the angle between the hypotenuse and base is {0}.", AngleA);
                System.Console.WriteLine("The measure of the angle between the hypotenuse and height is {0}.", AngleB);
                System.Console.ReadKey(true);

            }
 
            

            
        }
    }
}
