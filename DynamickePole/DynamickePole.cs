using System;

namespace DynamickePole
{
    public class DynamickePole<T>
    {
        private T[] vnitrniPole;

        public int PocetPrvku { get; private set; }

        public DynamickePole(int kapacita)
        {
            vnitrniPole = new T[kapacita];
        }

        // Přidá nový prvek na konec pole.
        public void PridejPrvek(T prvek)
        {
            // Pokud je vnitřní pole plné, vytvoříme nové pole s dvojnásobnou kapacitou
            // a překopírujeme do něj prvky z původního pole.
            if (PocetPrvku >= vnitrniPole.Length)
            {
                T[] novePole = new T[PocetPrvku * 2];

                for (int i = 0; i < PocetPrvku; i++)
                {
                    novePole[i] = vnitrniPole[i];
                }

                vnitrniPole = novePole;
            }

            // Přidáme prvek na konec pole a zvýšíme skutečný počet prvků.
            vnitrniPole[PocetPrvku] = prvek;
            PocetPrvku++;
        }

        // Vrátí prvek na daném indexu.
        public T VratPrvek(int index)
        {
            if (index < 0 || index >= PocetPrvku)
            {
                throw new IndexOutOfRangeException();
            }

            return vnitrniPole[index];
        }

        // Smaže prvek na daném indexu.
        public void VymazPrvek(int index)
        {
            if (index < 0 || index >= PocetPrvku)
            {
                throw new IndexOutOfRangeException();
            }

            // Přesuneme prvky v poli o jednu pozici doleva (začneme prvkem na indexu).
            for (int i = index; i < PocetPrvku - 1; i++)
            {
                vnitrniPole[i] = vnitrniPole[i + 1];
            }

            // Snížíme skutečný počet prvků.
            PocetPrvku--;
        }
    }
}