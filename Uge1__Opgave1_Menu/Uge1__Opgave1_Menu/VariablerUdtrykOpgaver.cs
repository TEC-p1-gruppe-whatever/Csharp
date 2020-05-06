using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uge1__Opgave1_Menu
{
    class VariablerUdtrykOpgaver
    {
        public void Opgave1()
        {
            Random Rnd = new Random(); // Definere en genvej til at generere tilfaeldige tal.
            int Tal1;
            int Tal2;
            int Tal3;
            int Resultat;
            //Nedenunder tildeles Tal1, Tal2 og Tal3 tilfældige tal.
            Tal1 = Rnd.Next(10, 30);
            Tal2 = Rnd.Next(3, 8);
            Tal3 = Rnd.Next(14, 30);
            //----------------------------------------------------------------------------------------------------------------------------

            Resultat = Tal1 * Tal2 - Tal3; // Tal1, Tal2 og Tal3 regnes sammen og resultatet gemmes i variablen "Resultat"
            Console.Write("Resultatet af baggrundsbereginger er: {0}, ", Resultat); //Udskriver "Resultat"
            // Nedenunder udregnes om "Resultat" er et lige eller ulige tal.
            if (Resultat % 2 == 0) // Tjekker om variablen er et lige tal
            {
                Console.WriteLine("dette er et lige tal."); 
            }
            // Hvis ikke variablen er et lige tal koere denne kode
            else
            {
                Console.WriteLine("Dette er et ulige tal.");
            }
            //--------------------------------------------------------------------------------------------------------------------------------
        }
        public void Opgave2()
        {
            Random Rnd = new Random(); //Opretter en genvej for tilfaedlige tal
            int Tal1 = Rnd.Next(1, 11); //Opretter og tildeler en integer et tilfaeldigt tal
            int Tal2 = Rnd.Next(11, 21); //Opretter og tildeler en integer et tilfaeldigt tal
            int Tal3 = Rnd.Next(20, 31); //Opretter og tildeler en integer et tilfaeldigt tal
            int Resultat; //Opretter en integer til resultat
            Resultat = Tal1 * Tal3 - Tal2; // Udregner resultat
            Console.WriteLine("Kim + {0}, Iben * {1}, Torben - {2} = {3}",Tal1, Tal3, Tal2, Resultat);
        }
    }
}
