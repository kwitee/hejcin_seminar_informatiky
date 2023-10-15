using System;
using System.Collections.Generic;

namespace RadiciAlgoritmy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Řadící (třídící, anglicky sorting) algoritmy slouží k seřazení vstupních dat v kolekci vzestupně nebo sestupně.
            // Z dnešního pohledu jsou to dost low-level algoritmy, které se ručně moc neprogramují. Naprostá většina programovacích jazyků
            // má řazení vyřešeno ve standartní knihovně. 
            // Ve výuce programování ale mají řadící algoritmy stále své místo, např. při výuce složitostí algoritmů. 

            // Pro spoustu algoritmů je mít seřazená vstupní data důležité, např. pokud chceme vyhledávat v seznamu, práce s seřazeným polem
            // nám ušetří spoustu práce.

            // Vlastnoti třídících algoritmů:
            // Stabilita: prvky stejné velikosti si zachovají svoje původní řazení.
            // Adaptabilita: pokud jsou vstupní data předřazena, proběhne menší počet operací a algoritmus je rychlejší.

            Console.WriteLine("Pole k seřazení: ");
            var poleKSerazeni = VytvorPoleKSerazeni();
            VypisListPoli(poleKSerazeni);

            Console.WriteLine();
            Console.WriteLine("Výpis, zda jsou pole seřazena: ");
            VypisJsouPoleSerazena(poleKSerazeni);

            Console.WriteLine();
            Console.WriteLine("Vyber radici algoritmus (B - bubble sort, S - selection sort):");

            while (true)
            {
                var vybranyAlgoritmus = Console.ReadLine();

                if (vybranyAlgoritmus == "B")
                {
                    Console.WriteLine();
                    Console.WriteLine("Řazení pole algoritmem bubble sort.");

                    foreach (var pole in poleKSerazeni)
                    {
                       BubbleSort.SeradPrvky(pole);
                    }

                    break;
                }
                else if (vybranyAlgoritmus == "S")
                {
                    Console.WriteLine();
                    Console.WriteLine("Řazení pole algoritmem selection sort.");

                    foreach (var pole in poleKSerazeni)
                    {
                        SelectionSort.SeradPrvky(pole);
                    }

                    break;
                }
                else
                {
                    Console.WriteLine("Neplatný algoritmus. Zkus to znovu.");
                }
            }

            Console.WriteLine();
            Console.WriteLine("Výpis, zda jsou pole seřazena: ");
            VypisJsouPoleSerazena(poleKSerazeni);

            Console.WriteLine("Stiskni libovolnou klávesu pro konec.");
            Console.ReadKey();
        }

        private static List<int[]> VytvorPoleKSerazeni()
        {
            var serazenePole = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var otocenePole = new int[] { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };
            var poleSDuplikaty = new int[] { 7, 8, 1, 4, 7, 6, 9, 10, 15, 3, 7 };
            var poleSeZapornymiCisli = new int[] { 7, 8, 1, -1, -2, 4, 7, -9, -10, 6, 9, 10, 15, 3, 7, -8 };

            return new List<int[]> { serazenePole, otocenePole, poleSDuplikaty, poleSeZapornymiCisli };
        }

        private static void VypisListPoli(List<int[]> listPoli)
        {
            foreach (var pole in listPoli)
            {
                Console.WriteLine(string.Join(", ", pole));
            }
        }

        private static void VypisJsouPoleSerazena(List<int[]> listPoli)
        {
            foreach (var pole in listPoli)
            {
                var vypisPole = string.Join(", ", pole);

                if (Tester.JePoleSerazeno(pole))
                {
                    Console.WriteLine($"Pole {vypisPole} je seřazeno.");
                }
                else
                {
                    Console.WriteLine($"Pole {vypisPole} není seřazeno.");
                }
            }
        }
    }
}