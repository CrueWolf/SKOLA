using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Nakladak : Auto
    {
        public int MaximalniNaklad { get; private set; }

        public Nakladak (string nazev, float spotreba, int maxRychlost, int maximalniNaklad) : base(nazev, spotreba, maxRychlost){
            MaximalniNaklad  = maximalniNaklad;

        }
        public void Otevreni()
        {
            Console.Write("Otvírám dveře od nákladního prostoru");
        }
        public void Zavreni()
        {
            Console.Write("Zavírám dveře od nákladního prostoru");
        }
    }
}
