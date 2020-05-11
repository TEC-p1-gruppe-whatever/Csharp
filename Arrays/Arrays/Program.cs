using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] TalRaekke1 = { -2, -1, 0, 10 }; // Opretter og tildeler et array med vaerdier
            int[] TalRaekke2 = new int[4]; // Opretter et array, men tildeler ikke vaerdier.
            int[] TalRaekke3 = new int[6]; // Opretter et array, men tildelder ikke vaerdier
            string[] OrdRaekke1 = new string[5];
            // Foelgende kode tildeler vaerdier til arrayet "TalRaekke2"------------------------------------------------------------------------------------------------------------------------------
            TalRaekke2[0] = -2;
            TalRaekke2[1] = -1;
            TalRaekke2[2] = 0;
            TalRaekke2[3] = 10;
            //----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
            Console.WriteLine("Tallene er {0} og {1}", TalRaekke1[1], TalRaekke1[3]); // Udskriver tal gemt i et array.
            Console.WriteLine("Summen af arrayet TalRaekke1 er {0}", TalRaekke1.Sum()); // Udskriver summen af arrayet "TalRaekke1"
            // Foelgende kode tildeler vaerdier til arrayet "TalRaekke3"------------------------------------------------------------------------------------------------------------------------------
            TalRaekke3[0] = 5;
            TalRaekke3[1] = 10;
            TalRaekke3[2] = 15;
            TalRaekke3[3] = 20;
            TalRaekke3[4] = 25;
            TalRaekke3[5] = 30;
            //----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
            // Foelgende kode opretter en integer til at holde paa resultatet, og en for-loop samler summen af arrayet
            int Resultat = 0;
            for (int i = 0; i < TalRaekke3.Length; i++)
            {
                Resultat = Resultat + TalRaekke3[i];
            }
            //----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
            Console.WriteLine("Summen af arrayet TalRaekke3 er: {0}", Resultat); // Udskriver summen af arrayet.
            // Foelgende kode tildeler vaerdier til string arrayet, og udskriver dem derefter.--------------------------------------------------------------------------------------------------------
            OrdRaekke1[0] = "Hej ";
            OrdRaekke1[1] = "med ";
            OrdRaekke1[2] = "dig ";
            OrdRaekke1[3] = "du ";
            OrdRaekke1[4] = "sej!\n";
            for (int i = 0; i < OrdRaekke1.Length; i++)
            {
                Console.Write(OrdRaekke1[i]);
            }
            //----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
            Console.WriteLine("Tast på en vilkårlig tast for at afslutte.");
            Console.ReadKey(); 




        }
    }
}
