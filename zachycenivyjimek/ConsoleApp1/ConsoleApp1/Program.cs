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

            Console.WriteLine("Zadej číslo");
            byte cislo;
            try {
                cislo = byte.Parse(Console.ReadLine());
                Console.WriteLine("Zadal jsi číslo" + cislo);

            }
            catch (OverflowException chybaflow)
            {
                Console.WriteLine(chybaflow.Message);
            }
            catch (FormatException chybaFormat)
            {
                Console.WriteLine(chybaFormat.Message);
            }
            catch (Exception chyba)
            {
                Console.WriteLine(chyba.Message);
            }
            finally
            {
                Console.WriteLine("Tohle se vytiskne vždy, at chyba nastane nebo ne ...");
            }



            Console.ReadKey();
        }
    }
}
