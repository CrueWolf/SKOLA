using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Student
    {

        public string jmeno;
        public string prijmeni;
        public int vek;
        public int rocnik;

        public Student(string jmeno, string prijmeni, int vek, int rocnik)
        {
            this.jmeno = jmeno;
            this.prijmeni = prijmeni;
            this.rocnik = rocnik;
            this.vek = vek;
        }
        public void PredstavSe()
        {
            Console.WriteLine("Jmenuji se {0}, {1} a je mi {2} a pocházím z {3} rocniku", jmeno, prijmeni, vek, rocnik);
        }


    }
}

