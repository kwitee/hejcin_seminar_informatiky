using System;
using System.Windows.Forms;

namespace WindowsForms
{
    public partial class EvidenceSuperhrdinuForm : Form
    {
        public EvidenceSuperhrdinuForm()
        {
            InitializeComponent();
        }

        private void vytvoritButton_Click(object sender, EventArgs e)
        {
            var superhrdina = new Superhrdina();

            superhrdina.Jmeno = jmenoTextBox.Text;
            superhrdina.TajnaIdentita = tajnaIdentitaTextBox.Text;
            superhrdina.Pohlavi = pohlaviComboBox.SelectedItem.ToString();
            superhrdina.Leta = letaCheckBox.Checked;

            superhrdinoveListBox.Items.Add(superhrdina);
            Vycistit();
        }

        private void superhrdinoveListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var superhrdina = superhrdinoveListBox.Items[superhrdinoveListBox.SelectedIndex] as Superhrdina;

            if (superhrdina == null)
                return;

            jmenoTextBox.Text = superhrdina.Jmeno;
            tajnaIdentitaTextBox.Text = superhrdina.TajnaIdentita;
            pohlaviComboBox.SelectedItem = superhrdina.Pohlavi;
            letaCheckBox.Checked = superhrdina.Leta;
        }

        private void upravitButton_Click(object sender, EventArgs e)
        {
            var superhrdina = superhrdinoveListBox.Items[superhrdinoveListBox.SelectedIndex] as Superhrdina;

            if (superhrdina == null)
                return;

            superhrdina.Jmeno = jmenoTextBox.Text;
            superhrdina.TajnaIdentita = tajnaIdentitaTextBox.Text;
            superhrdina.Pohlavi = pohlaviComboBox.SelectedItem.ToString();
            superhrdina.Leta = letaCheckBox.Checked;
        }

        private void Vycistit()
        {
            jmenoTextBox.Text = "";
            tajnaIdentitaTextBox.Text = "";
            pohlaviComboBox.SelectedItem = null;
            letaCheckBox.Checked = false;
        }
    }

    public class Superhrdina
    {
        public string Jmeno { get; set; }

        public string TajnaIdentita { get; set; }

        public string Pohlavi { get; set; }

        public bool Leta { get; set; }
    }
}
