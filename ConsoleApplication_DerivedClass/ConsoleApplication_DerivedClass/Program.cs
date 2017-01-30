using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication_DerivedClass
{
    class DerivedClassDrill
    {
        public abstract class vehicle
        {   public string name;
            public string engine;
            public string transmission;

            public abstract void StartEngine();
            public abstract void GetGas();
            public abstract float GetDistance(float speed, float time);
        }

        public class truck : vehicle
        {
            public override void GetGas()
            {
                throw new NotImplementedException();
            }

            public override void StartEngine()
            {
                throw new NotImplementedException();
            }

            public override float GetDistance(float speed, float time)
            {
               float distance = speed * time;
                return distance;
            }
        }


        static void Main(string[] args)
        {
            System.Console.Write("Please enter the name of your vehicle.  ");
            string VehicleName = System.Console.ReadLine();

            
            System.Console.Write("Please enter your driving speed.  ");
            string speed = System.Console.ReadLine();
            float fltspeed;
            float.TryParse(speed, out fltspeed);



            
            System.Console.Write("Plese enter time spent driving. ");
            string time = System.Console.ReadLine();
            float timeDriving;
            float.TryParse(time, out timeDriving);

            System.Console.Write("Minutes or Hours? ");
            string timeIncrement = System.Console.ReadLine();
            
            if (timeIncrement.ToLower() == "minutes")
            {
                timeDriving = timeDriving / 60;

            }

            truck truck1 = new ConsoleApplication_DerivedClass.DerivedClassDrill.truck();
            float distanceDriven = truck1.GetDistance(fltspeed, timeDriving);
         
            System.Console.WriteLine("Your {0} has been driven {1} miles.", VehicleName, distanceDriven);
            System.Console.ReadKey(true);
        }
    }
}




