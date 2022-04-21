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
            Auto auto = new Auto("moje auto", 5.2F, 2);
            Osobak osobak = new Osobak("muj osobak", 1.3F, 2, 2);
            Nakladak nakladak = new Nakladak("muj nakladak", 1.9F, 2, 3);

            auto.Jizda();

            osobak.Jizda();
            osobak.OtevritKufr();

            nakladak.Jizda();
            nakladak.Otevreni();
            Console.WriteLine("\n");
            nakladak.Zavreni();


            Console.ReadKey();
        }
    }
}
