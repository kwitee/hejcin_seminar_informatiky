namespace WindowsForms
{
    partial class EvidenceSuperhrdinuForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.superhrdinaGroupBox = new System.Windows.Forms.GroupBox();
            this.upravitButton = new System.Windows.Forms.Button();
            this.letaCheckBox = new System.Windows.Forms.CheckBox();
            this.tajnaIdentitaTextBox = new System.Windows.Forms.TextBox();
            this.tajnaIdentitaLabel = new System.Windows.Forms.Label();
            this.pohlaviComboBox = new System.Windows.Forms.ComboBox();
            this.pohlaviLabel = new System.Windows.Forms.Label();
            this.jmenoTextBox = new System.Windows.Forms.TextBox();
            this.jmenoLabel = new System.Windows.Forms.Label();
            this.vytvoritButton = new System.Windows.Forms.Button();
            this.superhrdinoveListBox = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.souborToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ulozitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nacistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.superhrdinaGroupBox.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // superhrdinaGroupBox
            // 
            this.superhrdinaGroupBox.Controls.Add(this.upravitButton);
            this.superhrdinaGroupBox.Controls.Add(this.letaCheckBox);
            this.superhrdinaGroupBox.Controls.Add(this.tajnaIdentitaTextBox);
            this.superhrdinaGroupBox.Controls.Add(this.tajnaIdentitaLabel);
            this.superhrdinaGroupBox.Controls.Add(this.pohlaviComboBox);
            this.superhrdinaGroupBox.Controls.Add(this.pohlaviLabel);
            this.superhrdinaGroupBox.Controls.Add(this.jmenoTextBox);
            this.superhrdinaGroupBox.Controls.Add(this.jmenoLabel);
            this.superhrdinaGroupBox.Controls.Add(this.vytvoritButton);
            this.superhrdinaGroupBox.Location = new System.Drawing.Point(12, 27);
            this.superhrdinaGroupBox.Name = "superhrdinaGroupBox";
            this.superhrdinaGroupBox.Size = new System.Drawing.Size(434, 171);
            this.superhrdinaGroupBox.TabIndex = 1;
            this.superhrdinaGroupBox.TabStop = false;
            this.superhrdinaGroupBox.Text = "Superhrdina";
            // 
            // upravitButton
            // 
            this.upravitButton.Location = new System.Drawing.Point(353, 142);
            this.upravitButton.Name = "upravitButton";
            this.upravitButton.Size = new System.Drawing.Size(75, 23);
            this.upravitButton.TabIndex = 8;
            this.upravitButton.Text = "Upravit";
            this.upravitButton.UseVisualStyleBackColor = true;
            this.upravitButton.Click += new System.EventHandler(this.upravitButton_Click);
            // 
            // letaCheckBox
            // 
            this.letaCheckBox.AutoSize = true;
            this.letaCheckBox.Location = new System.Drawing.Point(206, 69);
            this.letaCheckBox.Name = "letaCheckBox";
            this.letaCheckBox.Size = new System.Drawing.Size(47, 17);
            this.letaCheckBox.TabIndex = 7;
            this.letaCheckBox.Text = "Létá";
            this.letaCheckBox.UseVisualStyleBackColor = true;
            // 
            // tajnaIdentitaTextBox
            // 
            this.tajnaIdentitaTextBox.Location = new System.Drawing.Point(280, 29);
            this.tajnaIdentitaTextBox.Name = "tajnaIdentitaTextBox";
            this.tajnaIdentitaTextBox.Size = new System.Drawing.Size(121, 20);
            this.tajnaIdentitaTextBox.TabIndex = 6;
            // 
            // tajnaIdentitaLabel
            // 
            this.tajnaIdentitaLabel.AutoSize = true;
            this.tajnaIdentitaLabel.Location = new System.Drawing.Point(203, 32);
            this.tajnaIdentitaLabel.Name = "tajnaIdentitaLabel";
            this.tajnaIdentitaLabel.Size = new System.Drawing.Size(71, 13);
            this.tajnaIdentitaLabel.TabIndex = 5;
            this.tajnaIdentitaLabel.Text = "Tajná identita";
            // 
            // pohlaviComboBox
            // 
            this.pohlaviComboBox.FormattingEnabled = true;
            this.pohlaviComboBox.Items.AddRange(new object[] {
            "Muž",
            "Žena",
            "Jiné"});
            this.pohlaviComboBox.Location = new System.Drawing.Point(61, 70);
            this.pohlaviComboBox.Name = "pohlaviComboBox";
            this.pohlaviComboBox.Size = new System.Drawing.Size(121, 21);
            this.pohlaviComboBox.TabIndex = 4;
            // 
            // pohlaviLabel
            // 
            this.pohlaviLabel.AutoSize = true;
            this.pohlaviLabel.Location = new System.Drawing.Point(16, 73);
            this.pohlaviLabel.Name = "pohlaviLabel";
            this.pohlaviLabel.Size = new System.Drawing.Size(44, 13);
            this.pohlaviLabel.TabIndex = 3;
            this.pohlaviLabel.Text = "Pohlaví";
            // 
            // jmenoTextBox
            // 
            this.jmenoTextBox.Location = new System.Drawing.Point(61, 29);
            this.jmenoTextBox.Name = "jmenoTextBox";
            this.jmenoTextBox.Size = new System.Drawing.Size(121, 20);
            this.jmenoTextBox.TabIndex = 2;
            // 
            // jmenoLabel
            // 
            this.jmenoLabel.AutoSize = true;
            this.jmenoLabel.Location = new System.Drawing.Point(16, 32);
            this.jmenoLabel.Name = "jmenoLabel";
            this.jmenoLabel.Size = new System.Drawing.Size(38, 13);
            this.jmenoLabel.TabIndex = 1;
            this.jmenoLabel.Text = "Jméno";
            // 
            // vytvoritButton
            // 
            this.vytvoritButton.Location = new System.Drawing.Point(272, 142);
            this.vytvoritButton.Name = "vytvoritButton";
            this.vytvoritButton.Size = new System.Drawing.Size(75, 23);
            this.vytvoritButton.TabIndex = 0;
            this.vytvoritButton.Text = "Vytvořit";
            this.vytvoritButton.UseVisualStyleBackColor = true;
            this.vytvoritButton.Click += new System.EventHandler(this.vytvoritButton_Click);
            // 
            // superhrdinoveListBox
            // 
            this.superhrdinoveListBox.DisplayMember = "Jmeno";
            this.superhrdinoveListBox.FormattingEnabled = true;
            this.superhrdinoveListBox.Location = new System.Drawing.Point(452, 38);
            this.superhrdinoveListBox.Name = "superhrdinoveListBox";
            this.superhrdinoveListBox.Size = new System.Drawing.Size(336, 160);
            this.superhrdinoveListBox.TabIndex = 2;
            this.superhrdinoveListBox.SelectedIndexChanged += new System.EventHandler(this.superhrdinoveListBox_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.souborToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip";
            // 
            // souborToolStripMenuItem
            // 
            this.souborToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ulozitToolStripMenuItem,
            this.nacistToolStripMenuItem});
            this.souborToolStripMenuItem.Name = "souborToolStripMenuItem";
            this.souborToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.souborToolStripMenuItem.Text = "Soubor";
            // 
            // ulozitToolStripMenuItem
            // 
            this.ulozitToolStripMenuItem.Name = "ulozitToolStripMenuItem";
            this.ulozitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ulozitToolStripMenuItem.Text = "Uložit";
            // 
            // nacistToolStripMenuItem
            // 
            this.nacistToolStripMenuItem.Name = "nacistToolStripMenuItem";
            this.nacistToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nacistToolStripMenuItem.Text = "Načíst";
            // 
            // EvidenceSuperhrdinuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 203);
            this.Controls.Add(this.superhrdinoveListBox);
            this.Controls.Add(this.superhrdinaGroupBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "EvidenceSuperhrdinuForm";
            this.Text = "Správa superhrdinů";
            this.superhrdinaGroupBox.ResumeLayout(false);
            this.superhrdinaGroupBox.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox superhrdinaGroupBox;
        private System.Windows.Forms.Label jmenoLabel;
        private System.Windows.Forms.Button vytvoritButton;
        private System.Windows.Forms.Label pohlaviLabel;
        private System.Windows.Forms.TextBox jmenoTextBox;
        private System.Windows.Forms.TextBox tajnaIdentitaTextBox;
        private System.Windows.Forms.Label tajnaIdentitaLabel;
        private System.Windows.Forms.ComboBox pohlaviComboBox;
        private System.Windows.Forms.CheckBox letaCheckBox;
        private System.Windows.Forms.ListBox superhrdinoveListBox;
        private System.Windows.Forms.Button upravitButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem souborToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ulozitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nacistToolStripMenuItem;
    }
}

