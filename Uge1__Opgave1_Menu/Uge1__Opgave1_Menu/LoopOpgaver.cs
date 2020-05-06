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
            //Loop der udskriver en talraekke--------------------------------------
            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine(i);
                System.Threading.Thread.Sleep(200);
            }
            //---------------------------------------------------------------------
            int Tal1 = 1; // Opretter en integer, til at taelle med
            // Loop der udskriver en talraekke-------------------------------------
            while(Tal1 <= 10)
            {
                Console.WriteLine(Tal1);
                Tal1++;
                System.Threading.Thread.Sleep(200);
             }
            //---------------------------------------------------------------------
        }
        public void Opgave2()
        {
            //Loop der udskriver en talraekke--------------------------------------
            for (int i = 100; i > 0; i--)
            {
                Console.WriteLine(i);
                System.Threading.Thread.Sleep(100);
            }
            //---------------------------------------------------------------------
            int Tal1 = 100; // Opretter en integer, til at taelle med
            // Loop der udskriver en talraekke-------------------------------------
            while (Tal1 > 0)
            {
                Console.WriteLine(Tal1);
                Tal1--;
                System.Threading.Thread.Sleep(100);
            }
            //---------------------------------------------------------------------
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

        }
        public void Opgave5()
        {
            int x = 7;
            for (int i = 1; i < 11; i++)
            {
                
                Console.WriteLine("{0} * 7 = {1}",i,x);
                x = x + 7;
                System.Threading.Thread.Sleep(200);

            }

        }
        public void Opgave6()
        {

        }
        public void Opgave7()
        {

        }
    }
}
