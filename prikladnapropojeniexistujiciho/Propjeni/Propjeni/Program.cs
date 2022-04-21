using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Propjeni
{
    class Program
    {
        static void Main(string[] args)
        {
            
            /// tohle vypíše věty na obrazovku
            Console.WriteLine("Jedna věta");
            Console.WriteLine("Druhá věta");
            Console.WriteLine("zkouška spojení");


            // výpis deseti vět pomocí foru
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Věta č. "+i);
            }

            Console.ReadLine();
        }
    }
}
