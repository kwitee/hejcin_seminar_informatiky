﻿using System.IO;
using System;

namespace VyjimkyVyklad
{
    public static class Vyjimky
    {
        public static void CoJeToVyjimka()
        {
            // Výjimka prostředek pro komunikaci chyb nebo nepředvýdatelných stavů.
            // Signalizujeme, že program za těchto okolností nemůže pokračovat, nebo že nemůžeme
            // vrátit smysluplnou hodnotu výpočtu.

            // Výjimky se reprezentují pomocí instancí třídy Exception, nebo jeho potomků (dědičnost).

            // Příklad:
            // Co by měl program vrátit při celočíselném dělení nulou?
            var delitel = 0;
            var delenec = 5;
            var podil = delenec / delitel;

            // Další příklady:
            // Co by měl dělat program, který má smazat soubor, ale soubor neexistuje?
            // Co by měl dělat program, který se má připojit k Internetu, ale připojení nefunguje?
        }

        public static void TypyVyjimek()
        {
            // Výjimek je mnoho typů (potomků třídy Exception), typ výjimky se používá k popsání oblasti problému.

            new Exception();

            new ArgumentException();
            new ArgumentNullException();
            new ArgumentOutOfRangeException();

            new IOException();
            new FileNotFoundException();
            new DirectoryNotFoundException();

            new ArithmeticException();
            new DivideByZeroException();
            new OverflowException();
        }

        public static void VyhazovaniVyjimek()
        {
            // Pokud chceme signalizovat vyjímku, musíme ji tzv. vyhodit.
            // Při vyhození výjimky program okamžitě přestane vykonávat kód v daném bloku (protože jsme signalizovali,
            // že nemůžeme pokračovat).

            // Používáme klíčové slovo throw + instance třídy Exception (nebo jeho potomka).

            throw new ArgumentException("Zadaná hodnota musí být větší než 0.");
        }

        public static void OdchytavaniVyjimek()
        {
            // Vyjimky lze "odchytávat" pomocí bloku try-catch (zkus provést následující kód).

            // POZOR: každá neodchycená výjimka vede k předčasnému ukončení programu! To ale někdy chceme,
            // ne každá výjimka je možná korektně ošetřit.

            // Např. OutOfMemoryException signalizuje, že našemu programu došla paměť. Není mnoho věcí, co bychom
            // mohli uvnitř programu dělat, abychom tuto situaci vyřešili.

            // Výjimku si tedy můžeme i představit jako skok na nejbližší catch blok (ve smyslu toku programu) -
            // pokud neexistuje, program je ukončen.

            // Příkladem zpracování výjimky může být např. informace pro uživatele, že jeho zadaná hodnota je špatná
            // a že musí hodnotu zadat znovu.

            while (true)
            {
                try
                {
                    Console.WriteLine("Zadej celé číslo:");
                    var hodnota = int.Parse(Console.ReadLine());

                    break;
                }
                catch
                {
                    Console.WriteLine("Zadané hodnota nebylo celé číslo, zkus to znovu.");
                }
            }
        }

        public static void OdchytavaniVyjimkyDleTypu()
        {
            // Výjimky můžeme i filtrovat dle typu, následující kód odchytí pouze výjimku typu ArgumentException
            try
            {
                // ....
            }
            catch(ArgumentException)
            {
                // ...
            }

            // Můžeme si nadeklarovat i proměnnou, do které se výjimka uloží (v tomto případě je typ povinný)
            try
            {
                throw new ArgumentException("Něco se pokazilo!");
            }
            catch (ArgumentException exception)
            {
                // Každá výjimka obsahuje dvě základní vlastnosti:
                // - String Message, která popisuje problém ve větším detailu
                // - String StackTrace, který obsahuje informaci o tom, odkud výjimka pochází
                Console.WriteLine("Message:");
                Console.WriteLine(exception.Message);
                Console.WriteLine();
                Console.WriteLine("Stack trace:");
                Console.WriteLine(exception.StackTrace);
                Console.WriteLine();
            }
        }
    }
}