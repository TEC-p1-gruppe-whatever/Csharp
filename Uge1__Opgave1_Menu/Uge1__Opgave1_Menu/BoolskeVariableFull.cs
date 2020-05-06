using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uge1__Opgave1_Menu
{
    class BoolskeVariableFull
    {
        public void BoolskeVariablekHovedmenuTekst()
        {
            Console.WriteLine("Velkommen til Boolske Variable submenuen, her kan du se opgaven vedlagt i kategorien Boolske Variable."); //Udskriver information omkring menuen
            Console.WriteLine("1: \t Opgave 1");
            Console.WriteLine("q: \t Til hovedmenu");

        }
        public (int, bool) SubmenuBoolskeVariableSelection()
        {
            bool InputApproved = false; // variable til at sikre at koden kun fuldføres, hvis brugerens indtastning er gyldig
            int SubmenuSelected = 0; // Variabel til retur, som indikere hvad brugeren har indtastet
            string InputQuit; //variabel til at modtage brugerens input, omkring hvorvidt de oensker at afslutte menuen
            bool MenuFaerdigSub = false; //variable til at videregive om brugeren oensker at afslutte
            do
            {
                BoolskeVariablekHovedmenuTekst(); // Udføre koden, som skriver menuteksten for menuen
                ConsoleKeyInfo SubmenuSelection = Console.ReadKey(); //Modtager brugerens input
                if (Char.IsDigit(SubmenuSelection.KeyChar)) //Tjekker om modtaget input er et tal, hvis det er et tal, køre if-saetningen.
                {
                    SubmenuSelected = int.Parse(SubmenuSelection.KeyChar.ToString()); //Convertere det modtagede input, og gemmer den i en int.
                    if (SubmenuSelected == 1) //Tjekker om variablens nummer er 1, da der kun er 1 opgave at vælge.
                    { InputApproved = true; } //Erklære at kravet for loopet er opfyldt, så det kan stoppe.

                }
                else if (Char.IsLetter(SubmenuSelection.KeyChar))
                {
                    InputQuit = SubmenuSelection.KeyChar.ToString();
                    InputQuit.ToUpper();
                    if (InputQuit == "Q" || InputQuit == "q") // Tjekker om indtastningen er at afslutte menuen
                    {
                        InputApproved = true; // aendre variable til at indikere at looped skal afslutte
                        MenuFaerdigSub = true; // aendre variable til at indikere at den kaldende menu skal afslutte
                    }


                }
                Console.Clear(); //Renser skærmen for hvert forsøg, så det ikke bliver fyldt op

            } while (InputApproved == false);

            return (SubmenuSelected, MenuFaerdigSub); // Returnere brugerens valg, til den spørgende kode.
        }
        public void BoolskeVariableHovedmenu() //Metode for menuen for Aritmetiske Udtryk
        {
            bool MenuFaerdig = false; // variable til at sikre at koden køre indtil at brugeren ønsker at gå ud.
            do
            {


                Console.Clear();
                var (InputSelected, MenuFaerdigSub) = SubmenuBoolskeVariableSelection(); // Kalder metode, til at modtage brugerens indtastninger
                MenuFaerdig = MenuFaerdigSub; // opdateres om hvorvidt brugeren oensker at afslutte 
                switch (InputSelected)
                {
                    case 1:
                        Console.Clear();
                        Opgave1();
                        continue;
                    default:
                        continue;
                }
                

            } while (MenuFaerdig == false);

        }
        //---------------------------------------------------------------------------------------------------------------------------------------------------------------------
        public void Opgave1()
        {
            bool QuitApproved = false;
            Random Rnd = new Random();
            do
            {
                int Var1 = Rnd.Next(1, 11);
                int Var2 = Rnd.Next(1, 11);
                bool Bigger = Var1 > Var2;
                Console.WriteLine(Var1 + "\n" + Var2);
                Console.WriteLine(Bigger);
                Console.WriteLine("Tast: Q \t for at afslutte");
                Console.WriteLine("Tast anden vilkårlig tast for at fortsætte");
                Console.WriteLine("Færdig");
                ConsoleKeyInfo QuitInputTemp = Console.ReadKey();
                if (Char.IsLetter(QuitInputTemp.KeyChar))
                {
                    string QuitInput = QuitInputTemp.KeyChar.ToString();
                    if (QuitInput == "Q" || QuitInput == "q")
                    {
                        QuitApproved = true;

                    }
                }
                Console.Clear();
            } while (QuitApproved == false);
        }
        //---------------------------------------------------------------------------------------------------------------------------------------------------------------------
    }
}
