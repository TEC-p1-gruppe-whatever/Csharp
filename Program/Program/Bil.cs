using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    class Bil
    {
        public void MotorStart()
        {
            Console.WriteLine("Motoren er started");
        }
        public void MotorSluk()
        {
            Console.WriteLine("Motoren er slukket.");
        }
        public double FillGas(double Liters, bool IsDiesel)
        {
            Console.Write("Filled tank with {0} Liters of ", Liters);
            if (IsDiesel)
            {
                Console.WriteLine("Diesel.");
            }
            else
            {
                Console.WriteLine("Gas.");
            }
            return Liters;
        }
        public double RemainingGas()
        {
            double Gas = 4;
            Console.WriteLine(Gas);
            return Gas;
        }
    }
}
