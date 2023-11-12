using System;

namespace Fronta
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var fronta = new Fronta<int>();

            Console.WriteLine("Přidáme 3 hodnoty do fronty: 1, 2, 3");
            fronta.Enqueue(1);
            fronta.Enqueue(2);
            fronta.Enqueue(3);
            Console.WriteLine($"Počet prvků ve frontě: {fronta.PocetPrvku}.");
            Console.WriteLine();

            Console.WriteLine("Přidáme další 3 hodnoty do fronty: 4, 5, 6");
            fronta.Enqueue(4);
            fronta.Enqueue(5);
            fronta.Enqueue(6);
            Console.WriteLine($"Počet prvků ve frontě: {fronta.PocetPrvku}.");
            Console.WriteLine();

            Console.WriteLine("Odebereme všechny hodnoty z fronty:");

            while (fronta.PocetPrvku > 0)
            {
                Console.WriteLine($"Další prvek na řadě: {fronta.Peek()}");
                Console.WriteLine($"Odebraná hodnota: {fronta.Dequeue()}");
            }

            Console.WriteLine();
            Console.WriteLine("Stiskni livovolnou klávesu pro konec.");
            Console.ReadKey();
        }
    }
}