using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uge1__Opgave1_Menu
{
    class VariablerUdtrykSubmenu
    {
        public void VariablerUdtrykHovedmenuTekst()
        { //Udskriver tekst til brugeren, om den valgte menu
            Console.WriteLine("Velkommen til variabler i udtryk submenuen, her kan du se opgaver vedlagt i kategorien variabler i udtryk.");
            Console.WriteLine("1: \t Opgave 1");
            Console.WriteLine("2: \t Opgave 2");
            Console.WriteLine("q: \t Til hovedmenu");
            //-----------------------------------------------------------------------------------------------------------------------------------------
        }
        public (int, bool) SubmenuVariablerUdtrykSelection()
        {

            bool InputApproved = false; // Opretter variable til at indikere om brugerens indtastning er godkendt, er som standard paa "false"
            bool MenuFaerdigSub = false; // Opretter variable til at indikere om brugeren oensker at afslutte menuen, er som standard paa "false"
            int SubmenuSelected = 0; // Opretter variable til at indikere brugerens valg af opgave, er som standard paa "0" for at sikre et retursvar
            string InputQuit; // Opretter variable til at modtage brugerens input, hvis det er et bogstav, for at kontrollere om brugeren oensker at afslutte
            do
            {
                ConsoleKeyInfo SubmenuSelection = Console.ReadKey(); // Modtager brugerens indtastning
                // Kontrollere om brugerens indtastning er et tal, hvis det er koere if saetningen
                if (Char.IsDigit(SubmenuSelection.KeyChar))
                {
                    SubmenuSelected = int.Parse(SubmenuSelection.KeyChar.ToString()); // Konvertere brugerens input, til en integer
                    if (SubmenuSelected <= 2 && SubmenuSelected > 0) // Kontrollere om brugerens valg er indenfor de mulige valgmuligheder
                    { InputApproved = true; } //Hvis input er inden for de mulige valgmuligheder, indekeres at loopet kan afslutte.
                }
                //-----------------------------------------------------------------------------------------------------------------------------------------------
                //Hvis brugerens input er et bogstav, koere if else saetningen
                else if (Char.IsLetter(SubmenuSelection.KeyChar))
                {
                    InputQuit = SubmenuSelection.KeyChar.ToString(); // Konvertere brugerens input til en string
                    if (InputQuit == "Q" || InputQuit == "q") // Tjekker om indtastningen er at afslutte menuen
                    {
                        InputApproved = true; // aendre variable til at indikere at looped skal afslutte
                        MenuFaerdigSub = true; // aendre variable til at indikere at den kaldende menu skal afslutte
                    }
                }
                //---------------------------------------------------------------
                Console.Clear();

            } while (InputApproved == false); //Sikre at koden koere intil at brugerens indtastning er godkendt

            return (SubmenuSelected, MenuFaerdigSub); // Returnere variablerne til den kaldende metode
        }
        public void VariablerUdtrykHovedmenu()
        {
            bool MenuFaerdig = false;
            do
            {

                VariablerUdtrykOpgaver Opgaver = new VariablerUdtrykOpgaver();
                Console.Clear();
                VariablerUdtrykHovedmenuTekst();
                var (InputSelected, MenuFaerdigSub) = SubmenuVariablerUdtrykSelection(); // Kalder metode, til at modtage brugerens indtastninger
                MenuFaerdig = MenuFaerdigSub; // opdateres om hvorvidt brugeren oensker at afslutte menuen
                // Switch case til at koere brugerens valgte opgave.
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
                    default:
                        continue;
                }
                

            } while (MenuFaerdig == false); //Sikre at koden koere indtil at brugeren oensker at afslutte

        }
    }
}
