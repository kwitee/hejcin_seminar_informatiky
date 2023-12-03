using System;

namespace UdalostiVyklad
{
    // Událost je mechanismus, který umožňuje notifikace o změně stavu objektu.
    // Mějme třídu rychlovarná konvice, která může začít vařit vodu a informuje o tom, že voda dovařila.
    // Událost tedy vlastně otáčí směr volání, kdy konvice oznamuje, namísto aby odběratel kontroloval, zda už se dovařilo.
    public class RychlovarnaKonvice
    {
        // Událost, která se zavolá v případě, že voda dovařila. Pro definici události se používá klíčové slovo event.
        // Za klíčovým slovem event je tzv. delegát, který definuje signaturu notifikace.
        // Zde používáme generický delegát EventHandler, který má dva parametry - odesílatele a argumenty.
        // Event je vlastně list metod, které se zavolají, když se událost vyvolá.
        public event EventHandler Dovarila;

        public void ZacniVarit()
        {
            // Spustí se vaření
            // ...

            // Pokud je událost registrovaná, tak se zavolá - tzn. všichni odběratelé události dostanou notifikaci.
            // Kontrola na null je nutná, protože pokud nebude událost registrovaná, tak je null a došlo by k chybě.
            if (Dovarila != null)
            {
                // Zde voláme událost s jejími parametry, vyplníme odesálatele a argumenty necháme prázdné.
                Dovarila.Invoke(this, EventArgs.Empty);
            }
        }
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

    // Je také možné si vytvořit vlastního delegáta, který bude definovat signaturu události.
    // V tomto případě je to delegát MujDelegat, který má dva parametry - odesílatele a dobu vaření.
    public delegate void MujDelegat(object odesilatel, double dobaVareni);

    // Ukázka použití vlastního delegáta.
    public class RychlovarnaKonvice2
    {
        public event MujDelegat Dovarila;
    }

    // Události se často používají v GUI aplikacích, kde množství komponent musí reagovat na změnu stavu jiné komponenty.
    // Příklad: reakce na klik na tlačítko, změnu hodnoty v textboxu, atd.
}