using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moebler
{
    class Computer : Furniture
    {
        string Gpu;
        string Cpu;
        string Motherboard;
        string Ram;
        string Hukommelse;

        public void SetGpu(string Gpu)
        {
            this.Gpu = Gpu;
        }
        public string GetGpu()
        {
            return Gpu;
        }
        public void SetCpu(string Cpu)
        {
            this.Cpu = Cpu;
        }
        public string GetCpu()
        {
            return Cpu;
        }
        public string GetMotherboard()
        {
            return Motherboard;
        }
        public void SetMotherboard(string Motherboard)
        {
            this.Motherboard = Motherboard;
        }
        public string GetRam()
        {
            return Ram;
        }
        public void SetRam(string Ram)
        {
            this.Ram = Ram;
        }
        public void SetHukommelse(string Hukommelse)
        {
            this.Hukommelse = Hukommelse;
        }
        public string GetHukommelse()
        {
            return Hukommelse;
        }
        public void PrintInfo()
        {
            Console.WriteLine("[PC] "+Manufacturer+" - "+Gpu+" - "+Cpu+" - "+Motherboard+" - "+Ram+" - "+Hukommelse+" - "+Cost+" kr.");
        }

    }
}
