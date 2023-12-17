﻿using System;
using System.Collections.Generic;

namespace DatoveTypyVyklad
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // C# je staticky typovaný jazyk, že každá hodnota má přiřazen datový typ, který se nesmí měnit.
            // C# má dva základní typy datových typů: hodnotové (primitivní) a referenční.

            // Hodnotové typy
            {
                // Hodnotové typy se používají pro ukládání jednoduchých hodnot, které nezabírají mnoho místa v paměti.
                // Hodnotové typy jsou vždy inicializovány na výchozí hodnotu (nikdy nemohou být null).
                // Příklady hodnotových typů: bool, int, char, double, double, float.
                // Hodnotové typy se vždy předávájí kopií, tzn. pokud např. voláme funkci s argumentem typu int, tak
                // je tato hodnota fyzicky zkopírována do funkce a jen ta s ní pracuje.
            }

            // Referenční typy
            {
                // Referenční typy se používají pro ukládání složitějších dat, které mohou zabírat více místa v paměti.
                // Referenční typy jsou vždy inicializovány na null.
                // Příklady referenčních typů: List, pole, jakákoliv instance třídy.
                // Referenční typy se vždy předávají referencí, tzn. pokud např. voláme funkci s argumentem typu string,
                // tak sdílíme referenci na stejný string a všechny změny se projeví i mimo funkci.

                void ChangeList(List<int> list)
                {
                    list.Add(5);
                }

                var seznam = new List<int>();
                ChangeList(seznam); // Reference na seznam je předána do funkce ChangeList, která přidá hodnotu 5 do seznamu.
                Console.WriteLine(seznam.Count); // Vypíše 1, protože změna v metodě ChangeList se projevila i mimo metodu.

                Console.WriteLine("Stiskni libovolnou klávesu pro konec.");
                Console.ReadKey();
            }

            // Textový řetězec - string
            {
                // String je referenční typ, který se chová speciálně. Je to referenční typ, který se chová v mnoha případech jako hodnotový.
                // String je v C# nezměnitelný (immutable), tzn. že každá změna vytvoří nový string a původní string zůstane nezměněný.

                void ChangeString(string str)
                {
                    str += " světe!";
                }

                var retezec = "Ahoj";
                ChangeString(retezec);
                Console.WriteLine(retezec); // Vypíše pouze "Ahoj", protože modifikace v metodě ChangeString vytvořila nový string.
            }

            // Přetypování hodnotových typů - casting
            {
                // Přetypování je proces, kdy změníme hodnotu z jednoho datového typu na jiný.
                // Přetypování z typu s nižší přesností na typ s vyšší přesností je možné dělat automaticky - implicitní přetypování.
                // char -> int -> long -> float -> double

                int intHodnota = 5;
                double doubleHodnota = intHodnota; // Implicitní přetypování z int na double.

                // Přetypování z typu s vyšší přesností na typ s nižší přesností je nutné dělat ručně - explicitní přetypování.
                // Zde totiž dochází ke ztrátě informace.
                // double -> float -> long -> int -> char

                double doubleHodnota2 = 5.5;
                int intHodnota2 = (int) doubleHodnota2; // Explicitní přetypování z float na int.
            }

            // Doplněk - matematické operace
            {
                // Matematické operace nad hodnotovými typy vždy vrací stejný typ, jako je typ operandů.

                int a = 5;
                int b = 2;

                // Tato vlastnost nás může překvapit např. u dělení dvou celých čísel.

                var vysledekCelociselne = a / b; // Vysledek je 2, protože oba operandy jsou typu int.

                // Pokud chceme, aby výsledek byl typu double, musíme a nebo b přetypovat na double.
                var vysledek = (double) a / b;
            }

            // Parsování stringů
            {
                // Parsování je proces, kdy převedeme string na jiný datový typ.
                // Při parsování může dojít k výjimce, pokud je string ve špatném formátu.
                // Formát stringu je také dán aktuální lokalizací (např. čestina má jiná pravidla na formátování desetinných oddělovačů než angličtina).

                string str = "5";
                int cislo = int.Parse(str); // Parsování stringu na int.
            }

            // Přetypování referenčních typů - klíčová slova is a as
            {
                // Přetypování referenčních typů je možné pomocí klíčových slov is a as.
                // Klíčové slovo is vrací true, pokud je objekt typu, na který se ptáme.
                // Klíčové slovo as vrací objekt přetypovaný na daný typ, pokud je objekt typu, na který se ptáme, jinak vrací null.
                // Tento způsob přetypování je bezpečný, nikdy nedojde k výjimce.

                object obj = "Ahoj";

                if (obj is string) // Vrátí true, pokud je hodnota typu string.
                {
                    string str = obj as string; // Přetypuje obj na string, pokud je obj typu string, jinak vrací null.
                }
            }

            // Defaultní hodnota typu
            {
                // Každý datový typ má defaultní hodnotu, která je přiřazena, pokud není hodnota explicitně přiřazena.
                // Pro všechny referenční typy je defaultní hodnota null.
                // Pro číselné typy je defaultní hodnota 0.
                // Pro bool je defaultní hodnota false.

                // Defaultní hodnotu můžeme získat pomocí klíčového slova default.
                int a = default;

                // Default se dá zavolat i jako funkce.
                var boolean = default(bool);
            }

            Console.WriteLine("Stiskni libovolnou klávesu pro konec.");
            Console.ReadKey();
        }
    }
}