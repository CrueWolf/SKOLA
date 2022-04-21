using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Menu
    {
        public string VypisMenu()
        {
            Console.WriteLine("Menu naší aplikace");
            Console.WriteLine("1.Přidat hru");
            Console.WriteLine("2.Vypsat všechny hry");
            Console.WriteLine("3. Výpis her podle přístupnosti");
            Console.WriteLine("4. Výpis her od zadaného výrobce");
            Console.WriteLine("K. konec programu");
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Tvoje volba");
            string volba = Console.ReadLine();

            return volba;
        }
    }
}
