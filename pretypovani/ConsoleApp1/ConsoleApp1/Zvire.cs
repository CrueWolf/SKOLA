using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Zvire
    {
        public string Jmeno { get; private set; }
        public int Vaha { get; private set; }

        public Zvire(string jmeno, int vaha)
        {
            Jmeno = jmeno;
            Vaha = vaha;
        }

        public void Dychej()
        {
            Console.WriteLine("Tvé zvíře dýchá...");
            Console.ReadKey();
            Console.Clear();

        }
    }
}
