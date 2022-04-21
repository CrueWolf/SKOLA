using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Delfin : Zvire
    {
        public int Delka { get; private set; }
        public Delfin(string jmeno, int vaha, int delka) : base(jmeno, vaha)
        {
            Delka = delka;
        }

        public void Plav()
        {
            Console.WriteLine("Tvůj delfín plave");
            Console.ReadKey();
            Console.Clear();

        }
    }
}
