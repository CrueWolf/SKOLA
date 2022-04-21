using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Pes : Zvire
    {
        public string Rasa { get; private set; }
        public Pes(string jmeno, int vaha, string rasa) : base(jmeno, vaha)
        {
            Rasa = rasa;
        }

        public void Stekej()
        {
            Console.Write("Tvůj pes štěká");
            Console.ReadKey();
            Console.Clear();

        }

    }
}
