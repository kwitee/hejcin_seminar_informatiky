namespace RadiciAlgoritmy
{
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

        public static int NajdiIndexNejmensihoPrvku(int[] pole, int pocatecniIndex)
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