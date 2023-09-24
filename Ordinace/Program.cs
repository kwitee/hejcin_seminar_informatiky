namespace Ordinace;

internal class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Write("Vyberte operaci (R - registrace, K - konec):");
            var operace = Console.ReadLine();

            if (operace == "R")
            {
                VytvorPacienta();
            }
            else if (operace == "K")
            {
                break;
            }
            else
            {
                Console.WriteLine("Neplatná operace.");
            }
        }
    }

    private static List<Pacient> kontejnerPacientu = new List<Pacient>();

    private static void VytvorPacienta()
    {
        Console.WriteLine("Zadej jmeno: ");
        var jmeno = Console.ReadLine();

        Console.WriteLine("Zadej vahu v kilogramech: ");
        var vaha = double.Parse(Console.ReadLine());

        Console.WriteLine("Zadej vysku v centimetrech: ");
        var vyska = double.Parse(Console.ReadLine());

        Console.WriteLine("Zadej vek: ");
        var vek = int.Parse(Console.ReadLine());

        var pacient = new Pacient(jmeno, vaha, vyska, vek);
        kontejnerPacientu.Add(pacient);

        UlozPacienta(pacient);
    }

    private static string kartotekaSoubor = "kartoteka.txt";

    private static void UlozPacienta(Pacient pacient)
    {
        var pacientText = $"{pacient.Jmeno}/{pacient.Vaha}/{pacient.Vyska}/{pacient.Vek}";

        File.AppendAllText(kartotekaSoubor, pacientText);
    }

    private static Pacient PrectiPacienta(string pacientText)
    {
        var pacientUdaje = pacientText.Split('/');

        var jmeno = pacientUdaje[0];
        var vaha = double.Parse(pacientUdaje[1]);
        var vyska = double.Parse(pacientUdaje[2]);
        var vek = int.Parse(pacientUdaje[3]);

        return new Pacient(jmeno, vaha, vyska, vek);
    }
}