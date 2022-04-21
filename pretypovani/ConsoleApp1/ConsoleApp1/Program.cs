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
            Pes pes1 = new Pes("Alik", 30, "Pitbul");
            Zvire pes2 = new Pes("Rex", 30, "Pitbul");
            ((Pes)pes1).Dychej();
            ((Pes)pes2).Stekej();

            Delfin delfin1 = new Delfin("Vinetů", 20, 10);
            Zvire delfin2 = new Delfin("Escobar", 20, 30);
            ((Delfin)delfin1).Dychej();
            ((Delfin)delfin2).Plav();

            Netopyr netopyr1 = new Netopyr("Batman", 10, "Krevní skupina A");
            Zvire netopyr2 = new Netopyr("Robin", 12, "Krevní skupina B");
            ((Netopyr)netopyr1).Dychej();
            ((Netopyr)netopyr2).SaniKrve();


            //list a přidání do listu
            List<Zvire> listZvirat = new List<Zvire>();

            listZvirat.Add(pes1);
            listZvirat.Add(delfin1);
            listZvirat.Add(netopyr1);

            //průchod listem - pokud bude zvíře pes, zaštěká

            foreach(Zvire zvire in listZvirat)
            {
                if (zvire is Pes)
                {
                    ((Pes)pes1).Stekej();
                }
                if (zvire is Delfin)
                {
                    ((Delfin)delfin1).Plav();
                }
                if (zvire is Netopyr)
                {
                    ((Netopyr)netopyr1).SaniKrve();
                }
            }

            //zjištění počtu psů a delfínu a netopýru v listu
            int PocetPsu = 0;
            int PocetDelfinu = 0;
            int PocetNetopyru = 0;

            foreach (Zvire zvire in listZvirat)
            {
                if (zvire is Pes)
                {
                    PocetPsu++;
                }
                if (zvire is Delfin)
                {
                    PocetDelfinu++;
                }
                if (zvire is Netopyr)
                {
                    PocetNetopyru++;
                }
            }

            Console.WriteLine("Počet psů je :" + PocetPsu + "Počet delfínu je" + PocetDelfinu + "Pocet Netopýru je" + PocetNetopyru);
            Console.ReadKey();
        }
    }
}
