namespace RadiciAlgoritmy
{
    public static class QuickSort
    {
        public static void SeradPrvky(int[] pole)
        {
            // TODO: Implementujte řadící algoritmus quick sort.
        }

        private static void VymenPrvky(int[] pole, int indexA, int indexB)
        {
            var mezihodnota = pole[indexA];
            pole[indexA] = pole[indexB];
            pole[indexB] = mezihodnota;
        }
    }
}