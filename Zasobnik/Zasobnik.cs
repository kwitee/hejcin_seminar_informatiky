using System;

namespace Zasobnik
{
    public class Zasobnik<T>
    {
        private Prvek<T> vrchol;

        public int PocetPrvku { get; private set; }

        public void Push(T hodnota)
        {
            var novyPrvek = new Prvek<T>(hodnota);

            // Pokud nebyl zásobník prázdný, tak je nutné připojit původní vrchol na nový prvek
            if (vrchol != null)
            {
                novyPrvek.Dalsi = vrchol;
            }

            // Nový prvek je vrcholem zásobníku
            vrchol = novyPrvek;

            // Zvýšíme počet prvků
            PocetPrvku++;
        }

        public T Pop()
        {
            // Pokud je zásobník prázdný, tak nelze nic odebrat
            if (vrchol == null)
            {
                throw new Exception("Zásobník je prázdný.");
            }

            // Uložíme si hodnotu a vrchol posuneme na další prvek
            var hodnota = vrchol.Hodnota;
            vrchol = vrchol.Dalsi;

            // Snížíme počet prvků
            PocetPrvku--;

            return hodnota;
        }

        public T Peek()
        {
            // Pokud je zásobník prázdný, tak nemůžeme nic vrátit
            if (vrchol == null)
            {
                throw new Exception("Zásobník je prázdný.");
            }

            return vrchol.Hodnota;
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