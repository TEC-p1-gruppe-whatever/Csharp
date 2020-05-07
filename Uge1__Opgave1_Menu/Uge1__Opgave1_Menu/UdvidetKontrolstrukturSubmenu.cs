using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uge1__Opgave1_Menu
{
    class UdvidetKontrolstrukturSubmenu
    {
        public void UdvidetKontrolstrukturHovedmenuTekst()
        {// Tekst til brugeren om de forskellige opgaver
            Console.WriteLine("Velkommen til Udvidet Kontrolstruktur submenuen, her kan du se opgaver vedlagt i kategorien Udvidet Kontrolstruktur.");
            Console.WriteLine("1: \t Opgave 1");
            Console.WriteLine("2: \t Opgave 2");
            Console.WriteLine("3: \t Opgave 3");
            Console.WriteLine("4: \t Opgave 4");
            Console.WriteLine("5: \t Opgave 5");
            Console.WriteLine("q: \t Til hovedmenu");
            //-------------------------------------------------------------------------------------------------------------------------

        }
        public (int, bool) SubmenuUdvidetKontrolstrukturSelection()
        {
            bool InputApproved = false; // variable til at indikere om brugerens indtastning er gyldig
            int SubmenuSelected = 0; // variable til at videregive information til den kaldende metode, om brugerens valg
            string InputQuit; //variabel til at modtage brugerens input, omkring hvorvidt de oensker at afslutte menuen
            bool MenuFaerdigSub = false; //variable til at videregive om brugeren oensker at afslutte
            do
            {
                UdvidetKontrolstrukturHovedmenuTekst();
                ConsoleKeyInfo SubmenuSelection = Console.ReadKey(); //Modtager brugerens indtastning, til at afgoere deres oensker
                if (Char.IsDigit(SubmenuSelection.KeyChar)) // tjekker om brugerens indtastning er et tal
                {// Hvis brugerens indtastning er et tal, koere denne kode
                    SubmenuSelected = int.Parse(SubmenuSelection.KeyChar.ToString()); // Brugerens indtastning, bliver omdannet til en integer.
                    if (SubmenuSelected <= 5 && SubmenuSelected > 0) // Tjekker om brugerens indtastning, er indenfor de mulige valgmuligheder
                    { InputApproved = true; } // Hvis indtastningen er indenfor de mulige valgmuligheder, indikeres der at indtastningen er godkendt, og koden ikke skal koere igen

                }
                //--------------------------------------------------------------------------------------------------------------------------
                // Hvis brugerens indtastning er et bogstav, koere denne kode
                else if (Char.IsLetter(SubmenuSelection.KeyChar))
                {
                    InputQuit = SubmenuSelection.KeyChar.ToString(); // Indtastningen omdannes til en string
                    if (InputQuit == "Q" || InputQuit == "q") // Tjekker om indtastningen er at afslutte menuen
                    {
                        InputApproved = true; // aendre variable til at indikere at looped skal afslutte
                        MenuFaerdigSub = true; // aendre variable til at indikere at den kaldende menu skal afslutte
                    }


                }
                //-----------------------------------------------------------------------------------------------------------------------------------
                Console.Clear();

            } while (InputApproved == false); // diktere at looped skal koere indtil at indtastningen er godkendt

            return (SubmenuSelected, MenuFaerdigSub); // Returnere variabler til den kaldende metode
        }
        public void UdvidetKontrolstrukturHovedmenu()
        {
            bool MenuFaerdig = false; // variabel til at indikere om brugeren oensker at afslutte menuen
            do
            {

                UdvidetKontrolstrukturOpgaver Opgaver = new UdvidetKontrolstrukturOpgaver(); // opretter en genvej til menuens tilegnede opgaver
                Console.Clear();
                var (InputSelected, MenuFaerdigSub) = SubmenuUdvidetKontrolstrukturSelection(); // Kalder metode, til at modtage brugerens indtastninger
                MenuFaerdig = MenuFaerdigSub; // opdateres om hvorvidt brugeren oensker at afslutte 
                // Switch case til at kalde paa den opgave brugeren har indtastet
                switch (InputSelected)
                {
                    case 1:
                        Console.Clear();
                        Opgaver.Opgave1();
                        Console.WriteLine("Tryk på en vilkårlig tast for at fortsætte.");
                        Console.ReadKey();
                        Console.Clear();
                        continue;

                    case 2:
                        Console.Clear();
                        Opgaver.Opgave2();
                        Console.WriteLine("Tryk på en vilkårlig tast for at fortsætte.");
                        Console.ReadKey();
                        Console.Clear();
                        continue;

                    case 3:
                        Console.Clear();
                        ; Opgaver.Opgave3();
                        Console.WriteLine("Tryk på en vilkårlig tast for at fortsætte.");
                        Console.ReadKey();
                        Console.Clear();
                        continue;

                    case 4:
                        Console.Clear();
                        Opgaver.Opgave4();
                        Console.WriteLine("Tryk på en vilkårlig tast for at fortsætte.");
                        Console.ReadKey();
                        Console.Clear();
                        continue;

                    case 5:
                        Console.Clear();
                        Opgaver.Opgave5();
                        Console.WriteLine("Tryk på en vilkårlig tast for at fortsætte.");
                        Console.ReadKey();
                        Console.Clear();
                        continue;

                    default:
                        continue;
                }
                //----------------------------------------------------------------------------------------------------------------------------------------------

            } while (MenuFaerdig == false); //Sikre at koden koere indtil at brugeren oensker at afslutte

        }
    }
}
