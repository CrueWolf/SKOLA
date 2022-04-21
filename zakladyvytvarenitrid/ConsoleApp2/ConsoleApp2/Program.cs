using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Student dominik = new Student("pasa", "amigo", 21, 21);
            Student elpaso = new Student("kepasa", "amigo", 21, 2);

            dominik.PredstavSe();
            elpaso.PredstavSe();*/

            Console.WriteLine("Zadej jméno");
            string jmeno = Console.ReadLine();
            Console.WriteLine("Zadej příjmení");
            string prijmeni = Console.ReadLine();
            Console.WriteLine("Zadej věk");
            int vek = int.Parse (Console.ReadLine());
            Console.WriteLine("Zadej rocnik");
            int rocnik = int.Parse(Console.ReadLine());

            Student Zkouska = new Student(jmeno, prijmeni, vek, rocnik);
            if (rocnik <= 1)
            {
                Zkouska.PredstavSe();

                Console.WriteLine("Nejsem dostatečně starý na vyhodnocení známek");
            }
            else
            {
                Zkouska.PredstavSe();
                Console.WriteLine("Jsem dostatečně starý na vyhodnocení známek");
                Console.WriteLine("Moje známka je:");

                int znamka = int.Parse(Console.ReadLine());
                switch (znamka)
                {
                    case 1:
                        Console.WriteLine("Nic lepšího už získat nejde.");
                        break;
                    case 2:
                        Console.WriteLine("Tak mohlo by to být lepší, ale dvojka je krásná známka.");
                        break;
                    case 3:
                        Console.WriteLine("Zlatý střed, hlavně nevyčnívat.");
                        break;
                    case 4:
                        Console.WriteLine("Tak hlavně že nepropadám.");
                        break;
                    case 5:
                        Console.WriteLine("Asi bych měl něco začít se sebou dělat, ale komu by se chtělo....");
                        break;
                    default:
                        Console.WriteLine("Takovou známku neznám");
                        break;

                }
            }
            

            Console.ReadKey();
        }
    }
}