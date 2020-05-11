using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bøger
{
    class Bog
    {
        public void PrintInfo() // Metode der udskriver tekst
        {
            Console.WriteLine("Jeg er en bog.");
        }
        //---------------------------------------------------------------------------------------------------------------------------------------------------------------------
        //---------------------------------------------------------------------------------------------------------------------------------------------------------------------
        public bool HarRaad(int Penge) // Metode der udregner om brugeren har raad til en bog.
        {
            bool HarRaadBool;

            if (Pris <= Penge) // Koere hvis brugeren har raad til bogen
            {
                HarRaadBool = true;
            }
            else // Koere hvis brugeren ikke har raad til bogen.
            {
                HarRaadBool = false; 
            }
            return HarRaadBool; // Returnere en bool vaerdi, om hvorvidt brugeren har raad til en bog.
        }
        //---------------------------------------------------------------------------------------------------------------------------------------------------------------------
        //---------------------------------------------------------------------------------------------------------------------------------------------------------------------
        public string Title = "Sherlock Holmes"; // Instansvariable for titlen paa bogen
        public double Pris =150; // Instanasvariable for prisen paa bogen.
        
        public Bog(string Title, double Pris)
        {
            this.Title = Title;
            this.Pris = Pris;
            
        }
        public Bog(double Pris)
        {
            this.Pris = Pris;

        }
    }
}
