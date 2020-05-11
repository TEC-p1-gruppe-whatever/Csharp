using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moebler
{
    class Furniture
    {
        protected double Cost;
        protected string Manufacturer;

        public void SetCost(double Cost)
        {
            this.Cost = Cost;
        }
        public double GetCost()
        {
            return Cost;
        }
        public void SetManufacturer(string Manufacturer)
        {
            this.Manufacturer = Manufacturer;
        }
        public void PrintInfo()
        {
            Console.WriteLine("{furniture} "+Manufacturer+" - "+Cost);
        }
    }
}
