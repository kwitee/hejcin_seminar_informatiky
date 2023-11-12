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
            if (index < 0)
            {
                throw new IndexOutOfRangeException("Index je menší než 0.");
            }

            var aktualniPrvek = prvniPrvek;

            for (int i = 0; i < index; i++)
            {
                if (aktualniPrvek == null)
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
            var pocetPrvku = 0;
            var aktualniPrvek = prvniPrvek;

            while (aktualniPrvek != null)
            {
                aktualniPrvek = aktualniPrvek.Dalsi;
                pocetPrvku++;
            }

            return pocetPrvku;
        }

        // Smaže prvek na indexu
        public void VymazPrvek(int index)
        {
            var mazanyPrvek = NajdiPrvek(index);

            // Pokud je mazaný prvek první, tak na něj jiné prvky neodkazují
            // Proto pouze změníme referenci na první prvek
            if (mazanyPrvek == prvniPrvek)
            {
                prvniPrvek = prvniPrvek.Dalsi;
            }
            else
            {
                // Pokud je mazaný prvek jinde než na začátku, tak musíme provázat předchozí prvek s následujícím
                // Následující prvek může být null, ale to klidně provázat můžeme
                var predchoziPrvek = NajdiPrvek(index - 1);
                predchoziPrvek.Dalsi = mazanyPrvek.Dalsi;

                // Pokud je mazaný prvek současně posledním prvkem, musíme provázat poslední prvek
                if (mazanyPrvek == posledniPrvek)
                {
                    posledniPrvek = predchoziPrvek;
                }
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