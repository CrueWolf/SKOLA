using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    //class Osobak : !!AUTO!! -- dědění metod a atributů z auto//
    class Osobak : Auto
    {
        public int PocetMist { get; private set; }

        public Osobak (string nazev, float spotreba, int maxRychlost, int pocetMist): base(nazev, spotreba, maxRychlost{
            PocetMist = PocetMist;

        }
        public void OtevritKufr()
        {
            Console.WriteLine("Otevřel jsem kufr, nezapomeň ho zavřít");
        }
        
    }
}
