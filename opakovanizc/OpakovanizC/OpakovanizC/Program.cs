using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpakovanizC
{
    class Program
    {
        static void Main(string[] args)
        {
            double soucet = 0;
            double pocet = 0;
            double cislo;


            /* do
            {
                Console.Write("zadej číslo (0 je pro ukončení) :");
                cislo = double.Parse(Console.ReadLine());

                if(cislo != 0) { 
                soucet += cislo;
                pocet++;
                }

            } while (cislo != 0);

            Console.WriteLine("součet všech čísel je:" +soucet);
            Console.WriteLine("pocet všech čísel je:" +pocet);
            Console.WriteLine("Artimetický prumer hodnot :{0}", soucet / pocet);
            */

            int pocetpokusu = 0;
            string spravneheslo ="hadej";
            string heslo;
            do
            {
                Console.Write("Zadej heslo :");
                 heslo = Console.ReadLine();

                if (heslo != spravneheslo)
                {
                    pocetpokusu++;
                }
                else
                {
                    Console.WriteLine("Vítejte");
                }
            } while (pocetpokusu < 3 && heslo != spravneheslo);

            Console.WriteLine("Ukončuji program");





            Console.ReadKey();



        }
    }
}