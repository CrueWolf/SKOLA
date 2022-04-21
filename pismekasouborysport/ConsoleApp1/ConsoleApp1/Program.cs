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
            Diary diary = new Diary();

            diary.StartImport();
            

            string volba="";
            do
            {
                Console.Clear();
                Console.WriteLine("------------------Menu------------------");
                Console.WriteLine("1 --- Vložit info o běhu");
                Console.WriteLine("2 --- Vypsat všechny uložené běhy");
                Console.WriteLine("3 ---Smazat běh");
                Console.WriteLine("4 --- Zobrazit všechny naběhané kilometry");
                Console.Write("k --- ukončení aplikace");

                switch (volba) {

                    case "1":
                        diary.VlozitZapisRucne();
                        break;
                    case "2":
                        diary.VypisVsech();
                        break;
                    case "3":
                        //chyba diary.Smazat();
                        break;
                    case "4":
                        diary.VypisVsech();

                        break;
                    case "k":
                        Console.WriteLine("ukončuji program...");
                        break;

                    default:
                        Console.WriteLine("špatná volba, zvol možnosti udané v menu");
                        Console.ReadKey();
                        break;

                }
            } while (volba != "k");


            diary.ExportPriUkonceni();

            Console.ReadKey();




        }
    }
}
