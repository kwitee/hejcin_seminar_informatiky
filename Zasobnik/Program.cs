using System;

namespace Zasobnik
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var zasobnik = new Zasobnik<int>();

            Console.WriteLine("Pushneme 3 hodnoty do zásobníku: 1, 2, 3");
            zasobnik.Push(1);
            zasobnik.Push(2);
            zasobnik.Push(3);
            Console.WriteLine($"Počet prvků v zásobníku: {zasobnik.PocetPrvku}.");
            Console.WriteLine();

            Console.WriteLine("Pushneme další 3 hodnoty do zásobníku: 4, 5, 6");
            zasobnik.Push(4);
            zasobnik.Push(5);
            zasobnik.Push(6);
            Console.WriteLine($"Počet prvků v zásobníku: {zasobnik.PocetPrvku}.");
            Console.WriteLine();

            Console.WriteLine("Odebereme všechny hodnoty ze zásobníku:");

            while (zasobnik.PocetPrvku > 0)
            {
                Console.WriteLine($"Vrchní hodnota: {zasobnik.Peek()}");
                Console.WriteLine($"Odebraná hodnota: {zasobnik.Pop()}");
            }

            Console.WriteLine();
            Console.WriteLine("Stiskni livovolnou klávesu pro konec.");
            Console.ReadKey();
        }
    }
}