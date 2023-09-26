using System;

namespace SmyckyVyklad
{
    public static class Smycky
    {
        public static void SmyckaWhile()
        {
            Console.WriteLine("Ukázka cyklu while:");

            var citac = 5;

            while (citac > 0)
            {
                Console.WriteLine($"Citac ma hodnotu {citac}.");
                citac = citac - 1;
            }

            // Poznámka: do-while smyčka je pouze variace na smyčku while, efektivně funguje stejně

            // Výhody:
            // Variabilita, umožňuje nekonečné smyčky

            // Nevýhody:
            // Musíme se o ukončovací podmínku starat ručně - možnost nekonečné smyčky :-)
        }

        public static void SmyckaFor()
        {
            Console.WriteLine("Ukázka cyklu for:");

            var jmena = new string[] { "Josef", "Saša", "Lenka" };

            for (int index = 0; index < jmena.Length; index++)
            {
                Console.WriteLine(jmena[index]);
            }

            // Výhody:
            // Deklarace indexu přímo v těle smyčky
            // Umožňuje přístup na index

            // Nevýhody:
            // Musíme se o index starat ručně - možnost přetečení
        }

        public static void SmyckaForeach()
        {
            Console.WriteLine("Ukázka cyklu foreach:");

            var jmena = new string[] { "Josef", "Saša", "Lenka" };

            foreach (var jmeno in jmena)
            {
                Console.WriteLine(jmeno);
            }

            // Výhody:
            // Nepoužívá indexy - tzn. dá se použít i na datové struktury, které index nemají

            // Nevýhody:
            // Neumožňuje přístup k pořadí prvků (indexům), ale můžeme si vytvořit čítač ručně

            var citac = 0;

            foreach (var jmeno in jmena)
            {
                Console.WriteLine($"{citac}. jmeno je {jmeno}");
                citac = citac + 1;
            }
        }

        public static void KlicoveSlovoBreak()
        {
            // Break okamžitě ukončí smyčku
            // Jaké další klíčové slovo můžeme použít pro tentýž efekt?

            string jmeno;

            while (true)
            {
                Console.WriteLine("Napiš své jméno:");
                jmeno = Console.ReadLine();

                if (jmeno == "")
                {
                    Console.WriteLine("Zadané jméno bylo prázdné, zkus to znovu.");
                }
                else
                {
                    Console.WriteLine($"Tvé jméno je: {jmeno}");
                    break;
                }
            }
        }

        public static void KlicoveSlovoContinue()
        {
            // Continue ukončí aktuální iteraci, ale smyčka bude pokračovat dál
            // Příklad: sečti všechna kladná čísla z pole, záporná čísla ignoruj

            var hodnoty = new int[] { 5, 3, -5, -3, 4 };
            var soucetKladnych = 0;

            foreach (var hodnota in hodnoty)
            {
                if (hodnota < 0)
                {
                    continue;
                }

                soucetKladnych = soucetKladnych + hodnota;
            }

            Console.WriteLine($"Součet kladních hodnot je: {soucetKladnych}");
        }
    }
}