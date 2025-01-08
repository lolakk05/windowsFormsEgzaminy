namespace Nadaj_Przesyłke
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
            rodzajPrzesylki = new GroupBox();
            paczka = new RadioButton();
            list = new RadioButton();
            pocztowka = new RadioButton();
            daneAdresowe = new GroupBox();
            miasto = new TextBox();
            label3 = new Label();
            kod = new TextBox();
            label2 = new Label();
            ulica = new TextBox();
            label1 = new Label();
            sprawdzCene = new Button();
            zdjecie = new PictureBox();
            cena = new Label();
            zatwierdz = new Button();
            rodzajPrzesylki.SuspendLayout();
            daneAdresowe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)zdjecie).BeginInit();
            SuspendLayout();
            // 
            // rodzajPrzesylki
            // 
            rodzajPrzesylki.Controls.Add(paczka);
            rodzajPrzesylki.Controls.Add(list);
            rodzajPrzesylki.Controls.Add(pocztowka);
            rodzajPrzesylki.Location = new Point(40, 38);
            rodzajPrzesylki.Name = "rodzajPrzesylki";
            rodzajPrzesylki.Size = new Size(279, 180);
            rodzajPrzesylki.TabIndex = 0;
            rodzajPrzesylki.TabStop = false;
            rodzajPrzesylki.Text = "Rodzaj Przesyłki";
            // 
            // paczka
            // 
            paczka.AutoSize = true;
            paczka.Location = new Point(14, 128);
            paczka.Name = "paczka";
            paczka.Size = new Size(61, 19);
            paczka.TabIndex = 2;
            paczka.TabStop = true;
            paczka.Text = "Paczka";
            paczka.UseVisualStyleBackColor = true;
            // 
            // list
            // 
            list.AutoSize = true;
            list.Location = new Point(14, 86);
            list.Name = "list";
            list.Size = new Size(43, 19);
            list.TabIndex = 1;
            list.TabStop = true;
            list.Text = "List";
            list.UseVisualStyleBackColor = true;
            list.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // pocztowka
            // 
            pocztowka.AutoSize = true;
            pocztowka.Location = new Point(14, 42);
            pocztowka.Name = "pocztowka";
            pocztowka.Size = new Size(82, 19);
            pocztowka.TabIndex = 0;
            pocztowka.TabStop = true;
            pocztowka.Text = "Pocztówka";
            pocztowka.UseVisualStyleBackColor = true;
            // 
            // daneAdresowe
            // 
            daneAdresowe.Controls.Add(miasto);
            daneAdresowe.Controls.Add(label3);
            daneAdresowe.Controls.Add(kod);
            daneAdresowe.Controls.Add(label2);
            daneAdresowe.Controls.Add(ulica);
            daneAdresowe.Controls.Add(label1);
            daneAdresowe.Location = new Point(412, 38);
            daneAdresowe.Name = "daneAdresowe";
            daneAdresowe.Size = new Size(376, 318);
            daneAdresowe.TabIndex = 1;
            daneAdresowe.TabStop = false;
            daneAdresowe.Text = "Dane adresowe";
            daneAdresowe.Enter += daneAdresowe_Enter;
            // 
            // miasto
            // 
            miasto.Location = new Point(20, 238);
            miasto.Name = "miasto";
            miasto.Size = new Size(345, 23);
            miasto.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 211);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 4;
            label3.Text = "Miasto";
            label3.Click += label3_Click;
            // 
            // kod
            // 
            kod.Location = new Point(20, 157);
            kod.Name = "kod";
            kod.Size = new Size(350, 23);
            kod.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 128);
            label2.Name = "label2";
            label2.Size = new Size(82, 15);
            label2.TabIndex = 2;
            label2.Text = "Kod pocztowy";
            // 
            // ulica
            // 
            ulica.Location = new Point(20, 70);
            ulica.Name = "ulica";
            ulica.Size = new Size(350, 23);
            ulica.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 42);
            label1.Name = "label1";
            label1.Size = new Size(96, 15);
            label1.TabIndex = 0;
            label1.Text = "Ulica z numerem";
            // 
            // sprawdzCene
            // 
            sprawdzCene.Location = new Point(40, 234);
            sprawdzCene.Name = "sprawdzCene";
            sprawdzCene.Size = new Size(279, 30);
            sprawdzCene.TabIndex = 2;
            sprawdzCene.Text = "Sprawdź Cenę";
            sprawdzCene.UseVisualStyleBackColor = true;
            sprawdzCene.Click += sprawdzCene_Click;
            // 
            // zdjecie
            // 
            zdjecie.Image = Properties.Resources.list;
            zdjecie.Location = new Point(40, 291);
            zdjecie.Name = "zdjecie";
            zdjecie.Size = new Size(100, 65);
            zdjecie.TabIndex = 3;
            zdjecie.TabStop = false;
            // 
            // cena
            // 
            cena.AutoSize = true;
            cena.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            cena.Location = new Point(177, 291);
            cena.Name = "cena";
            cena.Size = new Size(84, 32);
            cena.TabIndex = 4;
            cena.Text = "Cena: ";
            // 
            // zatwierdz
            // 
            zatwierdz.Location = new Point(40, 415);
            zatwierdz.Name = "zatwierdz";
            zatwierdz.Size = new Size(737, 23);
            zatwierdz.TabIndex = 5;
            zatwierdz.Text = "Zatwierdź";
            zatwierdz.UseVisualStyleBackColor = true;
            zatwierdz.Click += zatwierdz_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(zatwierdz);
            Controls.Add(cena);
            Controls.Add(zdjecie);
            Controls.Add(sprawdzCene);
            Controls.Add(daneAdresowe);
            Controls.Add(rodzajPrzesylki);
            Name = "Form1";
            Text = " ";
            rodzajPrzesylki.ResumeLayout(false);
            rodzajPrzesylki.PerformLayout();
            daneAdresowe.ResumeLayout(false);
            daneAdresowe.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)zdjecie).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox rodzajPrzesylki;
        private GroupBox daneAdresowe;
        private Button sprawdzCene;
        private RadioButton paczka;
        private RadioButton list;
        private RadioButton pocztowka;
        private PictureBox zdjecie;
        private Label label3;
        private TextBox kod;
        private Label label2;
        private TextBox ulica;
        private Label label1;
        private Label cena;
        private TextBox miasto;
        private Button zatwierdz;
    }
}
