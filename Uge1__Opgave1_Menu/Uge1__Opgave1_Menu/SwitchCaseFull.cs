using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Uge1__Opgave1_Menu
{
    class SwitchCaseFull
    {
        public void SwitchCaseHovedmenuTekst()
        {
            Console.WriteLine("Velkommen til Swithc Case submenuen, her kan du se opgaven vedlagt i kategorien Switch Case."); //Udskriver information omkring menuen
            Console.WriteLine("1: \t Opgave 1");
            Console.WriteLine("2. \t Opgave 2");
            Console.WriteLine("q: \t Til hovedmenu");

        }
        public (int, bool) SubmenuSwitchCaseSelection()
        {
            bool InputApproved = false; // variable til at sikre at koden kun fuldføres, hvis brugerens indtastning er gyldig
            int SubmenuSelected = 0; // Variabel til retur, som indikere hvad brugeren har indtastet
            string InputQuit; //variabel til at modtage brugerens input, omkring hvorvidt de oensker at afslutte menuen
            bool MenuFaerdigSub = false; //variable til at videregive om brugeren oensker at afslutte
            do
            {
                SwitchCaseHovedmenuTekst(); // Udføre koden, som skriver menuteksten for menuen
                ConsoleKeyInfo SubmenuSelection = Console.ReadKey(); //Modtager brugerens input
                if (Char.IsDigit(SubmenuSelection.KeyChar)) //Tjekker om modtaget input er et tal, hvis det er et tal, køre if-saetningen.
                {
                    SubmenuSelected = int.Parse(SubmenuSelection.KeyChar.ToString()); //Convertere det modtagede input, og gemmer den i en int.
                    if (SubmenuSelected >= 1 && SubmenuSelected <= 2) //Tjekker om variablens nummer er 1, da der kun er 1 opgave at vælge.
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
        public void SwitchCaseHovedmenu() //Metode for menuen for Aritmetiske Udtryk
        {
            bool MenuFaerdig = false; // variable til at sikre at koden køre indtil at brugeren ønsker at gå ud.
            do
            {


                Console.Clear();
                var (InputSelected, MenuFaerdigSub) = SubmenuSwitchCaseSelection(); // Kalder metode, til at modtage brugerens indtastninger
                MenuFaerdig = MenuFaerdigSub; // opdateres om hvorvidt brugeren oensker at afslutte 
                switch (InputSelected)
                {
                    case 1:
                        Console.Clear();
                        Opgave1();
                        continue;

                    case 2:
                        Console.Clear();
                        Opgave2();
                        Console.Clear();
                        continue;
                    default:
                        continue;
                }


            } while (MenuFaerdig == false);

        }
        //---------------------------------------------------------------------------------------------------------------------------------------------------------------------
    public void Opgave1()
        {
            bool InputApproved = false;
            string ModtagetTal;
            int Tal1=0;
            /* Console.WriteLine("Velkommen til opgaven, indtast venligst et tal mellem 1 og 6, begge tal inklusiv.");
             ModtagetTal = Console.ReadLine();
             Int32.TryParse(ModtagetTal, out Tal1);*/
            //´-------------------------------------------------------------------------------------------------------------------
            do
            {
                Console.WriteLine("Velkommen til opgaven, indtast venligst et tal mellem 1 og 6, begge tal inklusiv.");
                ConsoleKeyInfo SubmenuSelection = Console.ReadKey(); //Modtager brugerens indtastning, til at afgoere deres oensker
                if (Char.IsDigit(SubmenuSelection.KeyChar)) // tjekker om brugerens indtastning er et tal
                {// Hvis brugerens indtastning er et tal, koere denne kode
                    Tal1 = int.Parse(SubmenuSelection.KeyChar.ToString()); // Brugerens indtastning, bliver omdannet til en integer.
                    { InputApproved = true; } // Hvis indtastningen er indenfor de mulige valgmuligheder, indikeres der at indtastningen er godkendt, og koden ikke skal koere igen

                }
                //--------------------------------------------------------------------------------------------------------------------------
                Console.Clear();

            } while (InputApproved == false); // diktere at looped skal koere indtil at indtastningen er godkendt
                                              //--------------------------------------------------------------------------------------------------------------------
            switch (Tal1)
            {
                case 1:
                case 2:
                case 3:
                case 5:
                case 6:
                    for (int i = 5; i > 0; i--) 
                    {
                        Console.WriteLine("Du har tastet {0}", Tal1); // Det tal brugeren har indtastet
                        Console.Write("Programmet går til menuen om: {0} sekunder", i); // Den tid der er tilbage til at koden gaar videre
                        System.Threading.Thread.Sleep(1000); //Den tid koden skal vente
                        Console.Clear(); 
                    }
                    
                    break;
                case 4:
                    Console.ForegroundColor = ConsoleColor.White; // Saetter teksten som hvid
                    // Loop der faar skaermen til at blinke i farver.---------------------------------------------
                    for (int i = 0; i < 4; i++)
                    {
                        
                        
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.Clear();
                        Console.SetCursorPosition(Console.WindowWidth / 2, Console.WindowHeight / 2);
                        Console.WriteLine("TILLYKKE DU HAR VUNDET");
                        System.Threading.Thread.Sleep(1000);
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.Clear();
                        Console.SetCursorPosition(Console.WindowWidth / 3, Console.WindowHeight / 2);
                        Console.WriteLine("TILLYKKE DU HAR VUNDET");
                        System.Threading.Thread.Sleep(1000);

                    }
                    //------------------------------------------------------------------------------------------
                    Console.BackgroundColor = ConsoleColor.Black;
                    break;
                default:
                    for (int i = 10; i > 0; i--)
                    {
                        Console.Write("Du har indtasted forkert, indtastningen skal være et tall mellem 1 og 6, programmet går til menuen om: {0}",i);
                        System.Threading.Thread.Sleep(1000);
                        Console.Clear();
                    }
                    break;
                    
            }

        }
        public void Opgave2()
        {
            Random Rnd = new Random();
            bool InputApproved = false;
            string InputQuit;
            int ValgteKob=0;
            double IsnjornPris =Rnd.Next(10, 20);
            double ChampagnebrusPris = Rnd.Next(13, 25);
            double TequilaSunrisePris = Rnd.Next(10, 20);
            double MojitoPris = Rnd.Next(13, 30);
            double BrandbilPris = Rnd.Next(15, 18);
            double FilurPris = Rnd.Next(5, 18);
            //-----------------------------------------------------------------------------------------------------------------------------------------
            do
            {
                //Udskriver tekst til brugeren, om den valgte menu
                Console.WriteLine("Velkommen til Købmanden, her kan du se vores store udvalg, at stærke produkter, til små priser. \n Tast nummeret for det produkt du ønsker.");
                Console.WriteLine("1: Isbjørn, pris: {0}",IsnjornPris);
                Console.WriteLine("2: Champagnebrus, pris: {0}",ChampagnebrusPris);
                Console.WriteLine("3: Tequila Sunrise, pris: {0}",TequilaSunrisePris);
                Console.WriteLine("4: Mojito, pris: {0}",MojitoPris);
                Console.WriteLine("5: Brandbil, pris: {0}",BrandbilPris);
                Console.WriteLine("6: Filur, pris: {0}",FilurPris);
                //-----------------------------------------------------------------------------------------------------------------------------------------
                ConsoleKeyInfo SubmenuSelection = Console.ReadKey(); // Modtager brugerens indtastning
                Console.Clear();
                // Kontrollere om brugerens indtastning er et tal, hvis det er koere if saetningen
                if (Char.IsDigit(SubmenuSelection.KeyChar))
                {
                    ValgteKob = int.Parse(SubmenuSelection.KeyChar.ToString()); // Konvertere brugerens input, til en integer
                    if (ValgteKob <= 6 && ValgteKob > 0) // Kontrollere om brugerens valg er indenfor de mulige valgmuligheder
                    { InputApproved = true; } //Hvis input er inden for de mulige valgmuligheder, indekeres at loopet kan afslutte.
                }
                //-----------------------------------------------------------------------------------------------------------------------------------------------
                //Hvis brugerens input er et bogstav, koere if else saetningen
                else if (Char.IsLetter(SubmenuSelection.KeyChar))
                {

                    Console.Clear();
                    Console.WriteLine("Du skal indtaste et tal, prøv igen, og tryk enter.");
                }
                //---------------------------------------------------------------
                
            } while (InputApproved == false); //Sikre at koden koere intil at brugerens indtastning er godkendt
            Console.Clear();

            for (int i = 0; i < 1; i++)
            {
                switch (ValgteKob)
                {
                    case 1:
                        Console.WriteLine("Du har valgt at købe en Isbjørn, prisen er: {0} kr.", IsnjornPris);
                        Console.WriteLine("Fortsætter til opgavemenuen, vent venligst.");
                        System.Threading.Thread.Sleep(5000);

                        break;

                    case 2:
                        Console.WriteLine("Du har valgt at købe en Champagnebrus, prisen er: {0} kr.", ChampagnebrusPris);
                        Console.WriteLine("Fortsætter til opgavemenuen, vent venligst.");
                        System.Threading.Thread.Sleep(5000);
                        break;

                    case 3:
                        Console.WriteLine("Du har valgt at købe en Tequila Sunrise, prisen er: {0} kr.", TequilaSunrisePris);
                        Console.WriteLine("Fortsætter til opgavemenuen, vent venligst.");
                        System.Threading.Thread.Sleep(5000);
                        break;

                    case 4:
                        Console.WriteLine("Du har valgt at købe en Mojito, prisen er: {0} kr.", MojitoPris);
                        Console.WriteLine("Fortsætter til opgavemenuen, vent venligst.");
                        System.Threading.Thread.Sleep(5000);
                        break;

                    case 5:
                        Console.WriteLine("Du har valgt at købe en brandbil, prisen er: {0} kr.", BrandbilPris);
                        Console.WriteLine("Fortsætter til opgavemenuen, vent venligst.");
                        System.Threading.Thread.Sleep(5000);
                        break;

                    case 6:
                        Console.WriteLine("Du har valgt at købe en Filur, prisen er: {0} kr.", FilurPris);
                        Console.WriteLine("Fortsætter til opgavemenuen, vent venligst.");
                        System.Threading.Thread.Sleep(5000);
                        break;
                    default:
                        continue;

                }            
            }      
            
        }
    }
    
}
