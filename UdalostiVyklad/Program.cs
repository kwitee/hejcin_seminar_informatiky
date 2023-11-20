using System;

namespace UdalostiVyklad
{
    // Událost je mechanismus, který umožňuje notifikace o změně stavu objektu.
    // Mějme třídu rychlovarná konvice, která může začít vařit vodu a informuje o tom, že voda dovařila.
    // Událost tedy vlastně otáčí směr volání, kdy konvice oznamuje, namísto aby odběratel kontroloval, zda už se dovařilo.
    public class RychlovarnaKonvice
    {
        public void ZacniVarit()
        {
            // Spustí se vaření
            // ...

            // Pokud je událost registrovaná, tak se zavolá - tzn. všichni odběratelé události dostanou notifikaci
            if (Dovarila != null)
                Dovarila.Invoke(this, EventArgs.Empty);
        }

        // Událost, která se zavolá v případě, že voda dovařila. Pro definici události se používá klíčové slovo event.
        // Za klíčovým slovem event je tzv. delegát, který definuje signaturu notifikace.
        public event EventHandler Dovarila;
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // Zde vytvoříme instanci konvice a zaregistrujeme se na událost pomocí operátoru += (operátor -= slouží k odregistrování).
            var konvice = new RychlovarnaKonvice();
            konvice.Dovarila += Konvice_Dovarila;

            // Začneme vařit
            konvice.ZacniVarit();

            Console.WriteLine("Stiskni libovolnou klávesu pro konec.");
            Console.ReadKey();
        }

        // Toto je metoda, která se zavolá, když k události dojde.
        // Metoda musí mít stejnou signaturu jako delegát, který definuje událost.
        private static void Konvice_Dovarila(object sender, EventArgs e)
        {
            Console.WriteLine("Konvice dovařila.");
        }
    }
}