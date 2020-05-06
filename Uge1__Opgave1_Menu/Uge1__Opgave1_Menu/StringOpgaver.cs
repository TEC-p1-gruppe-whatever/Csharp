using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uge1__Opgave1_Menu
{
    class StringOpgaver
    {
        public (int, string, double) Opgave1()
        {
            int Tal1 = 1; //Opretter og tildeler en integer et tal
            string Tekst1 = "Hovsa hovsa missilet"; //Opretter og tildeler en string en tekst
            double Tal2 = 2.5; //Opretter og tildeler en double et tal
            //Udskriver variablerne
            Console.WriteLine(Tal1);
            Console.WriteLine(Tekst1);
            Console.WriteLine(Tal2);
            //---------------------------------------------------------------------------------------------------
            return (Tal1, Tekst1,Tal2); // Returnere variablerne til den kaldende metode
        }
        //----------------------------------------------------------------------------------------------------------------------------------------------------
        public void Opgave2()
        {
            var (Tal1, Tekst1, Tal2) = Opgave1(); //Kalder paa metoden for opgave1, og modtager variablerne
            Console.Clear();
            Console.WriteLine(Tal1+1); //Udskriver en variable med modifikationer

        }
        //----------------------------------------------------------------------------------------------------------------------------------------------------
        public void Opgave3()
        {
            string Tekst1 = "I dag har vi den 24. December"; // Opretter og tildeler en string tekst
            Console.WriteLine(Tekst1); // Udskriver en string
        }
        //----------------------------------------------------------------------------------------------------------------------------------------------------
        public void Opgave4()
        {
            double Tal1 = 200.50; //Opretter of tildeler en variable et tal
            string Tekst1 = "Jeg har"; //Opretter og tildeler en string indhold
            string Tekst2 = "Kr. i banken."; // Opretter og tildeler en string indhold
            Console.WriteLine("{0} {1} {2}", Tekst1, Tal1, Tekst2); // Udskriver variabler som en samlet tekst
        }
        //----------------------------------------------------------------------------------------------------------------------------------------------------
    }
}
