using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zapouzdreni
{
    class Human
    {
        public string Jmeno { get; private set; }
        public string Prijmeni { get; private set; }

        public bool Plnoletost { get; private set; }

        private int vek;
        public int Vek
        {
            get
            {
                return vek;
            }
            set
            {
                vek = value;
                if (vek < 18)
                {
                    Plnoletost = false;
                }
                else
                {
                    Plnoletost = true;
                }
            }
        }

        public Human(string jmeno, string prijmeni, int vek)
        {
            Jmeno = jmeno;
            Prijmeni = prijmeni;
            Vek = vek;

        }

    }
}
