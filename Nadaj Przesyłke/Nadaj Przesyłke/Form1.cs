namespace Nadaj_Przesyłke
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void daneAdresowe_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void sprawdzCene_Click(object sender, EventArgs e)
        {
            if (pocztowka.Checked) // sprawdzamy czy checkbox zaznaczony
            {
                zdjecie.Image = Properties.Resources.pocztowka; // z jakis resourcow ustawiamy pocztowke (ustawia sie to w wlasnosciach zdjecia, dodajemy do tych risorcow wszystkie zdjecia jakie tam beda sie wyswietlaly)
                cena.Text = "Cena: 1zł"; // updejt labela
            }
            if (list.Checked) // podobnie do 1
            {
                zdjecie.Image = Properties.Resources.list; 
                cena.Text = "Cena: 1.5zł";
            } 
            if (paczka.Checked) // podobnie do 1
            {
                zdjecie.Image = Properties.Resources.paczka;
                cena.Text = "Cena: 10zł";
            }
        }

        private void zatwierdz_Click(object sender, EventArgs e)
        {
            if (kod.TextLength < 5 || kod.TextLength > 5) { // sprawdzamy czy haslo ma 5 znakow jesli nie to komunikat (mozna chyba tez zrobic kod.TextLength != 5)
                MessageBox.Show("Nieprawidłowa liczba cyfr w kodzie\r\npocztowym");
                return;
            }
            String cyfry = "0123456789"; // to useless zapomnailem usunac
            foreach (char c in kod.Text) // przechodzimy przez kazdy znak (c)
            {
                if (!char.IsDigit(c)) // sprawdzamy czy jest liczba
                {
                    MessageBox.Show("Kod nie zawiera samych cyfr"); // 
                    return;
                }
            }
            MessageBox.Show("Kod jest git"); // komunikat jesli wszystko przeszlo i funkcja nie zakonczyla wczesniej swojego dzialania
        }
    }
}
