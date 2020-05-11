using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Bil Mitsubishi = new Bil(); // Opreter genvej til klassen "Bil"
            Mitsubishi.MotorStart(); // Koere den specificerede metode i klassen "Bil"
            Mitsubishi.MotorSluk(); // Koere den specificerede metode i klassen "Bil"
            Mitsubishi.FillGas(2.5, true);
            double Gas = Mitsubishi.RemainingGas();
            Console.WriteLine(Gas);





            System.Threading.Thread.Sleep(5000); // Pausere programmet, for at give brugeren tid til at laese, for programmet slutter.
        }
    }
}
