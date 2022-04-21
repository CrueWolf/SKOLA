using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Databaze
    {
        public List<Hra> Db { get; private set; }
        public Databaze()
        {
            Db = new List<Hra>();
        }

        public void VlozitHru()
        {
            Console.WriteLine("Zadej jméno hry:");
            string nazev = Console.ReadLine();

            Console.WriteLine("Zadej výrobce hry:");
            string vyrobce = Console.ReadLine();

            Console.WriteLine("Zadej rok vydání hry:");
            int rok = int.Parse(Console.ReadLine());

            Console.WriteLine("Pegi hry:");
            int pegi = int.Parse(Console.ReadLine());

            Db.Add(new Hra(nazev, rok, vyrobce, pegi));

            Console.WriteLine("Hra byla vložena do databáze");
            Console.ReadKey();
        }

        public void VypsatHry()
        {
            foreach (Hra hra in Db)
            {
                hra.Info();
            }
            Console.ReadKey();

        }

        public void VypsatHruPodleVyrobce()
        {
            Console.WriteLine("¨vyhledávání podle výrobce:");
            Console.WriteLine("Zadej jméno výrobce:");
            string vyrobce = Console.ReadLine();
            foreach (Hra hra in Db )
            {
                if (hra.Vyrobce == vyrobce)
                {
                    hra.Info();
                }
            }
            Console.WriteLine("konec výpisu");
            Console.ReadKey();
        }

        public void VypisPodlePripustnosti()
        {
            Console.WriteLine("Vyber jednu z možnosotí" );
            Console.WriteLine("1. Dětské hry");
            Console.WriteLine("2. Mládeži přípustné");
            Console.WriteLine("3.Mládeži nepřípustné");
            Console.WriteLine("");
            Console.WriteLine("Tvoje volba");
            int volba = int.Parse(Console.ReadLine());
            string volbaRetezec;
            switch(volba) {
                case 1:
                     volbaRetezec = "Dětská hra";
                    break;

                case 2:
                    volbaRetezec = "Mládeži přístupná";
                    break;

                case 3:
                    volbaRetezec = "Mládeži nepřístupná";
                    break;
                default:
                    volbaRetezec = "0";
                    break;

            }
            foreach ( Hra hra in Db)
            {
                if (hra.Pristupnost == volbaRetezec)
                {
                    hra.Info();
                }
            }
            Console.WriteLine("Konec výpisu");
            Console.ReadKey();





        }


    }
}
