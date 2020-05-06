using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Uge1__Opgave1_Menu
{
    class Program
    {
        static void Main(string[] args)
        {
            bool EndCode = false;
            char InputSelectedApproved;
            do
            {
              MainMenu Hovedmenu = new MainMenu(); // Skaber en genvej for metoden for hovedmenuen
                VariableSubmenu VariableMenu = new VariableSubmenu(); // Skaber en genvej for metoden for undermenuen for variabler opgaverne
                StringSubmenu StringMenu = new StringSubmenu(); //Skaber en genvej for metoden for undermenuen for string opgaverne
                AritmetiskeUdtrykFull AritmeUdtryk = new AritmetiskeUdtrykFull(); // Skaber en genvej for menuen og opgaven for Aritmetiske udtryk, de er samlet fordi der kun er 1 opgave
                VariablerUdtrykSubmenu VariableUdtrykMenu = new VariablerUdtrykSubmenu(); // Skaber en genvej til menuen for Variabler i udtryk
                BoolskeVariableFull BoolskeVariableMenu = new BoolskeVariableFull(); // Skaber en genvej for menuen og opgaven for Boolske Variabler
                IfElseSubmenu IfElseMenu = new IfElseSubmenu(); // Skaber en genvej til menuen for if else statements
                SwitchCaseFull SwitchCaseMenu = new SwitchCaseFull(); // Opretter en genvej for menuen for switch case
                LoopsSubmenu LoopMenu = new LoopsSubmenu(); // Opretter en genveh til menuen for loops



                Hovedmenu.MenuTekst(); // Kalder paa metoden for tekst til hovedmenu
               int InputSelected = Hovedmenu.MenuInput(); // Kalder paa metoden for valg af kategori i hovedmenuen
                Console.WriteLine(InputSelected);
                // Switch case til at udfoere brugerens valgt kode.
                switch (InputSelected)
                {
                    case 'V': // Kategori for variabler
                        VariableMenu.VariableHovedmenu();
                        continue;

                    case 'S': // Kategori for strings
                        StringMenu.StringHovedmenu();
                        continue;

                    case 'A': // kategori for aritmetiske udtryk
                        AritmeUdtryk.AritmetiskeUdtrykHovedmenu();
                        continue;

                    case 'T': // Kategori for Variabler i udtryk
                        VariableUdtrykMenu.VariablerUdtrykHovedmenu();
                        continue;

                    case 'B': // Kategori for boolske variabler
                        BoolskeVariableMenu.BoolskeVariableHovedmenu();
                        continue;

                    case 'I': // Kategori for if else statements
                        IfElseMenu.IfElsekHovedmenu();
                        continue;

                    case 'C':
                        SwitchCaseMenu.SwitchCaseHovedmenu();
                        continue;

                    case 'L':
                        LoopMenu.LoopHovedmenu();
                        continue;

                    case 'Q':
                        Environment.Exit(0);
                        break;
                    default:
                        continue;

                }






            } while (EndCode== false);
        }
    }
}
