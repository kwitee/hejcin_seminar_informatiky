using System;

namespace Fronta
{
    public class Fronta<T>
    {
        private Prvek<T> zacatek;

        private Prvek<T> konec;

        public int PocetPrvku { get; private set; }

        // Přidá prvek na konec fronty.
        public void Enqueue(T hodnota)
        {
            var novyPrvek = new Prvek<T>(hodnota);

            if (zacatek == null)
            {
                // Pokud je fronta prázdná, tak nastavíme začátek i konec na nový prvek.
                zacatek = konec = novyPrvek;
            }
            else
            {
                // Jinak přidáme nový prvek za konec fronty.
                konec.Dalsi = novyPrvek;

                // A nastavíme nový konec fronty.
                konec = novyPrvek;
            }

            // Zvýšíme počet prvků ve frontě.
            PocetPrvku++;
        }

        // Odebereme prvek ze začátku fronty.
        public T Dequeue()
        {
            if (zacatek == null)
            {
                throw new Exception("Fronta je prázdná.");
            }

            // Uložíme si hodnotu a začátek fronty posuneme na další prvek.
            var hodnota = zacatek.Hodnota;
            zacatek = zacatek.Dalsi;

            // Snížíme počet prvků ve frontě.
            PocetPrvku--;

            return hodnota;
        }

        public T Peek()
        {
            // Pokud je fronta prázdná, tak nemůžeme nic vrátit
            if (zacatek == null)
            {
                throw new Exception("Fronta je prázdná.");
            }

            return zacatek.Hodnota;
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