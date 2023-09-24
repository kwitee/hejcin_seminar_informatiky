namespace RadiciAlgoritmy;

public static class VymenaPrvkuUkol
{
    // Vytvoř funkci, která vezme jako parametr pole a dva indexy.
    // Tato funkce by měla vyměnit prvky pole na těchto dvou indexech.
    // Příklad: {1, 2} s indexy 0 a 1 -> {2,1}
    public static void VymenPrvky(int[] pole, int indexA, int indexB)
    {
        var mezihodnota = pole[indexA];
        pole[indexA] = pole[indexB];
        pole[indexB] = mezihodnota;
    }

    public static void TestovaciFunkce()
    {
        var pole = new int[] {1, 2, 3, 4};
        Console.WriteLine("Pole před výměnou:");
        VypisPole(pole);

        var indexA = 1;
        var indexB = 2;
        Console.WriteLine($"Vyměníme prvky s indexy {indexA} a {indexB}.");
        VymenPrvky(pole, indexA, indexB);

        Console.WriteLine("Pole po výměně:");
        VypisPole(pole);
    }

    private static void VypisPole(int[] pole)
    {
        foreach (var hodnota in pole)
        {
            Console.WriteLine(hodnota);
        }
    }
}