using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        /*řešení menu pro hru - pomocí if a switch case
        //program zobrazí menu, každá položka je očíslovaná
        //potom vyzve uživatele aby zvolil jednu z možností...
        //
        //
        //
        //Menu
        //
        //1.Nová hra
        //2. nahrát hru
        //3. nejlepší výsledky
        //4. o hře
        //
        //Vaše volba: */
        static void Main(string[] args)
        {
            int volba;
            do
            {
                volba = NacteniVolby();

                switch (volba)
                {
                    case 1:
                        Console.WriteLine("Začínám novou hru....\n");
                        break;
                    case 2:
                        Console.WriteLine("Nahrávám uloženou hru.....\n");
                        break;
                    case 3:
                        Console.WriteLine("Nejlepší ve hře je náš třídní učitel na PVA\n");
                        break;
                    case 4:
                        Console.WriteLine("Tohle je ta nejlepší hra vůbec....\n");
                        break;
                    case 0:
                        Console.WriteLine("Ukončuji hru... brzy nashledanou...\n");
                        break;

                    default:
                        Console.WriteLine("Zadal jsi špatnou volbu");
                        break;
                }
                Console.ReadKey();
                Console.Clear();

            } while (volba != 0);
        }



        static int NacteniVolby()
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Menu:");

                Console.ResetColor();
                Console.WriteLine("1. Nová hra");
                Console.WriteLine("2. Nahrát hru");
                Console.WriteLine("3. Nejlepší výsledky");
                Console.WriteLine("4. O hře\n");

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("0 - ukončení hry \n");

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Vaše Volba");

                Console.ResetColor();



            int volba = int.Parse(Console.ReadLine());
                return volba;
            }
    }
}
