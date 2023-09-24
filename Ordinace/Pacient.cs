namespace Ordinace;

public class Pacient
{
    public string Jmeno { get; }
    public double Vaha { get; }
    public double Vyska { get; }
    public int Vek { get; }

    public double Bmi
    {
        get
        {
            return Vaha / (Vyska * Vyska);
        }
    }

    public string KategorieRizikovosti
    {
        get
        {
            if (Bmi < 18.5)
            {
                return "Podváha";
            }
            else if (Bmi < 25)
            {
                return "Norma";
            }
            else if (Bmi < 30)
            {
                return "Nadváha";
            }
            else if (Bmi < 35)
            {
                return "Obezita (1. stupně)";
            }
            else if (Bmi < 40)
            {
                return "Obezita (2. stupně)";
            }
            else
            {
                return "Obezita (3. stupně)";
            }
        }
    }

    public Pacient(string jmeno, double vaha, double vyska, int vek)
    {
        Jmeno = jmeno;
        Vaha = vaha;
        Vyska = vyska;
        Vek = vek;
    }
}