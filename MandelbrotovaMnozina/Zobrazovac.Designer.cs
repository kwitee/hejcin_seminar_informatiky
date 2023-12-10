namespace MandelbrotovaMnozina
{
    partial class Zobrazovac
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
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.vykresliButton = new System.Windows.Forms.Button();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.souborToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ulozitObrazekToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ulozitParametryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nacistParametryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xMinTextBox = new System.Windows.Forms.TextBox();
            this.xMaxTextBox = new System.Windows.Forms.TextBox();
            this.yMinTextBox = new System.Windows.Forms.TextBox();
            this.yMaxTextBox = new System.Windows.Forms.TextBox();
            this.toolStripCoordinatesLabel = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.statusStrip.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox.Location = new System.Drawing.Point(193, 27);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(595, 398);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            this.pictureBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseDoubleClick);
            this.pictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseMove);
            // 
            // vykresliButton
            // 
            this.vykresliButton.Location = new System.Drawing.Point(12, 162);
            this.vykresliButton.Name = "vykresliButton";
            this.vykresliButton.Size = new System.Drawing.Size(175, 23);
            this.vykresliButton.TabIndex = 2;
            this.vykresliButton.Text = "Vykresli fraktál";
            this.vykresliButton.UseVisualStyleBackColor = true;
            this.vykresliButton.Click += new System.EventHandler(this.vykresliButton_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar,
            this.toolStripStatusLabel,
            this.toolStripCoordinatesLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 428);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(800, 22);
            this.statusStrip.TabIndex = 7;
            // 
            // toolStripProgressBar
            // 
            this.toolStripProgressBar.Name = "toolStripProgressBar";
            this.toolStripProgressBar.Size = new System.Drawing.Size(100, 16);
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "X min";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "X max";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Y min";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Y max";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.souborToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // souborToolStripMenuItem
            // 
            this.souborToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ulozitObrazekToolStripMenuItem,
            this.ulozitParametryToolStripMenuItem,
            this.nacistParametryToolStripMenuItem});
            this.souborToolStripMenuItem.Name = "souborToolStripMenuItem";
            this.souborToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.souborToolStripMenuItem.Text = "Soubor";
            // 
            // ulozitObrazekToolStripMenuItem
            // 
            this.ulozitObrazekToolStripMenuItem.Name = "ulozitObrazekToolStripMenuItem";
            this.ulozitObrazekToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.ulozitObrazekToolStripMenuItem.Text = "Uložit obázek";
            this.ulozitObrazekToolStripMenuItem.Click += new System.EventHandler(this.ulozitObrazekToolStripMenuItem_Click);
            // 
            // ulozitParametryToolStripMenuItem
            // 
            this.ulozitParametryToolStripMenuItem.Name = "ulozitParametryToolStripMenuItem";
            this.ulozitParametryToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.ulozitParametryToolStripMenuItem.Text = "Uložit parametry";
            this.ulozitParametryToolStripMenuItem.Click += new System.EventHandler(this.ulozitParametryToolStripMenuItem_Click);
            // 
            // nacistParametryToolStripMenuItem
            // 
            this.nacistParametryToolStripMenuItem.Name = "nacistParametryToolStripMenuItem";
            this.nacistParametryToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.nacistParametryToolStripMenuItem.Text = "Načíst parametry";
            this.nacistParametryToolStripMenuItem.Click += new System.EventHandler(this.nacistParametryToolStripMenuItem_Click);
            // 
            // xMinTextBox
            // 
            this.xMinTextBox.Location = new System.Drawing.Point(51, 27);
            this.xMinTextBox.Name = "xMinTextBox";
            this.xMinTextBox.Size = new System.Drawing.Size(136, 20);
            this.xMinTextBox.TabIndex = 13;
            this.xMinTextBox.Text = "-2,5";
            // 
            // xMaxTextBox
            // 
            this.xMaxTextBox.Location = new System.Drawing.Point(51, 51);
            this.xMaxTextBox.Name = "xMaxTextBox";
            this.xMaxTextBox.Size = new System.Drawing.Size(136, 20);
            this.xMaxTextBox.TabIndex = 14;
            this.xMaxTextBox.Text = "1";
            // 
            // yMinTextBox
            // 
            this.yMinTextBox.Location = new System.Drawing.Point(51, 92);
            this.yMinTextBox.Name = "yMinTextBox";
            this.yMinTextBox.Size = new System.Drawing.Size(136, 20);
            this.yMinTextBox.TabIndex = 15;
            this.yMinTextBox.Text = "-1";
            // 
            // yMaxTextBox
            // 
            this.yMaxTextBox.Location = new System.Drawing.Point(51, 118);
            this.yMaxTextBox.Name = "yMaxTextBox";
            this.yMaxTextBox.Size = new System.Drawing.Size(136, 20);
            this.yMaxTextBox.TabIndex = 16;
            this.yMaxTextBox.Text = "1";
            // 
            // toolStripCoordinatesLabel
            // 
            this.toolStripCoordinatesLabel.Name = "toolStripCoordinatesLabel";
            this.toolStripCoordinatesLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // Zobrazovac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.yMaxTextBox);
            this.Controls.Add(this.yMinTextBox);
            this.Controls.Add(this.xMaxTextBox);
            this.Controls.Add(this.xMinTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.vykresliButton);
            this.Controls.Add(this.pictureBox);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Zobrazovac";
            this.Text = "Zobrazovač Mandelbrotovi množiny";
            this.ResizeEnd += new System.EventHandler(this.Zobrazovac_ResizeEnd);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button vykresliButton;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem souborToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ulozitObrazekToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nacistParametryToolStripMenuItem;
        private System.Windows.Forms.TextBox xMinTextBox;
        private System.Windows.Forms.TextBox xMaxTextBox;
        private System.Windows.Forms.TextBox yMinTextBox;
        private System.Windows.Forms.TextBox yMaxTextBox;
        private System.Windows.Forms.ToolStripMenuItem ulozitParametryToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel toolStripCoordinatesLabel;
    }
}

