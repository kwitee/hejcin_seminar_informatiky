using System.Collections.Generic;
using System;
using System.IO;

namespace Ordinace
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nacitani pacientu ze souboru...");
            PrectiPacienty();

            while (true)
            {
                Console.WriteLine("Vyberte operaci (R - registrace, V - výpis, F - filtr, S - statistika, K - konec):");
                var operace = Console.ReadLine();

                if (operace == "R")
                {
                    VytvorPacienta();
                }
                else if (operace == "V")
                {
                    VypisPacienty();
                }
                else if (operace == "F")
                {
                    FiltrujPacienty();
                }
                else if (operace == "S")
                {
                    ZobrazStatistiku();
                }
                else if (operace == "K")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Neplatná operace.");
                }
            }
        }

        private static List<Pacient> kontejnerPacientu = new List<Pacient>();

        private static void VytvorPacienta()
        {
            Console.WriteLine("Zadej jmeno: ");
            var jmeno = Console.ReadLine();

            Console.WriteLine("Zadej vahu v kilogramech: ");
            var vaha = double.Parse(Console.ReadLine());

            Console.WriteLine("Zadej vysku v centimetrech: ");
            var vyska = double.Parse(Console.ReadLine());

            Console.WriteLine("Zadej vek: ");
            var vek = int.Parse(Console.ReadLine());

            var pacient = new Pacient(jmeno, vaha, vyska, vek);
            kontejnerPacientu.Add(pacient);

            UlozPacienta(pacient);
        }

        private static void VypisPacienty()
        {
            foreach (var pacient in kontejnerPacientu)
            {
                VypisPacienta(pacient);
            }

            Console.WriteLine($"Pocet pacientů: {kontejnerPacientu.Count}.");
        }

        private static void VypisPacienta(Pacient pacient)
        {
            Console.WriteLine($"Jmeno: {pacient.Jmeno}, vaha: {pacient.Vaha}, vyska: {pacient.Vyska}, vek: {pacient.Vek}, BMI: {pacient.Bmi}.");
        }

        private static void FiltrujPacienty()
        {
            while (true)
            {
                Console.WriteLine("Zadej kategorii (P - podváha, N - norma, O - obezita):");
                var kategorie = Console.ReadLine();

                if (kategorie == "P")
                {
                    foreach (var pacient in kontejnerPacientu)
                    {
                        if (pacient.KategorieRizikovosti == "Podváha")
                        {
                            VypisPacienta(pacient);
                        }
                    }

                    break;
                }
                else if (kategorie == "N")
                {
                    foreach (var pacient in kontejnerPacientu)
                    {
                        if (pacient.KategorieRizikovosti == "Norma")
                        {
                            VypisPacienta(pacient);
                        }
                    }

                    break;
                }
                else if (kategorie == "O")
                {
                    foreach (var pacient in kontejnerPacientu)
                    {
                        if (pacient.KategorieRizikovosti.StartsWith("Obezita"))
                        {
                            VypisPacienta(pacient);
                        }
                    }

                    break;
                }
                else
                {
                    Console.WriteLine("Neplatná kategorie.");
                }
            }
        }

        private static void ZobrazStatistiku()
        {
            var sumaVek = 0;
            var pocetPodvaha = 0;
            var pocetNorma = 0;
            var pocetObezita = 0;

            foreach (var pacient in kontejnerPacientu)
            {
                sumaVek = sumaVek + pacient.Vek;

                if (pacient.KategorieRizikovosti == "Podváha")
                {
                    pocetPodvaha = pocetPodvaha + 1;
                }
                else if (pacient.KategorieRizikovosti == "Norma")
                {
                    pocetNorma = pocetNorma + 1;
                }
                else if (pacient.KategorieRizikovosti.StartsWith("Obezita"))
                {
                    pocetObezita = pocetObezita + 1;
                }
            }

            var prumernyVek = sumaVek / kontejnerPacientu.Count;

            Console.WriteLine($"Prumerny vek: {prumernyVek}.");
            Console.WriteLine($"Pocet pacientu v kategorii podváha: {pocetPodvaha}.");
            Console.WriteLine($"Pocet pacientu v kategorii norma: {pocetNorma}.");
            Console.WriteLine($"Pocet pacientu v kategorii obezita: {pocetObezita}.");
        }

        private static string kartotekaCesta = "kartoteka.txt";

        private static void UlozPacienta(Pacient pacient)
        {
            var pacientText = $"{pacient.Jmeno}/{pacient.Vaha}/{pacient.Vyska}/{pacient.Vek}";

            File.AppendAllText(kartotekaCesta, pacientText);
        }

        private static void PrectiPacienty()
        {
            foreach (var radek in File.ReadAllLines(kartotekaCesta))
            {
                kontejnerPacientu.Add(PrectiPacienta(radek));
            }
        }

        private static Pacient PrectiPacienta(string pacientText)
        {
            var pacientUdaje = pacientText.Split('/');

            var jmeno = pacientUdaje[0];
            var vaha = double.Parse(pacientUdaje[1]);
            var vyska = double.Parse(pacientUdaje[2]);
            var vek = int.Parse(pacientUdaje[3]);

            return new Pacient(jmeno, vaha, vyska, vek);
        }

        // Lepší způsob filtrování
        private static List<Pacient> VratPacientyDleKategorie(string kategorieRizikovosti)
        {
            var vysledky = new List<Pacient>();

            foreach (var pacient in kontejnerPacientu)
            {
                if (pacient.KategorieRizikovosti.StartsWith(kategorieRizikovosti))
                {
                    vysledky.Add(pacient);
                }
            }

            return vysledky;
        }
    }
}