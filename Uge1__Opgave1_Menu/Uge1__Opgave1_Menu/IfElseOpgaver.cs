using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uge1__Opgave1_Menu
{
    class IfElseOpgaver
    {
        public void Opgave1()
        {      // Opretter og tildeler variabler
            int Tal1 = 42;
            int Tal2 = 64;
            int Resultat = Tal1 + Tal2;
            //---------------------------------------------------------------------------------------
            // Tjekker vaerdien af variablen "Resultat" som er summen af "Tal1" og "Tal2"
            if (Resultat > 100)
            {
                Console.WriteLine("Summen er større end 100!");
            }
            else if (Resultat < 100)
            {
                Console.WriteLine("Summen er mindre en 100!");
            }
            else if (Resultat == 100)
            {
                Console.WriteLine("Summen er lige præcis 100!");
            }
            else
            {
                Console.WriteLine("FEJL!");
            }
            //------------------------------------------------------------------------------------------------------------------

        }
        //---------------------------------------------------------------------------------------------------------------------------------------------------------------------
        public void Opgave2()
        {
            string IndtastetAlder; // Opretter variable for modtagelse af brugerens alder
            int Alder; // Opretter variable for brugerens indtastede alder konverteret til integer
            bool Approved = false; // Opretter variable for sikring at brugeren indtaster godkendte oplysninger
            do
            {   // Brugeren indtaster sin alder, og den konverteres til en integer
                Console.WriteLine("Indtast venligst din alder, og tryk enter.");
                IndtastetAlder = Console.ReadLine();
                Alder = int.Parse(IndtastetAlder.ToString());
                //---------------------------------------------------------------------------------------------------------------------------
                //Tjekker om brugeren er over 57 aar, 
                if (Alder > 57)
                {
                    string Navn = Console.ReadLine();
                    Console.WriteLine("Du er {0} for gammel {1}.", Alder - 57, Navn);
                    break;
                }
                //---------------------------------------------------------------------------------------------------------------------------
                // Tjekker om brugeren er mellem 18 og 57 aar
                else if (Alder >= 18 && Alder <= 57)
                {
                    Console.WriteLine("Du er ikke for gammel.");
                    Approved = true;
                }
                //---------------------------------------------------------------------------------------------------------------------------
                // Tjekker om brugeren under 18 eller 6+ aar
                else if (Alder > 18 && Alder >= 6)
                {
                    Console.WriteLine("Du er ikke for gammel, meeeen du er nu også lidt ung.");
                    Approved = true;
                }
                //---------------------------------------------------------------------------------------------------------------------------
                // Tjekker om brugeren er født og under 6 aar.
                else if (Alder >= 0 && Alder < 6)
                {
                    Console.WriteLine("Du er ikke for gammel, men hvordan faen er det lykkedes for dig at registrere?");
                    Approved = true;
                }
                //---------------------------------------------------------------------------------------------------------------------------
                // Hvis ingen af de ovenstaaende er sande, reporteres fejl, og brugeren skal proeve igen.
                else
                {
                    Console.WriteLine("Fejl! Prøv igen.");
                }
                //---------------------------------------------------------------------------------------------------------------------------
            } while (Approved == false);



        }
        //---------------------------------------------------------------------------------------------------------------------------------------------------------------------
        public void Opgave3()
        {string IndtastetAlder; // Opretter variable for modtagelse af brugerens alder
            int Alder; // Opretter variable for brugerens indtastede alder konverteret til integer
            bool Approved = false; // Opretter variable for sikring at brugeren indtaster godkendte oplysninger
            do
            {   // Brugeren indtaster sin alder, og den konverteres til en integer
                Console.WriteLine("Indtast venligst din alder, og tryk enter.");
                IndtastetAlder = Console.ReadLine();
                Alder = int.Parse(IndtastetAlder.ToString());
                Console.Clear();
                //---------------------------------------------------------------------------------------------------------------------------
                //Tjekker om brugeren er over 60 aar, 
                if (Alder > 60)
                {
                    Console.WriteLine("Indtast venligst dit navn, og tryk enter.");
                    string Navn = Console.ReadLine();
                    Console.WriteLine("Du er {0} år for gammel {1}.", Alder - 60, Navn);
                    break;
                }
                //---------------------------------------------------------------------------------------------------------------------------
                // Tjekker om brugeren er mellem 50 og 60 aar
                else if (Alder >= 50 && Alder <=60)
                {
                    Console.WriteLine("Du er hverken for gammel eller for ung");
                    Approved = true;
                }
                //---------------------------------------------------------------------------------------------------------------------------
                // Tjekker om brugeren under 50 aar
                else if (Alder < 50)
                {
                    Console.WriteLine("Du er {0} år for ung.",50-Alder);
                    Approved = true;
                }
                //---------------------------------------------------------------------------------------------------------------------------
                // Hvis ingen af de ovenstaaende er sande, reporteres fejl, og brugeren skal proeve igen.
                else
                {
                    Console.WriteLine("Fejl! Prøv igen.");
                }
                //---------------------------------------------------------------------------------------------------------------------------
            } while (Approved == false);

        }
        //---------------------------------------------------------------------------------------------------------------------------------------------------------------------
        public void Opgave4()
        {   // Opretter variabler for brug i metoden
            int CorrectInput; // Til udregneing om brugernavn og password er korrekt.
            string Navn = "Torben"; // Brugerens navn
            string Brugernavn = "BAMSEFAR"; // Brugeren brugernavn
            string Password = "H04p1t4l"; // Brugerens password
            //---------------------------------------------------------------------------------------------------------------------------
            do
            {
                Console.Clear();
                CorrectInput = 0; // Nulstiller udregning for hver gang loopet koere
                // Udskriver de kraevede variabler, saa de er lette at finde for test og visning af program
                Console.WriteLine(Brugernavn);
                Console.WriteLine("Indtast venligst dit brugernavn, og tryk enter.");
                if (Brugernavn == Console.ReadLine().ToUpper()) // Brugeren indtaster sit brugernavn, det bliver konverteret till alle store bogstaver
                {
                    CorrectInput++;
                }
                Console.Clear();
                Console.WriteLine(Password);
                Console.WriteLine("Indtast venligst dit password, og tryk enter.");
                if(Password == Console.ReadLine()) // Brugeren indtaster sit password, til sammenlignign med det i den gemte variable
                {
                    CorrectInput++;
                }
                Console.Clear();
                if(CorrectInput < 2) // Hvis brugeren ikke har indtasted baade brugernavn og password korrekt, bliver dette oplyst, og de skal proeve igen, NOTE kan eventualt lave en vej ud af koden, i tilfaelde af at brugeren ikke kan huske brugernavn og password
                {
                    Console.WriteLine("Brugernavn eller password er fokert, tryk på en vilkårlig tast for at prøve igen.");
                    Console.ReadKey();
                }

            } while (CorrectInput <2 );
            Console.WriteLine("Velkommen {0}.",Navn);


        }
        //---------------------------------------------------------------------------------------------------------------------------------------------------------------------
        public void Opgave5()
        {
            // Opretter variabler for brug i metoden
            int CorrectInput; // Til udregneing om brugernavn og password er korrekt.
            string Navn = "Torben"; // Brugerens navn
            string Brugernavn = "BAMSEFAR"; // Brugeren brugernavn
            string Password = "H04p1t4l"; // Brugerens password
            //---------------------------------------------------------------------------------------------------------------------------
            
                Console.Clear();
                CorrectInput = 0; // Nulstiller udregning for hver gang loopet koere
                // Udskriver de kraevede variabler, saa de er lette at finde for test og visning af program
                do
                {
                    Console.WriteLine(Brugernavn);
                    Console.WriteLine("Indtast venligst dit brugernavn, og tryk enter.");
                    if (Brugernavn == Console.ReadLine().ToUpper()) // Brugeren indtaster sit brugernavn, det bliver konverteret till alle store bogstaver
                    {
                        CorrectInput++; // Pluser variablen med 1, for at indikere at indtastningen er korrekt
                    }
                    else
                    {
                        Console.WriteLine("Brugernavnet er fokert, tryk på en vilkårlig tast for at prøve igen."); //Brugerens indtastning er forket, de skal proeve igen
                        Console.ReadKey();
                    }
                    Console.Clear();

                } while (CorrectInput < 1); // Soerger for at loopet koere indtil indtastningen er gyldig
            do
            {
                Console.WriteLine(Password);
                Console.WriteLine("Indtast venligst dit password, og tryk enter.");
                if (Password == Console.ReadLine()) // Brugeren indtaster sit password, til sammenlignign med det i den gemte variable
                {
                    CorrectInput++; // Pluser variablen med 1, for at indikere at indtastningen er korrekt
                }
                else
                {
                    Console.WriteLine("Password er forket, tryk på en vilkårlig tast for at prøve igen."); //Brugerens indtastning er forket, de skal proeve igen
                    Console.ReadKey();
                }
                Console.Clear();

            } while (CorrectInput < 2); // Soerger for at loopet koere indtil indtastningen er gyldig
            Console.WriteLine("Velkommen {0}.",Navn);

        }
        //---------------------------------------------------------------------------------------------------------------------------------------------------------------------
        public void Opgave6()
        {
            string ModtagetKmPerDag;
            int KmPerDag =0;
            do
            {
                Console.WriteLine("Indtast venligst hvor mange kilometer du kære til og fra arbejde om dagen, i hele tal.");
                ModtagetKmPerDag = Console.ReadLine();
                int.TryParse(ModtagetKmPerDag, out KmPerDag);
                Console.Clear();
            } while (KmPerDag ==0);
            if(KmPerDag <= 24)
            {
                Console.WriteLine("Du får ikke noget fradrag.");
            }
            else if(KmPerDag >=25 && KmPerDag <= 120)
            {
                Console.WriteLine("Du får {0} kr. i fradrag om dagen.",(KmPerDag-24)*1.93);
            }
            else if(KmPerDag >= 121)
            {
                Console.WriteLine("Du får {0} kr. i fradrag om dagen.",(96*1.93+(KmPerDag-120)*0.97));

            }
        }
        //---------------------------------------------------------------------------------------------------------------------------------------------------------------------
        public void Opgave7()
        {
            // Opretter variabler til brug i koden------------------------
            string BaggrundsFarve;
            string ModtagetAlder;
            int Alder =0; 
            //------------------------------------------------------------

            Console.Title = "Festen"; //Aendre titlen paa konsolvinduet
            do // loop til at sikre at der bliver indtastet en gyldig farve.-----------------------------------
            {
                Console.WriteLine("Velkommen til festen,");
                Console.WriteLine("skriv venligst din ønskede baggrundsfarve, du kan vælge i mellem:");
                Console.WriteLine("rød grøn blå gul");
                BaggrundsFarve = Console.ReadLine();
                if (BaggrundsFarve.ToUpper() == "RØD")
                 {
                     BaggrundsFarve = "Red";
                     Console.BackgroundColor = ConsoleColor.Red;
                    Console.Clear();
                    break;
                }
                 else if (BaggrundsFarve.ToUpper() == "GRØN")
                 {
                     BaggrundsFarve = "Green";
                     Console.BackgroundColor = ConsoleColor.Green;
                    Console.Clear();
                    break;
                }
                 else if (BaggrundsFarve.ToUpper() == "BLÅ")
                 {
                    BaggrundsFarve = "Blue";
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.Clear();
                    break;
                }
                else if (BaggrundsFarve.ToUpper() == "GUL")
                {
                    BaggrundsFarve = "Yellow";
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.Clear();
                    break;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Indtastning ikke gyldig, prøv igen, og tryk enter.");
                }

            } while (BaggrundsFarve != "Red" || BaggrundsFarve != "Green" || BaggrundsFarve != "Blue" || BaggrundsFarve != "Yellow");
            //-----------------------------------------------------------------------------------------------------------------------------------------------------------------
            //Loop til at sikre at en gyldig alder bliver indtastet
            do
            {
                Console.WriteLine("Indtast venligst din alder, og tryk enter.");
                ModtagetAlder = Console.ReadLine();
                 Int32.TryParse(ModtagetAlder, out Alder);
                if(Alder > 0)
                {
                    if(Alder >= 18)
                    {
                        Console.Clear();
                        Console.WriteLine("Velkommen til cocktailbaren");
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Velkommen til sodavandsbaren");
                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Indtastningen er ugyldig, prøv igen, og tryk enter.");
                }

            } while (Alder <= 0);
            System.Threading.Thread.Sleep(10000);
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Title = "Konsol applikation";
            


        }
        

     
    }
}
