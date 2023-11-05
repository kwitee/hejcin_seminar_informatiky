using System;

namespace SpojovySeznam
{
    // Generický seznam, který umožňuje ukládat data libovolného typu.
    // T představuje typ, který bude seznam ukládat.
    public class Seznam<T>
    {
        private Prvek<T> prvniPrvek;

        private Prvek<T> posledniPrvek;

        // Přidá nový prvek na konec seznamu
        public void PridejPrvek(T hodnota)
        {
            var novyPrvek = new Prvek<T>(hodnota);

            if (posledniPrvek != null)
            {
                posledniPrvek.Dalsi = novyPrvek;
            }

            posledniPrvek = novyPrvek;

            if (prvniPrvek == null)
            {
                prvniPrvek = novyPrvek;
            }
        }

        // Vrátí prvek na indexu
        public T VratPrvek(int index)
        {
            return NajdiPrvek(index).Hodnota;
        }

        // Najde prvek na daném indexu
        // Pokud je seznam prázdný nebo nemá dostatek prvků, vyhoď výjimku pomocí throw new IndexOutOfRangeException();
        private Prvek<T> NajdiPrvek(int index)
        {
            if (prvniPrvek == null)
            {
                throw new IndexOutOfRangeException("Seznam je prázdný.");
            }

            var aktualniPrvek = prvniPrvek;

            for (int i = 0; i < index; i++)
            {
                if (aktualniPrvek.Dalsi == null)
                {
                    throw new IndexOutOfRangeException("Index je větší než počet prvků v seznamu.");
                }

                aktualniPrvek = aktualniPrvek.Dalsi;
            }

            return aktualniPrvek;
        }

        // Změní hodnotu prvku na indexu
        public void ZmenPrvek(int index, T hodnota)
        {
            NajdiPrvek(index).Hodnota = hodnota;
        }

        // Vrátí počet prvků v seznamu
        public int DejPocetPrvku()
        {
            if (prvniPrvek == null)
            {
                return 0;
            }

            var aktualniPrvek = prvniPrvek;
            var pocetPrvku = 1; // Musíme započítat i první prvek

            while (aktualniPrvek.Dalsi != null)
            {
                aktualniPrvek = aktualniPrvek.Dalsi;
                pocetPrvku++;
            }

            return pocetPrvku;
        }

        // Smaže prvek na indexu
        public void VymazPrvek(int index)
        {
            var prvek = NajdiPrvek(index);

            if (prvek == prvniPrvek)
            {
                prvniPrvek = prvniPrvek.Dalsi;
            }
            else
            {
                var predchoziPrvek = NajdiPrvek(index - 1);
                predchoziPrvek.Dalsi = prvek.Dalsi;
            }
        }
    }

    public class Prvek<T>
    {
        public T Hodnota { get; set; }

        public Prvek<T> Dalsi { get; set; }

        public Prvek(T hodnota)
        {
            Hodnota = hodnota;
        }
    }
}