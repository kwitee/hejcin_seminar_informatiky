namespace RadiciAlgoritmy;

public class VyhledavaniUkol
{
    // Napište funkci, která rozhodne zda se daný prvek nachází v daném poli.
    // K řešení použijte smyčku foreach
    public static bool JePrvekVPoli(int prvek, int[] pole)
    {
        // Dala by se funkce nějak vylepšit?

        bool jePrvekVPoli = false;

        foreach (var hodnota in pole)
        {
            if (hodnota == prvek)
            {
                jePrvekVPoli = true;
            }
        }

        return jePrvekVPoli;
    }

    public static void TestovaciFunkce()
    {
        var pole = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        Console.WriteLine(JePrvekVPoli(1, pole)); // true
        Console.WriteLine(JePrvekVPoli(-1, pole)); // false
        Console.WriteLine(JePrvekVPoli(9, pole)); // true
        Console.WriteLine(JePrvekVPoli(11, pole)); // false
    }
}