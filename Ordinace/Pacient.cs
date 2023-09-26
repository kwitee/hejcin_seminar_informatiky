namespace Ordinace
{
    public class Pacient
    {
        public string Jmeno { get; }
        public double Vaha { get; }
        public double Vyska { get; }
        public int Vek { get; }

        public double Bmi { get; }
        public string KategorieRizikovosti { get; }

        public Pacient(string jmeno, double vaha, double vyska, int vek)
        {
            Jmeno = jmeno;
            Vaha = vaha;
            Vyska = vyska;
            Vek = vek;

            var vyskaVMetrech = vyska / 100;
            Bmi = Vaha / (vyskaVMetrech * vyskaVMetrech);

            KategorieRizikovosti = VyhodnotKategoriiRizikovosti(Bmi);
        }

        private static string VyhodnotKategoriiRizikovosti(double bmi)
        {
            if (bmi < 18.5)
            {
                return "Podváha";
            }
            else if (bmi < 25)
            {
                return "Norma";
            }
            else if (bmi < 30)
            {
                return "Nadváha";
            }
            else if (bmi < 35)
            {
                return "Obezita (1. stupně)";
            }
            else if (bmi < 40)
            {
                return "Obezita (2. stupně)";
            }
            else
            {
                return "Obezita (3. stupně)";
            }
        }
    }
}