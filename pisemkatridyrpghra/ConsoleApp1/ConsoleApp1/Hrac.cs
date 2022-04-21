using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Hrac
    {
        public string jmeno;
        public int zivot;
        public string rasa;
        public int sila;

        public Hrac(string jmeno, int zivot, string rasa, int sila)
        {
            this.jmeno = jmeno;
            this.zivot = zivot;
            this.rasa = rasa;
            this.sila = sila;
        }

        public void Info()
        {
            Console.WriteLine("Jmeno postavy je:" + jmeno);
            Console.WriteLine("postava má:" + zivot);
            Console.WriteLine("Rasa postavy je:" + rasa);
            Console.WriteLine("sila postavy je:" + sila);
        }

        public void Souboj(Protivnik Bard)
        {
            Bard.zivotprotivnik -= sila;
        }
    }
}
