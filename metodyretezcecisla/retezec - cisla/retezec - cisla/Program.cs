using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace retezec___cisla
{
    class Program
    {
        static void Main(string[] args)
        {

            //vypočítání absolutní hodnoty
            Console.WriteLine("\nMath.Abs(-5.5) = {0}", Math.Abs(-5.5));

            //vrácení nejbližšího většího stejného čísla
            Console.WriteLine("\nMath.Ceiling (3.1) = {0}", Math.Ceiling(3.1));

            //vrácení nejbližšího menšího stejného čísla
            Console.WriteLine("\nMath.Floor(3.7) = {0}", Math.Floor(3.7));

            //výpošet mocniny
            Console.WriteLine("\nMath.Pow(3,4) = {0}", Math.Pow(3, 4));

            //výpočet odmocniny
            Console.WriteLine("\nMath.Sqrt(85) = {0}", Math.Sqrt(85));

            //zaokrouhlení dle pravidel
            Console.WriteLine("\nMath.Round(3.2) = {0}", Math.Round(3.2));
            Console.WriteLine("Math.Round(3.9) = {0}", Math.Round(3.9));


            //základní metody pro práci s řetězci

            //sloučení řetězců do jednoho za pomocí +
            string PrvniSlovo = "nejaky text";
            string DruheSlovo = "dalsi text";
            string TretiSlovo = "poslední text";

            string spojeniSlov = PrvniSlovo + DruheSlovo + TretiSlovo;
            Console.WriteLine("\nSpojeni slov obsahuje: {0}", spojeniSlov);

            //sloučení POLE řetězců do jednoho řetězce
            string[] poleRetezcu = { "\nprvni pole", "druhe pole", "treti pole" }; //rovnou vložené hodnoty
            Console.WriteLine("String.Concat(poleRetezcu): {0}", String.Concat(poleRetezcu)); //Stringoncat spojí do jednoho řetězce

            //zjištění zda je prázdný řetězec
            Console.WriteLine("\nstring.IsNullorEmpty (\"ahoj \") = {0}", string.IsNullOrEmpty("ahoj"));
            Console.WriteLine("string.IsNullorEmpty (\" \") = {0}", string.IsNullOrEmpty(""));

            //zjištění znaku v řetězci
            string Text = "\nabcdefghijk";
            Console.WriteLine("text.Contains(\"l\"): {0}", Text.Contains("l"));
            Console.WriteLine("text.Contains(\"b\"): {0}", Text.Contains("b"));

            //zjištění počtu znaků v řetězci
            Console.WriteLine("\ntext.leght: {0}", Text.Length);

            //zjištění zda řetězec končí konkrétním řetězcem
            Console.WriteLine("\ntext.EndsWitch(\"ijk\"): {0}", Text.EndsWith("ijk"));
            Console.WriteLine("text.EndsWitch(\"abc\"): {0}", Text.EndsWith("abc"));

            //zjištění zda řetězec začíná konkrétním řetězcem
            Console.WriteLine("\ntext.StartsWitch(\"ijk\"): {0}", Text.StartsWith("ijk"));
            Console.WriteLine("text.StartsWitch(\"abc\"): {0}", Text.StartsWith("abc"));

            // string - je pole znaků, přístup k jednotlivým znakům jako k prvním poli
            Console.WriteLine("\nProhledávaný řetězec: {0}", Text);
            Console.WriteLine("text[1] = {0}", Text[1]);
            Console.WriteLine("text[5] = {0}", Text[5]);

            //hledání indexu(pozice) konkrétního prvku v retezci
            //vrátí -1 když nenajde znak
            Text = "dominik.merhaut";
            Console.WriteLine("\ntext.IndexOf('.') = {0}", Text.IndexOf('.'));
            Console.WriteLine("text.IndexOf(';') = {0}", Text.IndexOf(';'));

            //hledání indexu prvku od určité pozice
            Console.WriteLine("\nprohledávaný text: {0}", Text);
            Console.WriteLine("text.IndexOf('.') = {0}", Text.IndexOf('.',9));

            //odstraneni znaku z retezce
            string upravenyText = Text.Remove(2);
            Console.WriteLine("\n text.Remove(7): {0}", upravenyText);

            upravenyText = Text.Remove(7,2);
            Console.WriteLine(" text.Remove(7): {0}", upravenyText);

            // vytvoření podřetězce z řetězce od určitého indexu

            upravenyText = Text.Substring(2);
            Console.WriteLine("text k úpravě: {0}", Text);
            Console.WriteLine("upravený text pomocí upravenyText = text.Substring(2): {0}", upravenyText);
            Console.WriteLine();

            // podřetězec od zadaného indexu + počet prvků

            upravenyText = Text.Substring(2, 5);
            Console.WriteLine("text k úpravě: {0}", Text);
            Console.WriteLine("upravený text pomocí upravenyText = text.Substring(2,5): {0}", upravenyText);
            Console.WriteLine();


            // převedení textu na velká písmena

            Console.WriteLine("text k úpravě: {0}", Text);
            Text = Text.ToUpper(); // původní text přepíše velkými písmeny
            Console.WriteLine("text.ToUpper(): {0}", Text);
            Console.WriteLine();

            // převedení na malá písmena

            Console.WriteLine("text k úpravě: {0}", Text);
            Text = Text.ToLower();
            Console.WriteLine("text.ToLower(): {0}", Text);
            Console.WriteLine();

            // nahrazení znaku/řetězce jiným znakem/řetězcem

            Text = "petr.lelovski;Tomáš Lelovski";
            Console.WriteLine("Text k úprávě: {0}", Text);
            Text = Text.Replace(';', ',');
            Console.WriteLine("Upravený text: {0}", Text);
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
