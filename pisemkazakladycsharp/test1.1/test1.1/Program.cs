using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            double pocet = 0;
            double soucet = 0;
            double cislo;

            do
            {
                Console.Write("zadej číslo(0pro ukončení):");
                cislo = double.Parse(Console.ReadLine());

                if (cislo != 0)
                {
                    pocet++;
                    soucet += cislo;
                }
            } while (cislo != 0);
            double prumer = soucet / pocet;
            Console.WriteLine("soucet vsech cisel je:" + soucet);
            Console.WriteLine("pocet vsech cisel je:" + pocet);
            Console.WriteLine("aritmeticky prumer je" + prumer);
            Console.ReadKey();


        }
    }
}
