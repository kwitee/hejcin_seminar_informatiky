using System;

namespace RadiciAlgoritmy
{
    public static class ZadejPoleUkol
    {
        // Napište funkci, která si od uživatele vyžádá zadání pole celočíselných hodnot (libovolné délky)
        // Hodnoty by měli být odděleny čárkami
        // Funkce by měla vstupní data uživatele načíst a překonvertovat na int[].
        public static int[] ZadejPole()
        {
            Console.WriteLine("Zadej hodnoty pole oddělené čárkami a potvrď enterem:");
            var zadaneHodnoty = Console.ReadLine();
            var textoveHodnoty = zadaneHodnoty.Split(',');

            var poleHodnot = new int[textoveHodnoty.Length];

            for (var i = 0; i < textoveHodnoty.Length; i++)
            {
                poleHodnot[i] = int.Parse(textoveHodnoty[i]);
            }

            return poleHodnot;
        }
    }
}