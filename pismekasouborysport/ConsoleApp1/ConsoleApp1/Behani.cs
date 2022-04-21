using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Behani
    {
        public string Km { get; private set; }
        public string Cas { get; private set; }
        public string Nazev { get; private set; }
        public DateTime Datum { get; private set; }

        public Behani ( string Km, string Cas, string Nazev, DateTime Datum)
        {
            Km = Km;
            Cas = Cas;
            Nazev = Nazev;
            Datum = Datum;
        }

        public void Info()
        {
            Console.WriteLine("Uběhnutá delka:" + Km);
            Console.WriteLine("Cas behu:"+ Cas);
            Console.WriteLine("Nazev trate:" + Nazev);
            Console.WriteLine("Datum behu:" + Datum);
        }
    }
}
