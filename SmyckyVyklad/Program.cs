using System;
using System.Collections.Generic;

namespace SmyckyVyklad
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Klíčové slovo var
            {
                KlicoveSlovoVar.Ukazka();
            }

            // Smycky
            {
                Smycky.SmyckaWhile();
                Smycky.SmyckaFor();
                Smycky.SmyckaForeach();
                Smycky.KlicoveSlovoBreak();
                Smycky.KlicoveSlovoContinue();
            }

            // Pole a List
            {
                // Pole jsou statická, tzn. velikost pole je daná při jeho vytvoření a nelze ji měnit
                var pole = new int[] { 1, 2, 3, 4, 5 };

                // List je dynamický, tzn. jeho velikost se může měnit
                // Pro použití pole musíme naimportovat namespace System.Collections.Generic
                // Deklarace listu je dost podobná poli
                var list = new List<int> {1, 2, 3, 4, 5};

                // Přidání prvku do pole
                list.Add(6);

                // Odebírat můžeme např. pomocí indexu, tzn. zde odebereme první prvek
                list.RemoveAt(0);
            }

            Console.WriteLine("Stiskni libovolnou klávesu na ukončení programu.");
            Console.ReadKey();
        }
    }
}