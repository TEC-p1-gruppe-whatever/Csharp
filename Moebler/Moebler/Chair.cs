using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moebler
{
    class Chair : Furniture
    {
        
        private string Material;
        private string Padding;
        private string age;

        public void SetMaterial(string Material)
        {
            this.Material = Material;
        }
        public string GetMaterial()
        {
            return Material;
        }
        public void SetPadding(string Padding)
        {
            this.Padding = Padding;
        }
        public string GetPadding()
        {
            return Padding;
        }
        public void SetAge(string Age)
        {
            this.age = Age;
        }
        public string GetAge()
        {
            return age;
        }

        public void PrintInfo()
        {
            Console.WriteLine("[Chair] {0} - {1} - {2} - {3} - {4} kr.", Manufacturer, Material,Padding,age,Cost);
        }
        
    }
}
