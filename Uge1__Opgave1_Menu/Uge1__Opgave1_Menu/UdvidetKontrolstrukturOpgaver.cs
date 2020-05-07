using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uge1__Opgave1_Menu
{
    class UdvidetKontrolstrukturOpgaver
    {
        public void Opgave1()
        {//Opgave udfoere 3-tabellen, men stopper hvis tallet er 21------------------------------------------------------------------------------------------------------------
            int Tal1=3;
            for (int i = 1; i < 11; i++)
            {
                if(Tal1 == 21) // Stopper tabellen hvis det indikerede tal er naaet.
                {
                    break;
                }
                Console.WriteLine(Tal1); // Udskriver Tal1
                Tal1 = Tal1 / i * (i+1); // Udregner tallet i tabellen, regnestykket er lavet, saadan at man kan aendre hvilken tabel det koere, bare ved at udskrifte Tal1
                System.Threading.Thread.Sleep(1000); // soerger for at koden udfoeres i et tempo menesker kan foelge med i.


            }
            Console.WriteLine("Loopen er nu stoppet."); // Indikere at loopen er stoppet.
            System.Threading.Thread.Sleep(10000); // Giver brugeren tid til at laese foer programmet fortsaetter.
            Console.Clear();
        }
        //---------------------------------------------------------------------------------------------------------------------------------------------------------------------
        public void Opgave2()
        {
            // Programmet udfoere en tabel, indikeret i Tal1------------------------------------------------------------------------------------------------------------------
            int Tal1 = 4; // Indikere hvilken tabel programmet skal koere.
            for (int i = 1; i < 11; i++)
            {
                if(Tal1 == 16) // Koden fanger og koere ved det specificerede tal.
                {
                    Tal1 = Tal1 / i * (i + 1); // Incrementere Tal1
                }
                else
                {
                    Console.WriteLine(Tal1); // Udskriver Tal1
                    Tal1 = Tal1 / i * (i + 1); // Incrementere Tal1
                    System.Threading.Thread.Sleep(1000); // soerger for at koden udfoeres i et tempo menesker kan foelge med i.
                }
                
            }
            Console.WriteLine("Loopen er nu stoppet."); // Indikere at loopen er stoppet.
            System.Threading.Thread.Sleep(10000); // Giver brugeren tid til at laese foer programmet fortsaetter.

        }
        //---------------------------------------------------------------------------------------------------------------------------------------------------------------------
        //---------------------------------------------------------------------------------------------------------------------------------------------------------------------
        public void Opgave3()
        {
            string ModtagetTal; // string til at modtage brugerens input.
            double DagliKilometer=0; // string til at indeholde de koerte kilometre
            do
            {
                Console.WriteLine("Indtast venligst hvor langt du koere, og tryk enter.");
                ModtagetTal = Console.ReadLine();
                double.TryParse(ModtagetTal, out DagliKilometer);
                Console.Clear();

            }while (DagliKilometer <= 0);
            if(DagliKilometer <= 24)
            {
                Console.WriteLine("Du får desværre ikke noget fradrag.");
            }
            else if(DagliKilometer >=25 && DagliKilometer <= 100)
            {
                Console.WriteLine("Du får {0:N2} kr. i fradrag,",(DagliKilometer-24)*1.54);
            }
            else if(DagliKilometer > 100)
            {
                Console.WriteLine("Du får {0:N2} kr. i fradrag.", (76 * 1.54 + ((DagliKilometer - 100) * 0.77)));
            }
            else
            {
                Console.WriteLine("Der er sket en fejl, og du bliver ført tilbage til menuen, vent venligst.");
            }
            System.Threading.Thread.Sleep(5000);


        }
        //---------------------------------------------------------------------------------------------------------------------------------------------------------------------
        //---------------------------------------------------------------------------------------------------------------------------------------------------------------------
        public void Opgave4()
        {// Opretter variabler til brug i undregning omkring skat-----------------------------------------------------------------------------------------------------------------
            string IndtastetIndkomst;
            double Indkomst;
            bool IndtastningKorrekt = false;
            //--------------------------------------------------------------------------------------------------------------------------------------------------------------------

            do
            {// Brugeren indtaster sin indkomst for aaret----------------------------------------------------------------------------------------------------------------------
                Console.WriteLine("Indtast venligst din indkomst i år.");
                IndtastetIndkomst = Console.ReadLine();
                //-------------------------------------------------------------------------------------------------------------------------------------------------------------
                Console.Clear();
                if(double.TryParse(IndtastetIndkomst, out Indkomst) && Indkomst >=0) // Hvis brugerens indtastning kan konverteres til en double, koere koden.
                {
                    IndtastningKorrekt = true; // Koden indikere til loopen, at den kan stoppe med at koere.
                }
                // Hvis indtastningen er ugylding, koere else saetningen.------------------------------------------------------------------------------------------------------
                else
                {
                    Console.WriteLine("Indtastning er ugylding, du  kan kun indtaste tal, og du kan ikke indtaste tal mindre end 0. Indtast igen, og tryk enter.");
                }
                //-------------------------------------------------------------------------------------------------------------------------------------------------------------


            } while (IndtastningKorrekt==false);
            if(Indkomst <= 42000)
            {
                Console.WriteLine("Du har tjent {0:N2} kr. i år, og du skal ikke betale skat.", Indkomst);
            }
            else if(Indkomst >=42000 && Indkomst < 280000)
            {
                Console.WriteLine("Du har tjent {0:N2}  kr. i år, og skal betale {1:N2} kr. i skat.", Indkomst,Indkomst*0.3);
            }
            else if (Indkomst>= 280000 && Indkomst < 390000)
            {
                Console.WriteLine("Du har tjent {0:N2}  kr. i år, og skal betale {1:N2} kr. i skat.", Indkomst,(Indkomst* 0.3)+(Indkomst-279999*(0.06)));
            }
            else if (Indkomst >= 390000)
            {
                Console.WriteLine("Du har tjent {0:N2}  kr. i år, og skal betale {1:N2} kr. i skat.", Indkomst, (Indkomst * 0.3) + ((Indkomst - 279999) * 0.06)+((Indkomst-389999)*0.15));
            }
        }
        //---------------------------------------------------------------------------------------------------------------------------------------------------------------------
        //---------------------------------------------------------------------------------------------------------------------------------------------------------------------
        public void Opgave5()
        {//opretter variabler til brug i koden--------------------------------------------------------------------------------------------------------------------------------
            string ModtagetKontoIndenhavende;
            double KontoIndehavende;
            bool IndtastningKorrekt = false;
            //----------------------------------------------------------------------------------------------------------------------------------------------------------------
            Console.WriteLine("Velkommen til udnyttelse og kapitalinvest bankens rente udregner.\nIndtast venligst hvor mange penge du har i dine kontoer hos os, og tryk enter");
            do
            {
                ModtagetKontoIndenhavende = Console.ReadLine();
                Console.Clear();
                // if else saetning, til at haandtere brugerens indtastede kontoindenhavende.
                if(double.TryParse(ModtagetKontoIndenhavende, out KontoIndehavende))
                {
                    if (KontoIndehavende <= 0)
                    {
                        Console.WriteLine("Du har {0:N2} kr. i dine konto, og får ingen penge af os.", KontoIndehavende);
                        IndtastningKorrekt = true;
                    }
                    else if(KontoIndehavende >0 && KontoIndehavende < 25000)
                    {
                        Console.WriteLine("Du har {0:N2} kr. i dine konti, og får en rentesats op {0:N2} kr. om året.", KontoIndehavende, KontoIndehavende *0.25 /100);
                        IndtastningKorrekt = true;
                    }
                    else if (KontoIndehavende >= 25000 && KontoIndehavende <= 150000)
                    {
                        Console.WriteLine("Du har {0:N2} kr. i dine konti, og får en rentesats op {0:N2} kr. om året.", KontoIndehavende, KontoIndehavende * 1.25 / 100);
                        IndtastningKorrekt = true;
                    }
                    else if (KontoIndehavende > 150000)
                    {
                        Console.WriteLine("Du har {0:N2} kr. i dine konti, og får en rentesats op {0:N2} kr. om året.", KontoIndehavende, ((150000 * 1.25/100)+(KontoIndehavende -150000)*0.5 /100));
                        IndtastningKorrekt = true;
                    }
                }
                else
                {
                    Console.WriteLine("Velkommen til udnyttelse og kapitalinvest bankens rente udregner.\nIndtast venligst hvor mange penge du har i dine kontoer hos os, og tryk enter");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Indtastningen er ugyldig, indtast venligst et tal, og tryk enter.");
                    Console.WriteLine("Vær opmærksom på, at hvis du har en negativ saldo på din konto, får du ikke nogle penge af os.");
                    Console.ForegroundColor = ConsoleColor.White;
                }

            } while (IndtastningKorrekt == false);
        }
        //---------------------------------------------------------------------------------------------------------------------------------------------------------------------
        //---------------------------------------------------------------------------------------------------------------------------------------------------------------------
    }
}
