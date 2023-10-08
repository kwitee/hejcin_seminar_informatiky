using System;
using System.IO;

namespace SouborovySystemVyklad
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Co je to souborový systém
            {
                // Souborovy systém je hierarchický systém, který má podobu stromu.
                // Každý uzel stromu je adresář (složka) nebo soubor.
                // Kořenový uzel stromu je označován jako root nebo kořenový adresář.
            }

            // Cesty
            {
                // Cesta k souboru nebo adresáři je posloupnost uzlů, které se musí projít, aby se došlo k cílovému uzlu.
                // Uzly se oddělují znakem \ (zpětné lomítko). Zpětné lomítko je v jazyce C# \ speciální znak, musíme ho proto zdvojit.
                // Příklad: 
                var cesta = "C:\\Users\\kvet\\Dokumenty\\Koala.jpg";
                // Cestu interpretujeme jako: V kořenovém adresáři C: najdi adresář Users,
                // v něm najdi adresář kvet, v něm najdi adresář Dokumenty, v něm najdi soubor Koala.jpg.

                // Cesta může vést i k adresáři:
                var cestaKAdresari = "C:\\Users\\kvet\\Dokumenty";

                // Předchozí příklad byla absolutní cesta. Absolutní cesta začíná vždy kořenovým adresářem.
                // Existuje i relativní cesta. Relativní cesta začíná vždy aktuálním adresářem.
                // Pokud cestu definujeme v programu, je aktuální adresář ten adresář, ve kterém se sestavený program nachazí.

                // Relativní cesta může obsahovat možnost jdi o adresář výše, označovanou jako .. (dvě tečky).
                // Příklad: 
                var relativniCesta = "..\\..\\Koala.jpg";
                // Cestu interpretujeme jako: V aktuálním adresáři jdi o jeden adresář výše, v něm jdi o jeden adresář výše,
                // pak najdi soubor Koala.jpg.
            }

            // Práce se soubory v C#
            {
                // Pro práci se soubory slouží třída System.IO.File:

                // Zjisti, zda soubor na dané cestě existuje
                bool souborExistuje = File.Exists("soubor.txt");

                // Přečti soubor po řádcích do pole řetězců
                string[] radkySouboru =  File.ReadAllLines("soubor.txt");

                // Přečti soubor jako jeden řetězec
                string obsahSouboru = File.ReadAllText("soubor.txt");

                // Otevři soubor a přidej na jeho konec další text
                File.AppendAllText("soubor.txt", "Poznámka na konec");

                // Otevři soubor a přidej na jeho konec další řádky definované polem řetězců
                File.AppendAllLines("soubor.txt", new string[] {"Řádek1", "Řádek2"});
            }

            // Práce s adresáři v C#
            {
                // Pro práci s adresáři slouží třída System.IO.Directory:

                // Zjisti, zda adresář na dané cestě existuje
                bool adresarExistuje = Directory.Exists("C:\\users\\kvet\\Documenty");

                // Vrátí seznam souborů v daném adresáři
                string[] soubory = Directory.GetFiles("C:\\users\\kvet\\Documenty");

                // Vrátí seznam podadresářů v daném adresáři
                string[] podadresare = Directory.GetDirectories("C:\\users\\kvet\\Documenty");
            }

            Console.WriteLine("Stiskněte libovolnou klávesu pro konec.");
            Console.ReadKey();
        }
    }
}