using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Netopyr : Zvire
    {
        public string KrevniSkupina { get; private set; }
        public Netopyr (string jmeno, int vaha, string krevniskupina) : base (jmeno, vaha)
        {
            KrevniSkupina = krevniskupina;
        }

        public void SaniKrve()
        {
            Console.WriteLine("Netopýr saje krev nepřítele z očí");
            Console.ReadKey();
            Console.Clear();


        }
    }
}
