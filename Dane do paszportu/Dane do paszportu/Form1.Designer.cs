namespace Dane_do_paszportu
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            numerLabel = new Label();
            imieLabel = new Label();
            nazwiskoLabel = new Label();
            numer = new TextBox();
            imie = new TextBox();
            nazwisko = new TextBox();
            grupa = new GroupBox();
            piwne = new RadioButton();
            zielone = new RadioButton();
            niebieskie = new RadioButton();
            zdjecie = new PictureBox();
            odcisk = new PictureBox();
            przycisk = new Button();
            grupa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)zdjecie).BeginInit();
            ((System.ComponentModel.ISupportInitialize)odcisk).BeginInit();
            SuspendLayout();
            // 
            // numerLabel
            // 
            numerLabel.AutoSize = true;
            numerLabel.Location = new Point(49, 49);
            numerLabel.Name = "numerLabel";
            numerLabel.Size = new Size(44, 15);
            numerLabel.TabIndex = 0;
            numerLabel.Text = "Numer";
            // 
            // imieLabel
            // 
            imieLabel.AutoSize = true;
            imieLabel.Location = new Point(49, 83);
            imieLabel.Name = "imieLabel";
            imieLabel.Size = new Size(30, 15);
            imieLabel.TabIndex = 1;
            imieLabel.Text = "Imię";
            // 
            // nazwiskoLabel
            // 
            nazwiskoLabel.AutoSize = true;
            nazwiskoLabel.Location = new Point(49, 119);
            nazwiskoLabel.Name = "nazwiskoLabel";
            nazwiskoLabel.Size = new Size(57, 15);
            nazwiskoLabel.TabIndex = 2;
            nazwiskoLabel.Text = "Nazwisko";
            // 
            // numer
            // 
            numer.BackColor = Color.Azure;
            numer.Location = new Point(148, 41);
            numer.Name = "numer";
            numer.Size = new Size(217, 23);
            numer.TabIndex = 3;
            numer.TextChanged += numer_TextChanged;
            numer.Leave += numer_Leave;
            // 
            // imie
            // 
            imie.BackColor = Color.Azure;
            imie.Location = new Point(148, 75);
            imie.Name = "imie";
            imie.Size = new Size(217, 23);
            imie.TabIndex = 4;
            // 
            // nazwisko
            // 
            nazwisko.BackColor = Color.Azure;
            nazwisko.Location = new Point(148, 111);
            nazwisko.Name = "nazwisko";
            nazwisko.Size = new Size(217, 23);
            nazwisko.TabIndex = 5;
            // 
            // grupa
            // 
            grupa.Controls.Add(piwne);
            grupa.Controls.Add(zielone);
            grupa.Controls.Add(niebieskie);
            grupa.Location = new Point(48, 169);
            grupa.Name = "grupa";
            grupa.Size = new Size(317, 128);
            grupa.TabIndex = 6;
            grupa.TabStop = false;
            grupa.Text = "Kolor oczu";
            // 
            // piwne
            // 
            piwne.AutoSize = true;
            piwne.Location = new Point(15, 96);
            piwne.Name = "piwne";
            piwne.Size = new Size(57, 19);
            piwne.TabIndex = 2;
            piwne.Text = "piwne";
            piwne.UseVisualStyleBackColor = true;
            // 
            // zielone
            // 
            zielone.AutoSize = true;
            zielone.Location = new Point(15, 61);
            zielone.Name = "zielone";
            zielone.Size = new Size(62, 19);
            zielone.TabIndex = 1;
            zielone.Text = "zielone";
            zielone.UseVisualStyleBackColor = true;
            zielone.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // niebieskie
            // 
            niebieskie.AutoSize = true;
            niebieskie.Checked = true;
            niebieskie.Location = new Point(15, 27);
            niebieskie.Name = "niebieskie";
            niebieskie.Size = new Size(77, 19);
            niebieskie.TabIndex = 0;
            niebieskie.TabStop = true;
            niebieskie.Text = "niebieskie";
            niebieskie.UseVisualStyleBackColor = true;
            // 
            // zdjecie
            // 
            zdjecie.Image = Properties.Resources._000_zdjecie;
            zdjecie.Location = new Point(401, 41);
            zdjecie.Name = "zdjecie";
            zdjecie.Size = new Size(195, 225);
            zdjecie.SizeMode = PictureBoxSizeMode.AutoSize;
            zdjecie.TabIndex = 7;
            zdjecie.TabStop = false;
            // 
            // odcisk
            // 
            odcisk.Image = Properties.Resources._111_odcisk;
            odcisk.Location = new Point(642, 41);
            odcisk.Name = "odcisk";
            odcisk.Size = new Size(152, 225);
            odcisk.SizeMode = PictureBoxSizeMode.Zoom;
            odcisk.TabIndex = 8;
            odcisk.TabStop = false;
            // 
            // przycisk
            // 
            przycisk.BackColor = Color.Azure;
            przycisk.Location = new Point(488, 284);
            przycisk.Name = "przycisk";
            przycisk.Size = new Size(235, 37);
            przycisk.TabIndex = 9;
            przycisk.Text = "OK";
            przycisk.UseVisualStyleBackColor = false;
            przycisk.Click += przycisk_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CadetBlue;
            ClientSize = new Size(833, 350);
            Controls.Add(przycisk);
            Controls.Add(odcisk);
            Controls.Add(zdjecie);
            Controls.Add(grupa);
            Controls.Add(nazwisko);
            Controls.Add(imie);
            Controls.Add(numer);
            Controls.Add(nazwiskoLabel);
            Controls.Add(imieLabel);
            Controls.Add(numerLabel);
            Name = "Form1";
            Text = "Dodawanie danych do paszportu";
            grupa.ResumeLayout(false);
            grupa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)zdjecie).EndInit();
            ((System.ComponentModel.ISupportInitialize)odcisk).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label numerLabel;
        private Label imieLabel;
        private Label nazwiskoLabel;
        private TextBox numer;
        private TextBox imie;
        private TextBox nazwisko;
        private GroupBox grupa;
        private RadioButton piwne;
        private RadioButton zielone;
        private RadioButton niebieskie;
        private PictureBox zdjecie;
        private PictureBox odcisk;
        private Button przycisk;
    }
}
