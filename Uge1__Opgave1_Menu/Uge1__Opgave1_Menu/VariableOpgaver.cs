using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uge1__Opgave1_Menu
{
    class VariableOpgaver
    {public (int, int) Opgave1()
        { //Opretter og tildeler tal til udskrift
            int Tal1 = 5;
            int Tal2 = 3;
            //----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
            // Udskriver variabler til konsollen
            Console.WriteLine(Tal1);
            Console.WriteLine(Tal2);
            //----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
            
            return (Tal1, Tal2); // Returnere 2 variabler til kalderen

        }
        public void Opgave2()
        {
            var (Tal1, Tal2) = Opgave1(); // Kalder paa metoden for "Opgave1" og modtager variablerne "Tal1" og "Tal2"
            Console.Clear();
            Console.WriteLine("Tal1 er {0}",Tal1); //Udskriver en variable samlet med tekst
            Console.WriteLine("Tal2 er {0}", Tal2);//Udskriver en variable samlet med tekst

        }
        //----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        public void Opgave3()
        {
            string Navn = "Søren"; //Opretter og tildeler variablen for "navn"
            int Alder = 16; //Opretter og tildeler variablen for "alder"
            double Penge = 1234.34; // Opretter og tildeler variablen for "penge"
            Console.WriteLine("Jeg hedder {0}, er {1} år gammel og har tjent {2} kr. på at lappe cyker",Navn,Alder,Penge); //Udskriver tekst samlet med variabler

        }
        //----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        public void Opgave4()
        {
            double Kage = 23.56; //Opretter og tildeler variablen for prisen paa kage
            double Oel = 34.67; //Opretter og tildeler variablen for prisen paa oel
            double Poelse = 65.34; //Opretter og tildeler variablen for prisen paa poelse
            Console.WriteLine("Kage: \t {0}",Kage); // Udskriver prisen for kage
            Console.WriteLine("Øl: \t {0}",Oel); // Udskriver prisen for oel
            Console.WriteLine("Pølse: \t {0}",Poelse); // Udskriver prisen for poelse
            Console.WriteLine("I alt: \t {0}",Kage+Oel+Poelse); // Udskriver prisen for den samlede bestilling
        }
        //----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        public void Opgave5()
        {
            bool InputApproved = false; // Variabel for at tjekke om brugerens input er godkendt
            string Navn; // Variabel for brugerens navn
            string AlderCheck; // Variabel for at tjekke brugerens alder
            int Alder; // Variabel for brugerens alder
            string BrugerOprettet = "Du er nu oprettet i systemet"; // Variable med tekst for brugerens oprettelse
            do
            {
                Console.WriteLine("Indtast venligst dit navn, og tryk enter."); // Udskriver information til brugeren
                Navn = Console.ReadLine(); //Modtager brugerens indtastning, og tildeler den til variabel for navn
                Console.Clear(); //Renser skaermen
                if(Navn.Length < 2) //Tjekker navnets laengde
                {
                    Console.WriteLine("Navnet er ikke gyldigt, prøv igen."); //Udskrift hvis brugerens indtastede navn er for kort
                }
            } while (Navn.Length < 2); //sikre at koden koere intil et navn med gyldigt laenge  er indtastet
            do
            {
                Console.WriteLine("Indtast venligst din alder, og tryk enter."); // Udskriver information til brugeren
                AlderCheck = Console.ReadLine(); // Modtager brugerens indtastede alder i en string, for at undgå nedbrydning ved fejlindtastning
                Console.Clear(); 
                if(int.TryParse(AlderCheck, out Alder) == true) //tjekker om brugerens indtastede alder kan konverteres til en integer, hvis den kan, konverteres den
                {
                    if(Alder < 0) // Tjekker om brugerens indtastede alder er under 0 aar.
                    {
                        Console.WriteLine("Dette er umuligt, prøv venligst igen.");
                    }
                    else if (Alder >= 0 && Alder <18) // Tjekker om brugerens alder er under den 18 aar
                    {
                        Console.WriteLine(BrugerOprettet);
                        Console.WriteLine("Da du ikke er myndig, er du underlagt forældrekontrol.");
                        InputApproved = true; // Indikere til looped at det kan stoppe
                    }
                    else if (Alder >= 18) //tjekker om brugerens alder er over 18 aar
                    {
                        Console.WriteLine(BrugerOprettet);
                        InputApproved = true; // Indikere til loopet at det kan stoppe
                    }
                    else // Sikkerhedsnet i tilfaelde at der kan forekomme en fejl jeg ikke har forudset
                    {
                        Console.WriteLine("Fejl, prøv igen.");
                    }
                }
                else // Sikkerhedsnet hvis brugerens indtastede alder ikke er et tal.
                {
                    Console.WriteLine("De indtastede oplysninger er ikke gyldige, prøv igen.");
                }
            } while (InputApproved == false); // Sikre at looped koere indtil at brugeren har indtastet alt korrekt
            Console.WriteLine("Jeg hedder {0} og er {1} år gammel.",Navn,Alder); //Udskriver tekst med variabler

        }
        //----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        public void Opgave6()
        {
            double Radius; // Opretter variable til at indholde brugerens indtastning for radius af en cirkel
            Console.WriteLine("Her kan du udrenge arealet af en cirkel.");
            Console.WriteLine("Indtast venligst radius på den cirkel du vil udregne i cm.");
            Radius = Convert.ToDouble(Console.ReadLine()); // Brugeren indtaster radius af den cirkel de vil udregne, og indtastningen gemmes i variabled "Radius"
            Console.WriteLine("Arealet på cirklen er: {0} cm", Math.PI*Math.Pow(Radius,2)); // Radius udregnes, og saettes ind i en tekst


        }
    }
}
