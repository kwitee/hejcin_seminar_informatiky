using System.Collections.Generic;

namespace ObjektyATridyVyklad
{
    internal class Program
    {
        public class BankovniUcet
        {
            // Vlastnosti účtu
            public string JmenoMajitele;
            public int CisloUctu;
            public double Zustatek;

            // Metody účtu - chování
            public void VlozPenize(double castka)
            {
                this.Zustatek += castka;
            }

            public void VyberPenize(double castka)
            {
                this.Zustatek -= castka;
            }
        }

        public class Pracovnik
        {
            // Veřejné vlastnosti pracovníka
            public string Jmeno;
            public string Prijmeni;
            public string Pozice;

            // Statická vlastnost pracovníka, je stejná pro všechny pracovníky
            public static string Organizace;

            // Soukromá vlasnost pracovníka
            private double Plat;
        }

        static void Main(string[] args)
        {
            // Co je to OOP
            {
                // Objektové programování modeluje problém pomocí objektů a jejich vzájemných vztahů.
                // Objekt může být jakákoliv reálná věc nebo abstraktní entita, která má nějaké vlastnosti a chování.
                // Příklady: auto, pracovník, bankovní účet, kreditní karta...
            }

            // Co je to třída
            {
                // Třída je šablona, podle které se vytváří objekty. Říkáme tedy, že objekt je instancí třídy.

                var ucet = new BankovniUcet();
            }

            // Klíčové slovo static
            {
                // Klíčové slovo static určuje, že daná vlastnost nebo chování se váže ke třídě a ne k objektu.
                // Znamená to tedy, že všechny objekty dané třídy budou sdílet stejnou static hodnotu/metodu.

                // U tříd klíčové slovo static říká, že daná třída nemůže být použita jako šablona pro vytváření objektů.
            }

            // Modifikátory přístupu - public a private
            {
                // Některé vlastnosti nebo chování objektů jsou veřejné, to znamená, že jakýkoliv jiný objekt je může volat nebo použít.
                // Jiné vlastnosti nebo chování mohou být soukromé - tajné a jenom objekty dané třídy k nim mohou přistupovat.

                // Metodika, která rozděluje vlastnosti tříd na veřejné a ty, které definují vnitřní stav se nazývá zapouzdření.
            }

            // Vztahy mezi třídami
            {
                // Jedna třída obsahuje jinou (používáme slovíčko "má"). Tento vztah se nazývá kompozice - skládání.
                // Můžeme takto skládat objekty jako lego kostky.
                // Příklad: třída auto má třídu motor a třídu převodovka.

                // Jedna třída je generalizace třídy jiné (používáme slovíčko "je"). Tento vztah se nazývá dědičnost: předek -> potomek.
                // Příklad: třída auto je generalizace třídy vozidlo. Třída motorka je další generalizace této třídy.

                // Protože každé auto zároveň "je" vozidlo, můžeme vytvořit proměnnou typu vozidlo a do ní uložit auto.
                // Opačně to ale nejde, ne každé vozidlo je auto.

                // Tato vlastnost dědičnosti nám umožňuje např. uložit všechna vozidla do jednoho seznamu, i když jsou různého typu.
                var vozidla = new List<Vozidlo>
                {
                    new Auto(),
                    new Motorka()
                };

                // Vztahy můžeme dále libovolně kombinovat a vytvářet tzv. hierarchie tříd.
                // Vozidlo -> MotoroveVozidlo -> Auto, Motorka
                // Každé Vozidlo má kola, každé motorové vozidlo má motor, každé auto má převodovku atd.
            }
        }

        class Prevodovka
        {
            public string Typ;

            public int PocetPrevodu;

            public int AktualniPrevod;

            public void ZvysitPrevod()
            {}

            public void SnizitPrevod()
            { }
        }

        class Motor
        {
            // ...
        }

        class Vozidlo
        {
            public int PocetKol;
        }

        class Auto : Vozidlo
        {
            public string Barva;

            public string Typ;

            public string Spz;

            public int RokVyroby;

            public Prevodovka Prevodovka;

            public Motor Motor;
        }

        class Motorka : Vozidlo
        {

        }
    }
}