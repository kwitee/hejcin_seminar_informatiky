using System.Collections.Generic;

namespace AbstraktniDatoveTypyVyklad
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Co jsou to abstraktní datové typy (ADT)
            {
                // Abstraktní datové typy jsou dynamické datové struktury, které jsou definovány pomocí operací, které nad nimi můžeme provádět.
                // Hlavním cílem abstraktních datových typů je skrýt implementaci datové struktury - tedy jakým způsobem jsou data fyzicky uložena.

                // Základní ADT:
                // Seznam (list)
                // Zásobník (stack)
                // Fronta (queue)
                // Halda (heap)
                // Mapa (map)
                // Množina (set)
                // Strom (tree)
            }

            // Seznam (lineární seznam, lineární spojový seznam, linked list)
            {
                // Seznam je dynamická datová struktura, která je tvořena uzly, které jsou spojeny pomocí ukazatelů.
                // Každý prvek seznamu obsahuje data a ukazatel na další prvek seznamu.
                // Existuje i varianta dvojitě spojeného seznamu (double linked list), kde každý prvek obsahuje ukazatel na předchozí i
                // následující prvek seznamu.

                // Příklad využití: seznam kontaktů v telefonu, seznam položek v košíku v e-shopu

                // Možné operace nad seznamem:
                // Vložení prvku na konec seznamu
                // Modifikace prvku na libovolném indexu
                // Zjištění počtu prvků v seznamu
                // Přečtení hodnoty prvku na libovolném indexu
                // Odebrání prvku na libovolném indexu

                // V C# je seznam implementován pomocí třídy List<T> z jmenného prostoru System.Collections.Generic
                var list = new List<int>();
                list.Add(5); // Vložení prvku na konec seznamu
                var hodnota = list[0]; // Přečtení hodnoty prvku na libovolném indexu
                list[0] = 10; // Modifikace prvku na libovolném indexu
                list.RemoveAt(0); // Odebrání prvku na libovolném indexu
                var pocet = list.Count; // Zjištění počtu prvků v seznamu
            }

            // Zásobník (stack)
            {
                // Zásobník je dynamická datová struktura, která umožňuje vkládání a odebírání prvků pouze na začátku.
                // Poslední vložený prvek do zásobníku je také první odebraný prvek (jako zásobník u zbraně).
                // Říkáme, že zásobník pracuje podle principu LIFO (last in, first out).

                // Příklad využití: zásobník výpočtu výrazů, zásobník pro ukládání historie v prohlížeči

                // Možné operace nad zásobníkem:
                // Vložení prvku na vrchol zásobníku (push)
                // Odebrání prvku z vrcholu zásobníku (pop)
                // Přečtení hodnoty prvku na vrcholu zásobníku - bez odebrání (peek, top)
                // Zjištění počtu prvků v zásobníku

                // V C# je zásobník implementován pomocí třídy Stack<T> z jmenného prostoru System.Collections.Generic
                var stack = new Stack<int>();
                stack.Push(5); // Vložení prvku na vrchol zásobníku
                var hodnota = stack.Pop(); // Odebrání prvku z vrcholu zásobníku
                hodnota = stack.Peek(); // Přečtení hodnoty prvku na vrcholu zásobníku - bez odebrání
                var pocet = stack.Count; // Zjištění počtu prvků v zásobníku
            }

            // Fronta (queue)
            {
                // Fronta je dynamická datová struktura, která umožňuje vkládání prvků na konec a odebírání prvků z začátku.
                // První vložený prvek do fronty je také první odebraný prvek (jako fronta u pokladny).
                // Říkáme, že fronta pracuje podle principu FIFO (first in, first out).

                // Příklad využití: fronta pro zpracování požadavků na serveru, fronta pro tisk dokumentů
                // Fronty se obecně používají, pokud máme dva programy s různou rychlostí zpracování dat. Mezi nimi je fronta, která
                // vyrovnává tyto rychlosti (této frontě se říká buffer - vyrovnávací paměť).

                // Možné operace nad frontou:
                // Vložení prvku na konec fronty (enqueue)
                // Odebrání prvku z začátku fronty (dequeue)
                // Přečtení hodnoty prvku na začátku fronty - bez odebrání (front, peek)
                // Zjištění počtu prvků ve frontě

                // V C# je fronta implementována pomocí třídy Queue<T> z jmenného prostoru System.Collections.Generic
                var queue = new Queue<int>();
                queue.Enqueue(5); // Vložení prvku na konec fronty
                var hodnota = queue.Dequeue(); // Odebrání prvku z začátku fronty
                hodnota = queue.Peek(); // Přečtení hodnoty prvku na začátku fronty - bez odebrání
                var pocet = queue.Count; // Zjištění počtu prvků ve frontě
            }
        }
    }
}