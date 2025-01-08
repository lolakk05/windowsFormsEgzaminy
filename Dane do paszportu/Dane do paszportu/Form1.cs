namespace Dane_do_paszportu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void numer_TextChanged(object sender, EventArgs e)
        {

        }

        private void numer_Leave(object sender, EventArgs e)
        {
            String numerString = numer.Text; // pobranie wartosci z textboxa
            String sciezkaZdjecie = $"Obrazy\\{numerString}-zdjecie.jpg"; // ustawienie sciezki w ktorej jest nasz obraz 
            String sciezkaOdcisk = $"Obrazy\\{numerString}-odcisk.jpg"; // to samo GIGA WAZNE Obrazy musi byæ w bin\debug\dotnet iles
            if (File.Exists(sciezkaZdjecie)) // sprawdzenie czy obraz istnieje
            {
                zdjecie.Image = Image.FromFile(sciezkaZdjecie); //ustawienie obrazow
                odcisk.Image = Image.FromFile(sciezkaOdcisk);
            }
            else //jesli nie ustawiamy puste
            {
                zdjecie.Image = null;
                odcisk.Image = null;
            }
        }

        private void przycisk_Click(object sender, EventArgs e)
        {
            String kolor = "";
            if (niebieskie.Checked) { kolor = "niebieskie"; } // pobranie wartosci z odp radioBtn
            if (zielone.Checked) { kolor = "zielone"; }
            if (piwne.Checked) { kolor = "piwne"; }  
            if (imie.Text.Length != 0 && nazwisko.Text.Length != 0 && numer.Text.Length != 0) // giga chadowy warunek
            {
                MessageBox.Show($"{imie.Text} {nazwisko.Text} kolor oczu {kolor}"); // messagebox $ przed oznacza ze mozemy pisac zmienne w klamerkach, inaczej trzeba uzywac +
            }
            else
            {
                MessageBox.Show("WprowadŸ dane");
            }
        }
    }
}
