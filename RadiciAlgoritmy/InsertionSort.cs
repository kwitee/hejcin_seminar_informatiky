namespace RadiciAlgoritmy
{
    // Insertion sort prochází kolekci ve dvou směrech. Podobně jako selection sort rozděluje kolekci na seřazenou a neseřazenou část.
    // První cyklus prochází prvky sekvenčně, druhý cyklus prochází prvky v opačném směru a vkládá je na správné místo do seřazené části.

    // Insertion sort je králem mezi jednoduchými řadícím algoritmy. Je stabilní i adaptabilní.Nabízí kompromis mezi počtem porovnání a
    // swapů, ale je vhodný pouze na malá pole.
    public static class InsertionSort
    {
        public static void SeradPrvky(int[] pole)
        {
            for (int index = 1; index < pole.Length; index++)
            {
                for (int zpetnyIndex = index; zpetnyIndex > 0; zpetnyIndex--)
                {
                    if (pole[zpetnyIndex - 1] > pole[zpetnyIndex])
                    {
                        VymenPrvky(pole, zpetnyIndex - 1, zpetnyIndex);
                    }
                    else
                    {
                        break;
                    }
                }
            }
        }

        private static void VymenPrvky(int[] pole, int indexA, int indexB)
        {
            var mezihodnota = pole[indexA];
            pole[indexA] = pole[indexB];
            pole[indexB] = mezihodnota;
        }
    }
}