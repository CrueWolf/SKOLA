using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            
            Databaze databaze = new Databaze();
            Menu menu = new Menu();
            string volba;
            do
            {
                 volba = menu.VypisMenu();

                switch (volba)
                {
                    case "1":
                        databaze.VlozitHru();
                        break;
                    case "2":
                        databaze.VypsatHry();
                        break;
                    case "3":
                        databaze.VypisPodlePripustnosti();
                        break;
                    case "4":
                        databaze.VypsatHruPodleVyrobce();
                        break;
                    case "k":
                        Console.WriteLine("Ukončuji program...");
                        break;
                    default:
                        Console.WriteLine("Špatná volba");
                        Console.ReadKey();
                        break;
                }


            } while (volba != "k");


            Console.ReadKey();

        }
    }
}
