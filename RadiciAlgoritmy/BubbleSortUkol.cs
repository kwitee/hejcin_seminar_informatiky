namespace RadiciAlgoritmy;

public static class BubbleSortUkol
{
    // Naprogramujte jeden průchod algoritmu buble sort:
    // Projděte pole po prvcích a ověřte, zda je následující prvek větší nebo roven, pokud ne. Tak
    // prvky pomocí funkce VymenPrvky vyměňte.
    public static void BubbleSortPruchod(int[] pole)
    {
        for (int i = 0; i < pole.Length - 1; i++)
        {
            if (pole[i] > pole[i + 1])
            {
                VymenPrvky(pole, i, i + 1);
            }
        }
    }

    public static void TestovaciFunkce()
    {
        var pole = new int[] { 1, 2, 3, 4, -5 };

        VypisPole(pole);
        BubbleSortPruchod(pole);
        VypisPole(pole);
    }

    public static void VymenPrvky(int[] pole, int indexA, int indexB)
    {
        var mezihodnota = pole[indexA];
        pole[indexA] = pole[indexB];
        pole[indexB] = mezihodnota;
    }

    private static void VypisPole(int[] pole)
    {
        foreach (var hodnota in pole)
        {
            Console.WriteLine(hodnota);
        }
    }
}