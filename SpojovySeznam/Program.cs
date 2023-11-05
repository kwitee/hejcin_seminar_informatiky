using System;

namespace SpojovySeznam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vytvoříme nový seznam stringů.");
            var seznam = new Seznam<string>();
            Console.WriteLine();

            Console.WriteLine("Počet prvků by měl být 0.");
            Console.WriteLine(seznam.DejPocetPrvku());
            Console.WriteLine();

            Console.WriteLine("Přidáme 5 prvků.");
            seznam.PridejPrvek("Prvek0");
            seznam.PridejPrvek("Prvek1");
            seznam.PridejPrvek("Prvek2");
            seznam.PridejPrvek("Prvek3");
            seznam.PridejPrvek("Prvek4");
            Console.WriteLine();

            Console.WriteLine("Počet prvků by měl být 5.");
            Console.WriteLine(seznam.DejPocetPrvku());
            Console.WriteLine();

            Console.WriteLine("Vrať všechny prvky dle jejich indexů.");
            VypisSeznam(seznam);
            Console.WriteLine();

            Console.WriteLine("Smaž 2 prvky dle jejich indexů (1, 3).");
            seznam.VymazPrvek(1);
            seznam.VymazPrvek(3);
            Console.WriteLine();

            Console.WriteLine("Vrať všechny prvky dle jejich indexů.");
            VypisSeznam(seznam);
            Console.WriteLine();

            Console.WriteLine("Změň hodnotu 1. prvku.");
            seznam.ZmenPrvek(0, "ZmenenyPrvek0");
            Console.WriteLine();

            Console.WriteLine("Vrať všechny prvky dle jejich indexů.");
            VypisSeznam(seznam);
            Console.WriteLine();

            Console.WriteLine("Stiskni libovolnou klávesu pro konec.");
            Console.ReadKey();
        }

        private static void VypisSeznam(Seznam<string> seznam)
        {
            for (int i = 0; i < seznam.DejPocetPrvku(); i++)
            {
                Console.WriteLine($"Prvek na indexu {i} je {seznam.VratPrvek(i)}.");
            }
        }
    }
}