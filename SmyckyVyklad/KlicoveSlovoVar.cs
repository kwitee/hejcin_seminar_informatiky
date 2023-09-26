namespace SmyckyVyklad
{
    public static class KlicoveSlovoVar
    {
        public static void Ukazka()
        {
            // Uvádět datový typ na obou stranách přiřazení je redundantní
            int cele_cislo = 5;
            int[] pole = new int[] { 1, 2, 3, 4, 5 };

            // Překladač může datový typ na levé straně odvodit z té pravé
            // K tomuto pozužíváme klíčové slovo var -> variable
            var cele_cislo_2 = 5;
            var pole_2 = new int[] { 1, 2, 3 };

            // Var má určitá omezení, a také lehce snižuje čitelnost kódu
            // Jaký datový typ má proměnná hodnota?
            var hodnota = DejHodnotu();

            // VS zobrazuje informaci o datovém typu po najetí myši
        }

        private static double DejHodnotu()
        {
            return 5.0;
        }
    }
}