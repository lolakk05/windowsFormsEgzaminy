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
            if (pocztowka.Checked)
            {
                zdjecie.Image = Properties.Resources.pocztowka;
                cena.Text = "Cena: 1zł";
            }
            if (list.Checked)
            {
                zdjecie.Image = Properties.Resources.list;
                cena.Text = "Cena: 1.5zł";
            }
            if (paczka.Checked)
            {
                zdjecie.Image = Properties.Resources.paczka;
                cena.Text = "Cena: 10zł";
            }
        }

        private void zatwierdz_Click(object sender, EventArgs e)
        {
            if (kod.TextLength < 5 || kod.TextLength > 5)
            {
                MessageBox.Show("Nieprawidłowa liczba cyfr w kodzie\r\npocztowym");
                return;
            }
            String cyfry = "0123456789";
            foreach (char c in kod.Text)
            {
                if (!char.IsDigit(c))
                {
                    MessageBox.Show("Kod nie zawiera samych cyfr");
                    return;
                }
            }
            MessageBox.Show("Kod jest git");
        }
    }
}
