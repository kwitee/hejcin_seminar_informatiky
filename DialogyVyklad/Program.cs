using System;
using System.Windows.Forms;

namespace DialogyVyklad
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Dialogy jsou malá okna, která překrývají hlavní okno aplikace a od uživatele vyžadují okamžitou akci.
            // Dialogy zastavují běh programu, dokud uživatel nezareaguje. Je dobré je používat opatrně, protože mají rušivý efekt.

            // Message box
            {
                // Nejjednoduší dialog je MessageBox. Používá se pro zobrazení informačních, varovných a chybových hlášek.
                // Dále jej můžeme použít na jednoduchý výběr z několika možností (Ano/Ne, OK/Storno/Zrušit, ...).

                // MessageBox je statická třída, zobrazujeme jej pomocí metody Show.
                MessageBox.Show("Text message boxu.", "Nadpis message boxu", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                // Metoda vrací hodnotu typu DialogResult, která nám říká, jakým způsobem uživatel reagoval.
                var result = MessageBox.Show("Otázka?", "Nadpis message boxu", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // ...
                }
            }

            // Save file dialog
            {
                // SaveFileDialog slouží k výběru souboru, do kterého budeme ukládat.

                // Vytvoříme instanci SaveFileDialog.
                var dialog = new SaveFileDialog();

                // Můžeme nastavit výchozí název souboru.
                dialog.FileName = "novy_soubor.txt";

                // Nastavíme filtr, který určuje, jaké typy souborů může uživatel vybrat.
                // V tomto případě může vybrat pouze textové soubory.
                // Filtr je řetězec, který obsahuje dvojice názvů a přípon, oddělené svislítkem.
                dialog.Filter = "Textové soubory (*.txt)|*.txt|Bitmapy (*.bmp)|*.bmp";

                // Dialog je možné ukončit i bez výběru souboru, proto je nutné zkontrolovat, zda uživatel soubor skutečně vybral.
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    // Získáme cestu k vybranému souboru.
                    var path = dialog.FileName;

                    // ...
                }
            }

            // Open file dialog
            {
                // OpenFileDialog slouží k výběru souboru, ze kterého budeme číst.

                // Vytvoříme instanci OpenFileDialog.
                var dialog = new OpenFileDialog();

                // Filtr funguje stejně jako u SaveFileDialog.
                dialog.Filter = "Textové soubory (*.txt)|*.txt|Bitmapy (*.bmp)|*.bmp";

                // Opět je možné výběr souboru stornovat, proto je nutné ověřit result.
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    // Získáme cestu k vybranému souboru.
                    var path = dialog.FileName;

                    // ...
                }
            }
        }
    }
}