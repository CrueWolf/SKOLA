using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Protivnik
    {
        public string jmenoprotivnik;
        public int zivotprotivnik;
        public string rasaprotivnik;
        public int silaprotivnik;

        public Protivnik(string jmenoprotivnik, int zivotprotivnik, string rasaprotivnik, int silaprotivnik)
        {
            this.jmenoprotivnik = jmenoprotivnik;
            this.zivotprotivnik = zivotprotivnik;
            this.rasaprotivnik = rasaprotivnik;
            this.silaprotivnik = silaprotivnik;
        }
        public void Info()
        {
            Console.WriteLine("Jmeno protivnika je:" + jmenoprotivnik);
            Console.WriteLine("protivnik má:" + zivotprotivnik);
            Console.WriteLine("Rasa protivníka je:" + rasaprotivnik);
            Console.WriteLine("sila protivníka je:" + silaprotivnik);
        }
        public void Souboj(Hrac Ezechiel)
        {
            Ezechiel.zivot -= silaprotivnik;
        }
    }
}
