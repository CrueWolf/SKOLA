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
            /*zjištění aktuálního data a času

            DateTime aktualniDatumCas = DateTime.Now;
            Console.WriteLine(DateTime.Now);

            //výpis pouze roku
            Console.WriteLine("rok v aktuálníDatumCas: {0}", aktualniDatumCas.Year);
            Console.WriteLine("mesic v aktuálníDatumCas: {0}", aktualniDatumCas.Month);
            Console.WriteLine("den v aktuálníDatumCas: {0}", aktualniDatumCas.Day);
            Console.WriteLine("hodina v aktuálníDatumCas: {0}", aktualniDatumCas.Hour);
            Console.WriteLine("minuta v aktuálníDatumCas: {0}", aktualniDatumCas.Minute);
            Console.WriteLine("sekunda v aktuálníDatumCas: {0}", aktualniDatumCas.Second);

            //porovnání datumu

            DateTime pozdejsiCas = DateTime.Now;

            Console.WriteLine("sekunda v aktuálníDatumCas: {0}", aktualniDatumCas!=pozdejsiCas);

            //vlastní datum

            DateTime vlastniDatumCas = new DateTime(2021, 10, 11, 13, 23, 56);
            Console.WriteLine("Mou zadané datum: {0}", vlastniDatumCas);

            vlastniDatumCas = vlastniDatumCas.AddDays(100);

            Console.WriteLine("upravené datum: {0}", vlastniDatumCas);
            Console.WriteLine("upravené datum: {0}", vlastniDatumCas.AddHours(-75));
            Console.WriteLine("upravené datum: {0}", vlastniDatumCas.AddSeconds(365));

            Console.WriteLine("Vypis dne datumu: {0}", aktualniDatumCas.DayOfWeek);
            Console.WriteLine("cele datum slovne: {0}", aktualniDatumCas.ToLongDateString());
            */

            DateTime aktualniDatumCas = DateTime.Now;

            string datum = aktualniDatumCas.ToLongDateString();
            Console.Write(aktualniDatumCas);

            string[] x = datum.Split();
            string y = x[2];
            if (y == "Ledna")
            {
                Console.WriteLine("Leden");
            }
            else if (y == "Února")
            {
                Console.WriteLine("Únor");
            }
            else if (y == "Března")
            {
                Console.WriteLine("Březen");
            }
            else if (y == "Dubna")
            {
                Console.WriteLine("Duben");
            }
            else if (y == "Května")
            {
                Console.WriteLine("Květen");
            }
            else if (y == "Června")
            {
                Console.WriteLine("Červen");
            }
            else if (y == "Července")
            {
                Console.WriteLine("Červenec");
            }
            else if (y == "Srpna")
            {
                Console.WriteLine("Srpen");
            }
            else if (y == "Září")
            {
                Console.WriteLine("Září");
            }
            else if (y == "Října")
            {
                Console.WriteLine("Říjen");
            }
            else if (y == "Listopadu")
            {
                Console.WriteLine("Listopad");
            }
            else if (y == "Prosince")
            {
                Console.WriteLine("Prosinec");
            }


            Console.ReadKey();
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Metody
{
    class Program
    {
        static void Main(string[] args)
        {
            /// základní výpočetní operace
            /// 

            // výpočet aboslutní hodnota

            Console.WriteLine("Math.Abs(-5.5) = {0}", Math.Abs(-5.5));

            // vrácení nejbližšího většího celého čísla (zaokrouhlení vždy nahoru)

            Console.WriteLine("Math.Ceiling(3.1) = {0}", Math.Ceiling(3.1));

            // vrácení nejbližšího menšího celého čísla (zaokrouhlení vždy dolu)

            Console.WriteLine("Math.Floor(3.7) = {0}", Math.Floor(3.7));

            // výpočet mocniny
            Console.WriteLine("Math.Pow(3,4) = {0}", Math.Pow(3, 4));

            // výpočet odmocniny
            Console.WriteLine("Math.Sqrt(85) = {0}", Math.Sqrt(85));

            // zaokrouhlení - podle pravidel

            Console.WriteLine("Math.Round(5.2) = {0}", Math.Round(5.2));
            Console.WriteLine("Math.Round(5.5) = {0}", Math.Round(5.5));


            /// základní metody pro práci s řetězci
            /// 

            // sloučení řetězců do jednoho za pomoci +

            string prvniSlovo = "nejaky text";
            string druheSlovo = "další text";
            string tretiSlovo = "poslední text";

            string spojeniSlov = prvniSlovo + druheSlovo + tretiSlovo;

            Console.WriteLine("Spojený řetězec: {0}", spojeniSlov);

            // sloučení pole řetězců do jednoho řetězce

            string[] poleRetezcu = { "prvni prvek pole", "druhý prvek pole", "třetí prvek pole" }; // vytvoření pole a rovnou se vloží hodnoty
            Console.WriteLine("String.Concat(poleRetezcu) = {0}", string.Concat(poleRetezcu));

            // zjištění, zda jde o prázdný řetězec - vrátí true/false

            Console.WriteLine("string.IsNullOrEmpty(\"Ahoj \"): {0}", string.IsNullOrEmpty("Ahoj "));
            Console.WriteLine("string.IsNullOrEmpty(\"\"): {0}", string.IsNullOrEmpty(""));

            // zjištění znaku v řetězci - contains - vrací true/flase

            string text = "abcdefghijk";

            Console.WriteLine("Prohledávaný řetězec: {0}", text);
            Console.WriteLine("text.Contains(\"l\"): {0}", text.Contains("l"));
            Console.WriteLine("text.Contains(\"b\"): {0}", text.Contains("b"));
            Console.WriteLine("text.Contains(\"bcde\"): {0}", text.Contains("bcde"));
            Console.WriteLine("text.Contains(\"bacde\"): {0}", text.Contains("bacde"));
            Console.WriteLine();

            // zjištění počtu znaků v řetězci
            Console.WriteLine("Prohledávaný řetězec: {0}", text);
            Console.WriteLine("text.Length {0}", text.Length);
            Console.WriteLine();

            // zjištění, zda řetězec končí konkrétním řetězcem
            Console.WriteLine("Prohledávaný řetězec: {0}", text);
            Console.WriteLine("text.EndsWith(\"ijk\"): {0}", text.EndsWith("ijk"));
            Console.WriteLine("text.EndsWith(\"abc\"): {0}", text.EndsWith("abc"));
            Console.WriteLine();

            // zjhištění, zda řetězec začíná konkrétním řetězcem
            Console.WriteLine("Prohledávaný řetězec: {0}", text);
            Console.WriteLine("text.StartWith(\"ijk\"): {0}", text.StartsWith("ijk"));
            Console.WriteLine("text.StartWith(\"abc\"): {0}", text.StartsWith("abc"));
            Console.WriteLine();

            // string - je pole znaků, přístup k jednotlivým znakům jako k prvním poli

            Console.WriteLine("Prohledávaný řetězec: {0}", text);
            Console.WriteLine("text[1] = {0}", text[1]);
            Console.WriteLine("text[5] = {0}", text[5]);
            Console.WriteLine();


            // hledání indexu(pozice) konkrétního prvku v řetězci - vrátí index prvku
            // pokud je znak nenalezen, vrátí -1

            text = "petr.lelovski";

            Console.WriteLine("Prohledávaný text: {0}", text);
            Console.WriteLine("text.IndexOf('.'): {0}", text.IndexOf('.'));
            Console.WriteLine("text.IndexOf(';'): {0}", text.IndexOf(';'));
            Console.WriteLine();

            // hledání indexu prvku od určité pozice
            Console.WriteLine("Prohledávaný text: {0}", text);
            Console.WriteLine("text.IndexOf('.'): {0}", text.IndexOf('.', 5));
            Console.WriteLine("text.IndexOf('.'): {0}", text.IndexOf('.', 2));
            Console.WriteLine();

            // odstranění znaků z řetězce od imndexu do konce

            string upravenyText = text.Remove(2);
            Console.WriteLine("text k úpravě: {0}", text);
            Console.WriteLine("upravený text: {0}", upravenyText);
            Console.WriteLine();


            // odstranění znaků z řetězce od zadaného indexu počet znaků
            upravenyText = text.Remove(2, 3);
            Console.WriteLine("text k úpravě: {0}", text);
            Console.WriteLine("upravený text: {0}", upravenyText);
            Console.WriteLine();

            // vytvoření podřetězce z řetězce od určitého indexu

            upravenyText = text.Substring(2);
            Console.WriteLine("text k úpravě: {0}", text);
            Console.WriteLine("upravený text pomocí upravenyText = text.Substring(2): {0}", upravenyText);
            Console.WriteLine();

            // podřetězec od zadaného indexu + počet prvků

            upravenyText = text.Substring(2, 5);
            Console.WriteLine("text k úpravě: {0}", text);
            Console.WriteLine("upravený text pomocí upravenyText = text.Substring(2,5): {0}", upravenyText);
            Console.WriteLine();


            // převedení textu na velká písmena

            Console.WriteLine("text k úpravě: {0}", text);
            text = text.ToUpper(); // původní text přepíše velkými písmeny
            Console.WriteLine("text.ToUpper(): {0}", text);
            Console.WriteLine();

            // převedení na malá písmena

            Console.WriteLine("text k úpravě: {0}", text);
            text = text.ToLower();
            Console.WriteLine("text.ToLower(): {0}", text);
            Console.WriteLine();

            // nahrazení znaku/řetězce jiným znakem/řetězcem

            text = "petr.lelovski;Tomáš Lelovski";
            Console.WriteLine("Text k úprávě: {0}", text);
            text = text.Replace(';', ',');
            Console.WriteLine("Upravený text: {0}", text);
            Console.WriteLine();

            string jmeno = "Novák";
            Console.WriteLine("Původní jméno: {0}", jmeno);
            jmeno = jmeno.Replace("ák", "áková");
            Console.WriteLine("Přejmenováno pomocí replace: {0}", jmeno);
            Console.WriteLine();

            // odstranění netisknutelných znaků na začátku a na konci řetězce

            jmeno = "    Petr    ";
            Console.WriteLine("Zadané jméno: {0}", jmeno);
            jmeno = jmeno.Trim();
            Console.WriteLine("Otrimované jméno: {0}", jmeno);
            Console.WriteLine();

            jmeno = "             Petr";
            Console.WriteLine("Původní jméno: {0}", jmeno);
            jmeno = jmeno.TrimStart();
            Console.WriteLine("Otrimováná od znaků na začátku: {0}", jmeno);
            Console.WriteLine();

            jmeno = "Petr       ";
            Console.WriteLine("Původní jméno: {0}", jmeno);
            jmeno = jmeno.TrimEnd();
            Console.WriteLine("Zbaveno znaků na konci: {0}", jmeno);
            Console.WriteLine();

            jmeno = "....Petr....";
            Console.WriteLine("Původní jméno: {0}", jmeno);
            jmeno = jmeno.Trim('.');
            Console.WriteLine("Jméno otrimováno o tečky: {0}", jmeno);


            Console.ReadKey();

        }
    }
}
