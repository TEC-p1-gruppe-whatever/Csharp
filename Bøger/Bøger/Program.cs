using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bøger
{
    class Program
    {
        static void Main(string[] args)
        {//Opretter variabler til brug i koden---------------------------------------------------------------------------------------------------------------------------------
            
            int Penge;
            bool PengeInputGodkendt;
            //-----------------------------------------------------------------------------------------------------------------------------------------------------------------
            Bog SherlockHolmes = new Bog(500); // Opretter en forbindelse til classen "Bog"
            SherlockHolmes.PrintInfo(); // Udskriver metoden PrintInfo i classen Bog.
            //Loop hvor brugeren indtaster hvor mange penge de har, for at samligne med prisen paa bogen.
            do
            {
                Console.WriteLine("{0} koster {1} kr. Indtast hvor mange penge du har at købe for.",SherlockHolmes.Title, SherlockHolmes.Pris);
                // If else saetningen sikre at input kun bliver godkendt, hvis det er et tal.---------------------------------------------------------------------------------
                if(Int32.TryParse(Console.ReadLine(), out Penge)) {
                    PengeInputGodkendt = true;
                }
                else
                {
                    PengeInputGodkendt = false;
                }
                //-------------------------------------------------------------------------------------------------------------------------------------------------------------

            } while (PengeInputGodkendt == false);
            //-----------------------------------------------------------------------------------------------------------------------------------------------------------------
            bool HarRaadBool = SherlockHolmes.HarRaad(Penge); // Kalder paa en metode, til at udrenge om brugeren har raad til en bog.
            SherlockHolmes.PrintInfo();
            if (HarRaadBool) // Hvis brugeren har raad til bogen, koere if saetningen.
            {
                Console.WriteLine("jeg har råd til at købe {0}.",SherlockHolmes.Title);
            }
            else // Hvis brugeren ikke har raad til en bog, koere else saetningen
            {
                Console.WriteLine("Jeg har desværre ikke råd til at købe {0}.", SherlockHolmes.Title);
            }
            System.Threading.Thread.Sleep(5000); // Pausere koden, saa brugeren har tid til at laese udskriften, foer programmet slutter.

        }


    }
}
