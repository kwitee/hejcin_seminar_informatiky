﻿using System.Collections.Generic;

namespace ObjektyATridyVyklad
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Co je to objektově orientované programování
            {
                // Objektově orientované programování (OOP) tvoří strukturu programu pomocí objektů a tříd.
                // Snaží se napodobit způsob, jakým lidé chápou svět kolem sebe. Vidíme objekty, které mají nějaké vlastnosti
                // a nějaké chování. Vlastnosti a chování objektů je neoddělitelné.

                // Příklad: pes má barvu, jméno a štěká. Nemůžeme např. vytvořit psa bez barvy.
            }

            // Třídy a objekty
            {
                // Třída je obecná kategorie (typ, vzor), podle které se vytváří konkrétní objekty. Říkáme, že objekt je instancí třídy.
                // Pro vytvoření objektu se používa speciální metoda - konstruktor.

                // Příklady tříd: pes, kočka, zaměstnanec, auto.
                // Příklady objektů: pes Alík, kočka Míša, zaměstnanec Petr Novák

                // Třídy jsou statické, existují po celou dobu běhu programu. Objekty jsou dynamické, mohou vznikat a zanikat 
                // za běhu.
            }

            // Klíčové slovo static
            {
                // Klíčové slovo static určuje, že daná vlastnost nebo chování se váže k třídě a ne k objektu.
                // Nejde tedy o vlastnost konkrétního objektu, ale o vlastnost která platí pro celou kategorii objektů.

                // U tříd klíčové slovo static říká, že daná třída nemůže být použita jako šablona pro vytváření objektů.
            }

            // Zapouzdření
            {
                // Třídy mohou mít vnitřní stav, který je neviditelný nebo neměnný zvenčí.
                // Používáme modifikátory přístupu: public, private...

                // Zapouzdření nám umožňuje, aby objekty byly vnitřně konzistentní.
                // Příklad: máme třídu nákupní košík, ta má metodu pro přidání položky a vlastnost pro celkovou cenu.
                // Pokud přidáme novou položku do košíku, ale nezvýšíme cenu, vytvořili jsme nekonzistentní stav.
            }

            // Vztahy mezi třídami - kompozice
            {
                // Jedna třída obsahuje jinou (používáme slovíčko "má"). Tento vztah se nazývá kompozice - skládání.
                // Můžeme takto skládat objekty jako lego kostky.
                // Příklad: třída auto má třídu motor a třídu převodovka.
            }

            // Vztahy mezi třídami - dědičnost
            {
                // Jedna třída je generalizací jiné třídy (používáme slovíčko "je"). Tento vztah se nazývá dědičnost: předek -> potomek.
                // Příklad: třída auto je generalizace třídy vozidlo. Další generalizace je motorka nebo vlak.

                // Potomci mohou třídu dále rozšiřovat o další vlastnosti a chování.
                // Každé vozidlo má několik kol, ale pouze auto má volant. Motorka má řídítka atd.

                // Protože každé auto zároveň >je< vozidlo, můžeme vytvořit proměnnou typu vozidlo a do ní uložit objekt typu auto.
                // Opačně to ale nejde, ne každé vozidlo >je< auto.
            }

            // Typová zaměnitelnost - polymorfismus
            {
                // Protože každé auto >je< současně vozidlem, můžeme např. vytvořit seznam vozidel a do něj uložit auta.
                // Pro tuto typovou zaměnitelnost se používá termín polymorfismus: jeden typ se může "vydávat" za jiný.

                var vozidla = new List<Vozidlo>
                {
                    new Auto(),
                    new Motorka()
                };

                // Zde prijmeme libovolné vozidlo, třeba i vlak
                void PridejVozidlo(Vozidlo vozidlo)
                {
                    vozidla.Add(vozidlo);
                }

                // Zde prijmeme pouze auto
                void PridejAuto(Auto auto)
                {
                    vozidla.Add(auto);
                }
            }

            // Hierarchie tříd
            {
                // Vztahy mezi třídami můžeme dále libovolně kombinovat a vytvářet tzv. hierarchie tříd.
                // Vozidlo -> MotoroveVozidlo -> Auto, Motorka
                // Každé Vozidlo má kola, každé motorové vozidlo má motor, každé auto má převodovku atd.
            }
        }

        class Vozidlo
        {
        }

        class Auto : Vozidlo
        {
        }

        class Motorka : Vozidlo
        {
        }
    }
}