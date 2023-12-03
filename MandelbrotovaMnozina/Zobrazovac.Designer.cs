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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(193, 12);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(595, 426);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // vykresliButton
            // 
            this.vykresliButton.Location = new System.Drawing.Point(12, 12);
            this.vykresliButton.Name = "vykresliButton";
            this.vykresliButton.Size = new System.Drawing.Size(175, 23);
            this.vykresliButton.TabIndex = 2;
            this.vykresliButton.Text = "Vykresli fraktál";
            this.vykresliButton.UseVisualStyleBackColor = true;
            this.vykresliButton.Click += new System.EventHandler(this.vykresliButton_Click);
            // 
            // Zobrazovac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.vykresliButton);
            this.Controls.Add(this.pictureBox);
            this.Name = "Zobrazovac";
            this.Text = "Zobrazovač Mandelbrotovi množiny";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button vykresliButton;
    }
}

