using System.Collections.Generic;

namespace ObjektoveModelovani
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Vytvořte objektový model pro jednoduché RPG (Role Playing Game).
            // Hra by měla obsahovat alespoň tyto třídy: dobrodruh, monstrum, předmět, inventář, zbraň.

            // Všichni tvorové (dobrodruhové i monstra) mají vlastnosti: sílu, obratnost, odolnost, inteligenci a charisma.
            // Dobrodruhové mají inventář, zkušenosti a úroveň.
            // Tvor má maximální a aktuální počet životů, můžeme ho zranit nebo léčit.

            // Inventář obsauje předměty, které mají název, cenu a váhu.
            // Inventář udržuje celkovou cenu a váhu všech předmětů v něm.
            // Zbraň udává zranění a dosah. Může být jednoruční nebo obouruční.

            // Smyslem tohoto úkolu není přemýšlet o algoritmech, ale o struktuře programu.
            // Použijte principy zapouzdření, dědičnosti, kompozice a polymorfismu.
            // Každý objekt je zodpovědný za svůj vnitřní stav, který je neměnitelný zvenčí.
        }
    }

    public class Vlastnosti
    {
        public int Sila { get; }

        public int Obratnost { get; }

        public int Odolnost { get; }

        public int Inteligence { get; }

        public int Charisma { get; }
    }

    public abstract class Tvor
    {
        public Tvor(Vlastnosti vlastnosti)
        {
            Vlasnosti = vlastnosti;
            MaxPocetZivotu = AktualniPocetZivotu = vlastnosti.Odolnost * 10;
        }

        public Vlastnosti Vlasnosti { get; }

        public int MaxPocetZivotu { get; }

        public int AktualniPocetZivotu { get; private set; }

        public void DejZraneni(int zraneni)
        {
            AktualniPocetZivotu -= zraneni;

            if (AktualniPocetZivotu < 0)
            {
                AktualniPocetZivotu = 0;
            }
        }

        public void DejLeceni(int leceni)
        {
            AktualniPocetZivotu += leceni;

            if (AktualniPocetZivotu > MaxPocetZivotu)
            {
                AktualniPocetZivotu = MaxPocetZivotu;
            }
        }
    }

    public class Dobrodruh : Tvor
    {
        public Dobrodruh(Vlastnosti vlastnosti, Inventar inventar) : base(vlastnosti)
        {
            Inventar = inventar;
        }

        public int Uroven { get; private set; }

        private int zkusenosti;

        public void DejZkusenosti(int zkusenosti)
        {
            this.zkusenosti += zkusenosti;

            if (this.zkusenosti > 10)
            {
                Uroven++;
                this.zkusenosti = 0;
            }
        }

        public Inventar Inventar { get; }
    }

    public class Monstrum : Tvor
    {
        public Monstrum(Vlastnosti vlastnosti, int zraneni, double dosah) : base(vlastnosti)
        {
            Zraneni = zraneni;
            Dosah = dosah;
        }

        public int Zraneni { get; }

        public double Dosah { get; }
    }

    public class Predmet
    {
        public Predmet(string nazev, int cena, double vaha)
        {
            Nazev = nazev;
            Cena = cena;
            Vaha = vaha;
        }

        public string Nazev { get; }

        public int Cena { get; }

        public double Vaha { get; }
    }

    public class Zbran : Predmet
    {
        public Zbran(string nazev, int cena, double vaha, int zraneni, double dosah, bool jednorucni)
            : base(nazev, cena, vaha)
        {
            Zraneni = zraneni;
            Dosah = dosah;
            Jednorucni = jednorucni;
        }

        public int Zraneni { get; }

        public double Dosah { get;}

        public bool Jednorucni { get;}
    }

    public class Inventar
    {
        private List<Predmet> predmety = new List<Predmet>();

        public void PridatPredmet(Predmet predmet)
        {
            predmety.Add(predmet);
        }

        public int DejCelkovouCenu()
        {
            var celkovaCena = 0;

            foreach (var predmet in predmety)
            {
                celkovaCena += predmet.Cena;
            }

            return celkovaCena;
        }

        public double DejCelkovouVahu()
        {
            var celkovaVaha = 0.0;

            foreach (var predmet in predmety)
            {
                celkovaVaha += predmet.Vaha;
            }

            return celkovaVaha;
        }
    }
}