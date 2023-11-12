using System;

namespace DynamickePole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vytvoříme nové pole stringů s kapacitou 3.");
            var dynamickePole = new DynamickePole<string>(3);
            Console.WriteLine();

            Console.WriteLine("Počet prvků by měl být 0.");
            Console.WriteLine(dynamickePole.PocetPrvku);
            Console.WriteLine();

            Console.WriteLine("Přidáme 5 prvků.");
            dynamickePole.PridejPrvek("Prvek0");
            dynamickePole.PridejPrvek("Prvek1");
            dynamickePole.PridejPrvek("Prvek2");
            dynamickePole.PridejPrvek("Prvek3");
            dynamickePole.PridejPrvek("Prvek4");
            Console.WriteLine();

            Console.WriteLine("Počet prvků by měl být 5.");
            Console.WriteLine(dynamickePole.PocetPrvku);
            Console.WriteLine();

            Console.WriteLine("Vrať všechny prvky dle jejich indexů.");
            VypisPole(dynamickePole);
            Console.WriteLine();

            Console.WriteLine("Smaž 2 prvky dle jejich indexů (1, 3).");
            dynamickePole.VymazPrvek(1);
            dynamickePole.VymazPrvek(3);
            Console.WriteLine();

            Console.WriteLine("Vrať všechny prvky dle jejich indexů.");
            VypisPole(dynamickePole);
            Console.WriteLine();

            Console.WriteLine("Stiskni libovolnou klávesu pro konec.");
            Console.ReadKey();
        }

        private static void VypisPole(DynamickePole<string> dynamickePole)
        {
            for (int i = 0; i < dynamickePole.PocetPrvku; i++)
            {
                Console.WriteLine($"Prvek na indexu {i} je {dynamickePole.VratPrvek(i)}.");
            }
        }
    }
}