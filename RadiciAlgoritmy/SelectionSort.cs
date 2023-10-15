namespace RadiciAlgoritmy
{
    // Selection sort je nejblíže naivní implementaci řazení. Prochází kolekci prvek po prvku a hledá vždy její nejmenší prvek.
    // Když ho najde, umístí ho na místo aktuálního nejmenšího prvku. V každé iteraci se tedy kolekce pro hledání nejmenšího prvku zmenšuje a 
    // index aktuálního nejmenšího prvku se zvětšuje.

    // Můžeme tomu tedy rozumnět i tak, že selection sort rozděluje kolekci na dvě části - seřazenou a neseřazenou. Seřazená část je zpočátku prázdná,
    // a v každé iteraci najdeme její další prvek. Algoritmus skončí, až je neseřazená část prázdná.

    // Selection sort není adaptabilní ani stabilní (ale existuje jeho stabilní - pomalejší verze).
    public static class SelectionSort
    {
        public static void SeradPrvky(int[] pole)
        {
            for (int index = 0; index < pole.Length - 1; index++)
            {
                var indexMinPrvku = NajdiIndexNejmensihoPrvku(pole, index);
                VymenPrvky(pole, index, indexMinPrvku);
            }
        }

        private static int NajdiIndexNejmensihoPrvku(int[] pole, int pocatecniIndex)
        {
            var indexNejmensihoPrvku = pocatecniIndex;

            for (int index = pocatecniIndex + 1; index < pole.Length; index++)
            {
                if (pole[index] < pole[indexNejmensihoPrvku])
                {
                    indexNejmensihoPrvku = index;
                }
            }

            return indexNejmensihoPrvku;
        }

        private static void VymenPrvky(int[] pole, int indexA, int indexB)
        {
            var mezihodnota = pole[indexA];
            pole[indexA] = pole[indexB];
            pole[indexB] = mezihodnota;
        }
    }
}