namespace Windows_Forms
{
    public partial class Form1 : Form
    {
        private string wygenerowaneHaslo;
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String imie = (String)textBox1.Text;
            String nazwisko = (String)textBox2.Text;
            String stanowisko = (String)comboBox1.Text;
            String komunikat = "Dane pracownika: " + imie + ' ' + nazwisko + ' ' + stanowisko + ' ' + wygenerowaneHaslo ;
            MessageBox.Show(komunikat);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            String pobrana = (String)textBox3.Text;
            int dlugosc  = Convert.ToInt32(pobrana);
            String haslo = "";
            String cyfry = "0123456789";
            String znakiSpecjalne = "!@#$%^&*()_+-=";
            String litery = "qwertyuiopasdfghjklzxcvbnm";
            String duzeLitery = "QWERTYUIOPASDFGHJKLZXCVBNM";
            Random random = new Random();
            if (checkBox1.Checked)
            {
                int wylosowana = random.Next(cyfry.Length);
                haslo += wylosowana;
            }
            if (checkBox2.Checked) {
                int wylosowana = random.Next(duzeLitery.Length);
                haslo += duzeLitery[wylosowana];
            }
            if (checkBox3.Checked) {
                int wylosowana = random.Next(znakiSpecjalne.Length);
                haslo += znakiSpecjalne[wylosowana];
            }
            for (int i = haslo.Length; i < dlugosc; i++) {
                int wylosowana = random.Next(litery.Length);
                haslo += litery[wylosowana];
            }
            wygenerowaneHaslo = haslo;
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
