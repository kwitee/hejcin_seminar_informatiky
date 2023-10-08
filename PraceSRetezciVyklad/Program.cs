using System;

namespace PraceSRetezciVyklad
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Datový typ string a char
            {
                // Pro práci s textovými řetězci slouží třída String
                // Řetězec je pole znaků, pro znak používáme datový typ char

                // Pro vytvoření řetězce používáme dvojité uvozovky
                string jmeno = "Ondřej Květ";

                // Pro znaky jednoduché uvozovky
                char pismeno = 'O';

                // Textové řetězce můžeme indexovat a získat znaky, jako by to bylo pole
                char prvniZnak = jmeno[0];
                Console.WriteLine(prvniZnak);

                // Pro procházení celého textového řetězce můžeme použít i cyklus foreach
                foreach (char znak in jmeno)
                {
                    Console.WriteLine(znak);
                }
            }

            // Práce s řetězci
            {
                // Práce s textovými řetězci patří mezi nejčastější programátorské činnosti
                // Třída string obsahuje mnoho užitečných funkcí:

                // Rozděl řetězec podle nějakého oddělujícího znaku
                string jmena = "Ondřej;Petr;Jana;Marie";
                string[] jmenaVPoli = jmena.Split(';');

                // Sesterská funkce k funkci Split se jmenuje Join, ta zase umožňuje spojit pole různých
                // datových typů do jednoho textového řetězce
                int[] hodnoty = { 1, 2, 3, 4, 5 };
                string spojeneHodnoty = string.Join(", ", hodnoty);
                Console.WriteLine(spojeneHodnoty);

                // Metoda StartsWith zjistí, zda řetězec začíná nějakým jiným řetězcem
                string jmeno = "Gymnázium Hejčín";
                bool zacinaNaGymnazium = jmeno.StartsWith("Gymnázium");

                // Sesterská funkce je EndsWith
                bool konciNaHejcin = jmeno.EndsWith("Hejčín");
            }

            Console.WriteLine("Stiskněte libovolnou klávesu pro konec.");
            Console.ReadKey();
        }
    }
}