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
            string jmeno;
            string prijmeni;
            DateTime vlastniDatumCas;

            Console.WriteLine("Zadej jméno");
            jmeno = Console.ReadLine();
            jmeno = jmeno.Trim();
            Console.WriteLine("Zadej prijmeni");
            prijmeni = Console.ReadLine();
            prijmeni = prijmeni.Trim();


            Console.WriteLine("Zadej datum narození:");
            vlastniDatumCas = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Vase jmeno je: {0}", jmeno + prijmeni);
            Console.WriteLine("Tolik vám je let:")



            Console.ReadKey();
        }
    }
}
