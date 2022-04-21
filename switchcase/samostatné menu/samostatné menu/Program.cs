using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace samostatné_menu
{
    class Program
    {
        static void Main(string[] args)
        {
            int volba;
            do {
                volba = NacteniVolby();

                switch (volba)
                {
                    case 1:
                        Console.WriteLine("Předkrm1");
                        Console.WriteLine("Předkrm2\n");
                        break;

                    case 2:
                        Console.WriteLine("Menu1");
                        Console.WriteLine("Menu2\n");
                        break;

                    case 3:
                        Console.WriteLine("Hlavní jídlo1");
                        Console.WriteLine("Hlavní jídlo2");
                        break;
                    case 4:
                        Console.WriteLine("Polévky1");
                        Console.WriteLine("Polévky2\n");
                        break;

                    case 5:
                        Console.WriteLine("Deserty1");
                        Console.WriteLine("Deserty2");
                        break;

                    case 6:
                        Console.WriteLine("Ukončení\n");
                        break;

                    default:
                        Console.WriteLine("chybná možnost volby");
                        break;


                }
                Console.ReadKey();
                Console.Clear();
            } while (volba != 0);
        }

        static int NacteniVolby()
        {
            Console.WriteLine("1.Předkrm");
            Console.WriteLine("2.Menu");
            Console.WriteLine("3.Hlavní jídlo");
            Console.WriteLine("4.Polévky");
            Console.WriteLine("5.Deserty\n");
            Console.WriteLine("6.Ukončení menu\n");


            Console.WriteLine("Vaše volba");

            int volba = int.Parse(Console.ReadLine());
            return volba;




        }
    }
}
