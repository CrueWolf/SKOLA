using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Hra
    {
        public string Nazev { get; private set; }
        public int RokVydani { get; private set; }
        public string Vyrobce { get; private set; }
        public string Pristupnost { get; private set; }
        int pegi;
        public int Pegi {
            get
            {
                return pegi;
            }
            set
            {
                pegi = value;
                if (pegi <=7){
                    Pristupnost = "Dětská hra";
                }
                else if (pegi <= 17)
                {
                    Pristupnost = "Mládeži přístupná";
                }
                else
                {
                    Pristupnost = "Mládeži nepřístupná";
                }
            }
        }


        public Hra (string nazev, int rokvydani, string vyrobce, int pegi)
        {
            Nazev = nazev;
            RokVydani = rokvydani;
            Vyrobce = vyrobce;
            Pegi = pegi;
        }

        public void Info()
        {
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("Nazev hry je:" + Nazev);
            Console.WriteLine("Rok vydani hry je:"+ RokVydani);
            Console.WriteLine("Vyrobce hry je:"+ Vyrobce);
            Console.WriteLine("Pegi hry jsou: {0} - {1}",  Pegi, Pristupnost);
            Console.WriteLine("---------------------------------------------");


        }

    }
}
