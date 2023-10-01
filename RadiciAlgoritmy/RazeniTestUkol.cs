using System;

namespace RadiciAlgoritmy
{
    public static class RazeniTestUkol
    {
        // Napište funkci, která rozhodne, zda je pole seřazeno vzestupně.
        // Tzn. každá další hodnota musí být větší nebo rovna předchozí hodnotě.
        // K řešení použijte libovolnou smyčku.
        public static bool JeSerazeno(int[] pole)
        {
            // return ReseniFor(pole);
            return ReseniForEach(pole);
        }

        public static void TestovaciFunkce()
        {
            var pole1 = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }; // true
            var pole2 = new int[] { -5, -2, 0, 5, 5, 12 }; // true
            var pole3 = new int[] { 1, 1, -2, 3, -2 }; // false
            var pole4 = new int[] { 1, 2, 3, 4, -5 }; // false

            Console.WriteLine(JeSerazeno(pole1));
            Console.WriteLine(JeSerazeno(pole2));
            Console.WriteLine(JeSerazeno(pole3));
            Console.WriteLine(JeSerazeno(pole4));
        }

        public static bool ReseniFor(int[] pole)
        {
            for (int i = 1; i < pole.Length; i++)
            {
                if (pole[i - 1] > pole[i])
                {
                    return false;
                }
            }

            return true;
        }

        public static bool ReseniForEach(int[] pole)
        {
            var predchoziHodnota = int.MinValue;

            foreach (var hodnota in pole)
            {
                if (predchoziHodnota > hodnota)
                {
                    return false;
                }

                predchoziHodnota = hodnota;
            }

            return true;
        }
    }
}