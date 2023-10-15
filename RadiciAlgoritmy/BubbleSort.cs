namespace RadiciAlgoritmy
{
    // Princip bubble sortu spočívá v tom, že seřazená kolekce musí současně mít seřazeny všechny po sobě jdoucí dvojice.
    // Řadíme tedy všechny po sobě jdoucí dvojice do té doby, dokud nedojde k žádné změně - když se tak stane, víme, že je kolekce seřazena.
    // Bubble sortu se také říká sink sort, protože prvky stoupají nebo klesají na své místo.

    // Bubble má velké množství swap operací, ale je stabilní i adaptabilní.
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