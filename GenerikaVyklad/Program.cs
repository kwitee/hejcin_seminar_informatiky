﻿using System;

namespace GenerikaVyklad
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Generika je mechanismus, který umožňuje říct C# překladači "tady je nějaký libovolný typ,
            // který se bude používat v kódu". Typ se bude specifikovat až v momentě, kdy se bud kód volat.

            // Generika se definuje pomocí ostrých závorek <>. V nich uvedeme název "proměnné".
            // Dle konvence se používá název T (jako type), ale můžeme použít libovolný název.

            // Příklad: List<T> je generická třída, která umožňuje ukládat libovolný typ do seznamu.
            // Programátoři listu nemuseli brát v úvahu všechny možné typy, použili generický typ T.

            // T také můžeme chápat jako "proměnnou", která nese informaci o typu, který se bude používat.

            // Generický typ můžeme použít u metody nebo třídy. V případě metody je pak nutné typ uvést u volání metody,
            // v případě třídy je nutné typ uvést při vytváření instance třídy (volání konstruktoru).
        }

        // Generická metoda, která vypíše libovolnou hodnotu do konzole
        // Typ T je specifikován až v momentě volání metody
        public static void Vypis<T>(T hodnota)
        {
            Console.WriteLine(hodnota);
        }
    }

    // Generická třída, která umožňuje ukládat libovolný typ do seznamu
    // Typ T je specifikován až v momentě vytváření instance třídy
    public class Seznam<T>
    {
        // Datový typ T můžeme použít kdekoliv v těle třídy
        public void Pridej(T hodnota)
        {
        }
    }
}