using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moebler
{
    class Program
    {
        static void Main(string[] args)
        {
            Furniture F = new Furniture(); // Opretter genvej til klassen "Furniture"
            Chair C = new Chair(); // Opretter genvej til klassen "Chair"
            Computer K = new Computer();
            // Sætter værdi i instansvariabler i klassen "Chair"-------------------------------------------------------------------------------------------------------------------------------------
            C.SetCost(2000); 
            C.SetManufacturer("Jesus og Far tømmerfirma");
            C.SetAge("Ny");
            C.SetMaterial("Mahogny træ");
            C.SetPadding("Hård");
            //---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
            C.PrintInfo(); //Udskriver metoden PrintInfo i klassen Chair
            K.SetGpu("Nvidia Geforce 2080ti");
            K.SetCpu("Intel I7 Core");
            K.SetMotherboard("MSI Whataton");
            K.SetRam("32 MB");
            K.SetHukommelse("1TB SSD");
            K.SetManufacturer("Whackahole");
            K.SetCost(14000);
            K.PrintInfo();

            Console.WriteLine("Tast en vilkårlig tast for at afslutte.");
            Console.ReadKey();
        }
    }
}
