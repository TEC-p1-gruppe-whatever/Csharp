using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uge1__Opgave1_Menu
{
    class LoopOpgaver
    {
        public void Opgave1()
        {
            //Loop der udskriver en talraekke--------------------------------------------------------------------------------------------------------------------------------
            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine(i);
                System.Threading.Thread.Sleep(200);
            }
            //---------------------------------------------------------------------------------------------------------------------------------------------------------------
            int Tal1 = 1; // Opretter en integer, til at taelle med
            // Loop der udskriver en talraekke-------------------------------------------------------------------------------------------------------------------------------
            while (Tal1 <= 10)
            {
                Console.WriteLine(Tal1);
                Tal1++;
                System.Threading.Thread.Sleep(200);
             }
            //---------------------------------------------------------------------------------------------------------------------------------------------------------------
        }
        public void Opgave2()
        {
            //Loop der udskriver en talraekke--------------------------------------------------------------------------------------------------------------------------------
            for (int i = 100; i > 0; i--)
            {
                Console.WriteLine(i);
                System.Threading.Thread.Sleep(100);
            }
            //---------------------------------------------------------------------------------------------------------------------------------------------------------------
            int Tal1 = 100; // Opretter en integer, til at taelle med
            // Loop der udskriver en talraekke-------------------------------------------------------------------------------------------------------------------------------
            while (Tal1 > 0)
            {
                Console.WriteLine(Tal1);
                Tal1--;
                System.Threading.Thread.Sleep(100);
            }
            //----------------------------------------------------------------------------------------------------------------------------------------------------------------
        }
        public void Opgave3()
        {
            for (int i = 5; i < 51; i = i+5)
            {
                Console.WriteLine(i);
                System.Threading.Thread.Sleep(200);

            }

        }
        public void Opgave4()
        {
            bool RunLoop = true;
            while (RunLoop)
            {
                for (int i = 20; i > 0; i--)
                {
                    Console.WriteLine(i);
                    System.Threading.Thread.Sleep(200);
                }
                RunLoop = false;
            }

        }
        public void Opgave5()
        {
            int x = 7;
            for (int i = 1; i < 11; i++)

            {


                if (i < 10)
                {
                    Console.WriteLine("{0} * 7 = {1}", i, x);
                }
                else
                {
                    Console.WriteLine("{0} * 7= {1}", i, x);
                }
                x = x + 7;

                System.Threading.Thread.Sleep(200);




            }

        }
        public void Opgave6()
        {// Opretter variabler til brug i koden-------------------------------------------------------------------------------------------------------------------------------
            string ModtagetTal;
            int ValgtTabel;
            bool RunLoop =true;
            //----------------------------------------------------------------------------------------------------------------------------------------------------------------
            // Loop som soerger for at koden koere indtil et tal er indtastet-------------------------------------------------------------------------------------------------
            do
            {
                Console.WriteLine("Indtast den ønskede tabel til udregning, og tryk enter.");
                ModtagetTal = Console.ReadLine(); // Programmet tager i mod brugerens indtastning
                Console.Clear();
                if (Int32.TryParse(ModtagetTal, out ValgtTabel)) // Koden kontrollere om indtastningen er et tal, og koere if saetningen hvis det er et tal.
                {
                    
                    RunLoop = false;
                    for (int i = 1; i < 11; i++) // Forloopt soerger for at koden koere 10 gange.
                    {
                        Console.WriteLine("{0} * {1} = {2}", i, ValgtTabel, i * ValgtTabel); // Udskriver den indtastede tabel.
                        System.Threading.Thread.Sleep(200);
                    }
                }
                else // Hvis brugerens indtastning ikke er et tal, koere denne else saetning
                {
                    Console.WriteLine("Indtastningen er ugyldig, indtast venligst et tal.");
                }
            } while (RunLoop);
            //----------------------------------------------------------------------------------------------------------------------------------------------------------------
        }
        public void Opgave7()
        {//Opretter variabler til skabelse af ramme---------------------------------------------------------------------------------------------------------------------------
            int RammeBredde = 10;
            int RammeHoejde=4;
            int AfstandFraTop =4;
            int AfstandFraVenstre=20;
            //----------------------------------------------------------------------------------------------------------------------------------------------------------------
            //Laver oeverste linie i boxen------------------------------------------------------------------------------------------------------------------------------------
           
            for (int i = 0; i < RammeBredde; i++)
            {
                Console.SetCursorPosition(AfstandFraVenstre+i, AfstandFraTop); // Saetter cursoren til at lave top linie
                Console.WriteLine('\x2500'); // Top linie

            }
            Console.SetCursorPosition(AfstandFraVenstre + RammeBredde, AfstandFraTop);// Saetter cursoren til at lave top hoejre hjoerne
            Console.WriteLine('\x2510'); // Top hoejre hjoerne
            Console.SetCursorPosition(AfstandFraVenstre, AfstandFraTop); // Saetter cursoren til at lave top venstre hjoerne
            Console.WriteLine('\x250c'); // Top venstre hjoerne
            //Console.SetCursorPosition(30, 3);
            //Console.WriteLine("a");
            //----------------------------------------------------------------------------------------------------------------------------------------------------------------
            //Laver nederste linie i boxen------------------------------------------------------------------------------------------------------------------------------------
            for (int i = 0; i < RammeBredde; i++)
            {
                Console.SetCursorPosition(AfstandFraVenstre + i, AfstandFraTop+RammeHoejde); // Saetter cursoren til at lave nedre linie
                Console.WriteLine('\x2500'); // Top linie
            }
            Console.SetCursorPosition(AfstandFraVenstre + RammeBredde, AfstandFraTop+RammeHoejde);// Saetter cursoren til at lave top hoejre hjoerne
            Console.WriteLine('\x2518'); // nedre hoejre hjoerne
            Console.SetCursorPosition(AfstandFraVenstre, AfstandFraTop+RammeHoejde); // Saetter cursoren til at lave nedre venstre hjoerne
            Console.WriteLine('\x2514'); // nedre venstre 

            //----------------------------------------------------------------------------------------------------------------------------------------------------------------
            //Laver siderne i boxen-------------------------------------------------------------------------------------------------------------------------------------------
            for (int i = 1; i < RammeHoejde; i++)
            {
                Console.SetCursorPosition(AfstandFraVenstre, AfstandFraTop + i);
                Console.WriteLine('\x2502');
                Console.SetCursorPosition(AfstandFraVenstre+RammeBredde, AfstandFraTop + i);
                Console.WriteLine('\x2502');
            }
            Console.SetCursorPosition(1, AfstandFraTop + RammeHoejde + 2);
            //----------------------------------------------------------------------------------------------------------------------------------------------------------------

        }
        public void Opgave8()
        {//Opretter variabler til skabelse af ramme---------------------------------------------------------------------------------------------------------------------------
            int RammeBredde = 20;
            int RammeHoejde = 8;
            int AfstandFraTop = 4;
            int AfstandFraVenstre = 20;
            string navn = "Simon";
            //----------------------------------------------------------------------------------------------------------------------------------------------------------------
            //Laver oeverste linie i boxen------------------------------------------------------------------------------------------------------------------------------------

            for (int i = 0; i < RammeBredde; i++)
            {
                Console.SetCursorPosition(AfstandFraVenstre + i, AfstandFraTop); // Saetter cursoren til at lave top linie
                Console.WriteLine('\x2500'); // Top linie

            }
            Console.SetCursorPosition(AfstandFraVenstre + RammeBredde, AfstandFraTop);// Saetter cursoren til at lave top hoejre hjoerne
            Console.WriteLine('\x2510'); // Top hoejre hjoerne
            Console.SetCursorPosition(AfstandFraVenstre, AfstandFraTop); // Saetter cursoren til at lave top venstre hjoerne
            Console.WriteLine('\x250c'); // Top venstre hjoerne
            //Console.SetCursorPosition(30, 3);
            //Console.WriteLine("a");
            //----------------------------------------------------------------------------------------------------------------------------------------------------------------
            //Laver nederste linie i boxen------------------------------------------------------------------------------------------------------------------------------------
            for (int i = 0; i < RammeBredde; i++)
            {
                Console.SetCursorPosition(AfstandFraVenstre + i, AfstandFraTop + RammeHoejde); // Saetter cursoren til at lave nedre linie
                Console.WriteLine('\x2500'); // Top linie
            }
            Console.SetCursorPosition(AfstandFraVenstre + RammeBredde, AfstandFraTop + RammeHoejde);// Saetter cursoren til at lave top hoejre hjoerne
            Console.WriteLine('\x2518'); // nedre hoejre hjoerne
            Console.SetCursorPosition(AfstandFraVenstre, AfstandFraTop + RammeHoejde); // Saetter cursoren til at lave nedre venstre hjoerne
            Console.WriteLine('\x2514'); // nedre venstre 

            //----------------------------------------------------------------------------------------------------------------------------------------------------------------
            //Laver siderne i boxen-------------------------------------------------------------------------------------------------------------------------------------------
            for (int i = 1; i < RammeHoejde; i++)
            {
                Console.SetCursorPosition(AfstandFraVenstre, AfstandFraTop + i);
                Console.WriteLine('\x2502');
                Console.SetCursorPosition(AfstandFraVenstre + RammeBredde, AfstandFraTop + i);
                Console.WriteLine('\x2502');
            }
            //----------------------------------------------------------------------------------------------------------------------------------------------------------------
            Console.SetCursorPosition(AfstandFraVenstre + (RammeBredde/2)-(navn.Length/2), AfstandFraTop + (RammeHoejde / 2));
            Console.WriteLine(navn);
            Console.SetCursorPosition(1, AfstandFraTop+RammeHoejde+2);

        }
        public void Opgave9()
        {//Opretter variabler til skabelse af ramme---------------------------------------------------------------------------------------------------------------------------
            int RammeBredde=0;
            int RammeHoejde=0;
            int AfstandFraTop=0;
            int AfstandFraVenstre=0;
            string Navn;
            string ModtagetTal;
            int LangtNavn=0;
            //----------------------------------------------------------------------------------------------------------------------------------------------------------------
            Console.WriteLine("Indtast venligst dit navn, og tryk enter.");
            Navn = Console.ReadLine();
            Console.Clear();
            // Brugeren indtaster rammens start fra toppen af vinduet.--------------------------------------------------------------------------------------------------------
            do
            {
                Console.WriteLine("Indtast venligst rammens startposition fra toppen af vinduet, og tryk enter.");
                ModtagetTal = Console.ReadLine();
                Console.Clear();
                if (Int32.TryParse(ModtagetTal, out AfstandFraTop));
                else
                {
                    Console.WriteLine("Indtastningen er ikke gylding, indtast venligst et tal, og tryk enter.");
                }

            } while (AfstandFraTop == 0);
            //----------------------------------------------------------------------------------------------------------------------------------------------------------------
            // Brugeren indtaster rammens start fra vemstre sode af vinduet.--------------------------------------------------------------------------------------------------
            do
            {
                Console.WriteLine("Indtast venligst rammens startposition fra venstre side af vinduet, og tryk enter.");
                ModtagetTal = Console.ReadLine();
                Console.Clear();
                if (Int32.TryParse(ModtagetTal, out AfstandFraVenstre)) ;
                else
                {
                    Console.WriteLine("Indtastningen er ikke gylding, indtast venligst et tal, og tryk enter.");
                }

            } while (AfstandFraVenstre == 0);
            //----------------------------------------------------------------------------------------------------------------------------------------------------------------
            // Brugeren indtaster rammens bredde.-----------------------------------------------------------------------------------------------------------------------------
            do
            {
                Console.WriteLine("Indtast venligst rammens bredde, tallet skal være mindst 4, og tryk enter.");
                ModtagetTal = Console.ReadLine();
                Console.Clear();
                if (Int32.TryParse(ModtagetTal, out RammeBredde)) ;
                else
                {
                    Console.WriteLine("Indtastningen er ikke gylding, indtast venligst et tal, og tryk enter.");
                }

            } while (RammeBredde == 0);
            //----------------------------------------------------------------------------------------------------------------------------------------------------------------
            // Brugeren indtaster rammens hoejde.-----------------------------------------------------------------------------------------------------------------------------
            do
            {
                Console.WriteLine("Indtast venligst rammens højde, tallet skal være mindst 4, og tryk enter.");
                ModtagetTal = Console.ReadLine();
                Console.Clear();
                if (Int32.TryParse(ModtagetTal, out RammeHoejde)) ;
                else
                {
                    Console.WriteLine("Indtastningen er ikke gylding, indtast venligst et tal, og tryk enter.");
                }

            } while (RammeHoejde <= 3);
            //----------------------------------------------------------------------------------------------------------------------------------------------------------------
            // Denne kode sikre at navnet altid kan passe i rammen, hvis rammen er for smal, goeres den stoere.
            if(Navn.Length > RammeBredde)
            {
                LangtNavn = Navn.Length - RammeBredde +3;
            }
            //----------------------------------------------------------------------------------------------------------------------------------------------------------------
            //Laver oeverste linie i boxen------------------------------------------------------------------------------------------------------------------------------------

            for (int i = 0; i < RammeBredde+LangtNavn; i++)
            {
                Console.SetCursorPosition(AfstandFraVenstre + i, AfstandFraTop); // Saetter cursoren til at lave top linie
                Console.WriteLine('\x2500'); // Top linie

            }
            Console.SetCursorPosition(AfstandFraVenstre + RammeBredde+LangtNavn, AfstandFraTop);// Saetter cursoren til at lave top hoejre hjoerne
            Console.WriteLine('\x2510'); // Top hoejre hjoerne
            Console.SetCursorPosition(AfstandFraVenstre, AfstandFraTop); // Saetter cursoren til at lave top venstre hjoerne
            Console.WriteLine('\x250c'); // Top venstre hjoerne
            //Console.SetCursorPosition(30, 3);
            //Console.WriteLine("a");
            //----------------------------------------------------------------------------------------------------------------------------------------------------------------
            //Laver nederste linie i boxen------------------------------------------------------------------------------------------------------------------------------------
            for (int i = 0; i < RammeBredde+LangtNavn; i++)
            {
                Console.SetCursorPosition(AfstandFraVenstre + i, AfstandFraTop + RammeHoejde); // Saetter cursoren til at lave nedre linie
                Console.WriteLine('\x2500'); // Top linie
            }
            Console.SetCursorPosition(AfstandFraVenstre + RammeBredde+LangtNavn, AfstandFraTop + RammeHoejde);// Saetter cursoren til at lave top hoejre hjoerne
            Console.WriteLine('\x2518'); // nedre hoejre hjoerne
            Console.SetCursorPosition(AfstandFraVenstre, AfstandFraTop + RammeHoejde); // Saetter cursoren til at lave nedre venstre hjoerne
            Console.WriteLine('\x2514'); // nedre venstre 

            //----------------------------------------------------------------------------------------------------------------------------------------------------------------
            //Laver siderne i boxen-------------------------------------------------------------------------------------------------------------------------------------------
            for (int i = 1; i < RammeHoejde; i++)
            {
                Console.SetCursorPosition(AfstandFraVenstre, AfstandFraTop + i);
                Console.WriteLine('\x2502');
                Console.SetCursorPosition(AfstandFraVenstre + RammeBredde+LangtNavn, AfstandFraTop + i);
                Console.WriteLine('\x2502');
            }
            //----------------------------------------------------------------------------------------------------------------------------------------------------------------
            //Søtter cursoren for at udskrive det indtastede navn, og yderligere udskrifter efter metoden er afsluttet.
            Console.SetCursorPosition(AfstandFraVenstre + (RammeBredde /2), AfstandFraTop + (RammeHoejde / 2));
            Console.WriteLine(Navn);
            Console.SetCursorPosition(1, AfstandFraTop + RammeHoejde + 2);

        }
    }
}
