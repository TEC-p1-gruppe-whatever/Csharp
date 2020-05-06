using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uge1__Opgave1_Menu
{
    public class MainMenu
    {   
        public void MenuTekst() { // Metode til at udskrive menuteksten for den kaldende metode
            // Information til brugeren omkring menuen
            Console.WriteLine("Velkommen til programmet, tast følgende taster for:");
            Console.WriteLine("V: \t Variabler");
            Console.WriteLine("S: \t Strings");
            Console.WriteLine("A: \t Aritmetiske Udtryk");
            Console.WriteLine("T: \t Variabler i udtryk");
            Console.WriteLine("B: \t Boolske variabler");
            Console.WriteLine("I: \t If-else statements");
            Console.WriteLine("C: \t Switch Case");
            Console.WriteLine("q: \t For at afslutte");
        }
        //----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        public char MenuInput()
        {
            bool EndCode = false;
            bool InputApproved = false; // Variable til at indikere om brugerens indtastning er gyldig
            char InputSelected = 'k'; // variabel til at indikere brugerens indtastning, allerede angivet, for at sikre at der altid returneres noget, for at koden ikke bryder sammen.
            do
            {

                
                
                ConsoleKeyInfo MainmenuOptionSelected = Console.ReadKey(); // Modtager brugerens indtastning
                Console.Clear();

               
                
                
                // Switch case til at vurdere brugerens indtastning, for at vaelge en kategori
                switch (MainmenuOptionSelected.KeyChar)
                {
                    case 'V':
                    case 'v':
                        InputApproved = true;
                        InputSelected = 'V';
                        break;
                    case 'S':
                    case 's':
                        InputApproved = true;
                        InputSelected = 'S';
                        break;
                    case 'A':
                    case 'a':
                        InputApproved = true;
                        InputSelected = 'A';
                        break;
                    case 'T':
                    case 't':
                        InputApproved = true;
                        InputSelected = 'T';
                        break;
                    case 'B':
                    case 'b':
                        InputApproved = true;
                        InputSelected = 'B';
                        break;
                    case 'I':
                    case 'i':
                        InputApproved = true;
                        InputSelected = 'I';
                        break;
                    case 'C':
                    case 'c':
                        InputApproved = true;
                        InputSelected = 'C';
                        break;
                    case 'L':
                    case 'l':
                        InputApproved = true;
                        InputSelected = 'L';
                        break;
                    case 'U':
                    case 'u':
                        InputApproved = true;
                        InputSelected = 'U';
                        break;
                    case 'Q':
                    case 'q':
                        InputApproved = true;
                        EndCode = true;
                        InputSelected = 'Q';
                        break;

                    default:
                        MenuTekst();
                        continue;
                }
                //------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

                
                Console.Clear();
            } while (InputApproved == false); // sikre at koden bliver ved med at koere, indtil at brugeren har indtastet en gyldig kategori
            return InputSelected; // Returnere brugerens indtastning

            







        }
    }
            
            
            
    
    
}
