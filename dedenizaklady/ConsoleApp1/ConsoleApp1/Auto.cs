using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Auto
    {
        public string Nazev { get; private set; }
        public float Spotreba { get; private set; }
        public int MaxRychlost { get; private set; }

        public Auto(string nazev, float spotreba, int maxRychlost)
        {
            Nazev = nazev;
            Spotreba = spotreba;
            MaxRychlost = maxRychlost;
        }

        public void Jizda()
        {
            Console.WriteLine("Auto dělá vrm vrm");
        }
    }
}
