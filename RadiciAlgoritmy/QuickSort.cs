namespace RadiciAlgoritmy
{
    // Quick sort je jeden z nejrychlejších řadících algoritmů. Je založen na principu rozděl a panuj.
    // Je to rekurzivní algoritmus, který v každém volání zvolí pivot hodnotu. Poté rozdělí kolekci na dvě části, kde levá je menší než
    // pivot a pravá větší. V každém volání tedy vlastně najdeme správnou pozici pro pivota.

    // Výběr pivota je důležitý, protože pokud bychom v každém volání zvolili nejmenší nebo největší prvek,
    // algoritmus by se zpomalil na kvadratickou složitost.
    // Nejjednoduší výběr pivota je zvolit střední hodnotu z pole. Existuje i varianta, který index pivota vybírá náhodně.

    // Quick sort není ani adaptabilní, ani stabilní. Ale díky metodě rozděl a panuj má průměrnou složitost O(n) = n * log n. Rozdělení
    // pole na dvě části má lineární složitost a log n je složitost postupného dělení na poloviny.

    // V nejhorším případě je ale složitost O(n) = n^2, pokud je pole již seřazené a zvolíme nejmenší nebo největší prvek jako pivot.
    public static class QuickSort
    {
        public static void SeradPrvky(int[] pole)
        {
            SeradPrvkyRekurzivne(pole, 0, pole.Length - 1);
        }

        private static void SeradPrvkyRekurzivne(int[] pole, int levyIndex, int pravyIndex)
        {
            // Koncová podmínka rekurze, pokud má výřez pole nulovou velikost, nemá smysl ho řadit
            if (levyIndex < pravyIndex)
            {
                // Vyber pivota
                var pivotIndex = VyberPivotIndex(levyIndex, pravyIndex);

                // Rozděl pole na dvě části, levou a pravou, kde levá je menší než pivot a pravá větší než pivot
                pivotIndex = RozdelPole(pole, levyIndex, pravyIndex, pivotIndex);

                // Rekurzivně volej metodu pro levou a pravou část pole
                // Pivot se nezapočítá ani do jednoho volání - již je na správném místě
                SeradPrvkyRekurzivne(pole, levyIndex, pivotIndex - 1);
                SeradPrvkyRekurzivne(pole, pivotIndex + 1, pravyIndex);
            }
        }

        private static int VyberPivotIndex(int levyIndex, int pravyIndex)
        {
            // Můžeme vybrat libovolný index, pro dobrý výkon v už seřazených polých je dobré vybrat prvek uprostřed
            return levyIndex + (pravyIndex - levyIndex) / 2;
        }

        private static int RozdelPole(int[] pole, int levyIndex, int pravyIndex, int pivotIndex)
        {
            // Uložíme si hodnotu pivota pro porovnávání
            var pivotHodnota = pole[pivotIndex];

            // Uklidíme si pivot na konec
            VymenPrvky(pole, pivotIndex, pravyIndex);

            // Hledáme nový index pivotu - nastavíme ho na levý index
            var novyPivotIndex = levyIndex;

            // Projdeme celé pole kromě posledního prvku, zde víme, že je pivot
            for (var i = levyIndex; i < pravyIndex; i++)
            {
                // Pokud je hodnota aktuálního prvku menší než pivot
                if (pole[i] < pivotHodnota)
                {
                    // Vyměníme ho s aktuálním indexem nového pivotu a posuneme index nového pivotu
                    VymenPrvky(pole, i, novyPivotIndex);
                    novyPivotIndex++;
                }
            }

            // Vrátíme uklizený pivot na správné místo
            VymenPrvky(pole, novyPivotIndex, pravyIndex);

            return novyPivotIndex;
        }

        private static void VymenPrvky(int[] pole, int indexA, int indexB)
        {
            var mezihodnota = pole[indexA];
            pole[indexA] = pole[indexB];
            pole[indexB] = mezihodnota;
        }
    }
}