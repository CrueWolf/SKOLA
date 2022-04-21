using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;



namespace ConsoleApp1
{
    internal class Diary
    {
        List<Behani> diary;
        public Diary()
        {
            diary = new List<Behani>();
        }

        public void Vlozit(Behani behani)
        {
            diary.Add(behani);
        }
        public void Smazat (Behani behani)
        {
            diary.Remove(behani);
        }

        public void StartImport()
        {
            StreamReader sr = new StreamReader("diar.txt");
            string radek;

            while ((radek = sr.ReadLine()) != null){
                string[] hodnoty = radek.Split(';');

                Vlozit(new Behani(hodnoty[0], hodnoty[1],hodnoty [2], new DateTime(int.Parse(hodnoty[3]), int.Parse(hodnoty[4]), int.Parse(hodnoty[5])) ));

            }
            sr.Close();
        }
        /*
        public void SoucetKilometru()
        {
        
        }*/
        public void ExportPriUkonceni()
        {
            StreamWriter zapis = new StreamWriter("diar.txt");
            foreach (Behani behani in diary)
            {
                string radekZapis = behani.Km + ";" + behani.Cas + ";" + behani.Nazev + ";" + behani.Datum.Year + ";" + behani.Datum.Month + ";" + behani.Datum.Day + ";";
            }
            zapis.Close();
        }
        //2
        public void VypisVsech()
        {
                foreach (Behani behani in diary)
                {
                    behani.Info();
                }
                Console.WriteLine("konec výpisu pokračuj libovolnou klávesou");
                Console.ReadKey();
        }

        //1
        public void VlozitZapisRucne ()
        {

            Console.Write("Zadej pocet ubehnutych kilometru");
            string km = Console.ReadLine();
            Console.Write("Zadej čas");
            string cas = Console.ReadLine();
            Console.Write("Zadej Název tratě");
            string nazev = Console.ReadLine();
            Console.Write("Zadej Datum běhu.");
            string datum = Console.ReadLine();


            Vlozit(new Behani( km, cas, nazev, new DateTime()));
            Console.WriteLine("Zaznam uspesně vlozen do diáře...");
            Console.ReadKey();

        
        }



    }
}
