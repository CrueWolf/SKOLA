using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zapouzdreni
{
    class Program
    {
        static void Main(string[] args)
        {
            Human Franta = new Human("Franta", "Vomacka", 18);
            Human Vojta = new Human("Vojta", "Sudru", 17);

            Console.WriteLine( Franta.Plnoletost);

            Console.ReadKey();
        }
    }
}
