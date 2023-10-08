namespace RadiciAlgoritmy
{
    public static class BubbleSort
    {
        public static void SeradPrvky(int[] pole)
        {
            bool alesponJedenPrvekVymenen;

            do
            {
                alesponJedenPrvekVymenen = false;

                for (int i = 0; i < pole.Length - 1; i++)
                {
                    if (pole[i] > pole[i + 1])
                    {
                        VymenPrvky(pole, i, i + 1);
                        alesponJedenPrvekVymenen = true;
                    }
                }
            }
            while (alesponJedenPrvekVymenen);
        }

        private static void VymenPrvky(int[] pole, int indexA, int indexB)
        {
            var mezihodnota = pole[indexA];
            pole[indexA] = pole[indexB];
            pole[indexB] = mezihodnota;
        }
    }
}