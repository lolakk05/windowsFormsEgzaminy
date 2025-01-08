namespace Windows_Forms
{
    public partial class Form1 : Form
    {
        private string wygenerowaneHaslo; // deklaracja zmiennej globalnej do przetrzymywania hasla
        public Form1()
        {
            InitializeComponent();a
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String imie = (String)textBox1.Text; // tu można po prostu w komunikacie dodać textBox1.Text i nie trzeba deklarować
            String nazwisko = (String)textBox2.Text;
            String stanowisko = (String)comboBox1.Text;
            String komunikat = "Dane pracownika: " + imie + ' ' + nazwisko + ' ' + stanowisko + ' ' + wygenerowaneHaslo ;
            MessageBox.Show(komunikat); // komunikat którego treść jest zawarta w zmiennej komunikat
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
            String pobrana = (String)textBox3.Text;  // dlugosc w stringu
            int dlugosc  = Convert.ToInt32(pobrana); // konwersja dlugosci hasla na inta
            String haslo = ""; 
            String cyfry = "0123456789"; // zestaw cyfr
            String znakiSpecjalne = "!@#$%^&*()_+-="; // zestaw znakow
            String litery = "qwertyuiopasdfghjklzxcvbnm"; // zestawy liter
            String duzeLitery = "QWERTYUIOPASDFGHJKLZXCVBNM";
            Random random = new Random(); // cos co jest odpowiadajace za losowanie liczb nie wiem co to ale tak to dziala
            if (checkBox1.Checked) // jesli zaznaczony
            {
                int wylosowana = random.Next(cyfry.Length); // losujemy z 0 - 9
                haslo += wylosowana; // dopisujemy do hasla
            }
            if (checkBox2.Checked) {
                int wylosowana = random.Next(duzeLitery.Length); // losujemy z zakresu takiego jak dlugosc zestawu
                haslo += duzeLitery[wylosowana]; // odwolujemy sie do wartosci o wylosowanym indexie
            }
            if (checkBox3.Checked) {
                int wylosowana = random.Next(znakiSpecjalne.Length);
                haslo += znakiSpecjalne[wylosowana];
            }
            for (int i = haslo.Length; i < dlugosc; i++) { // ustawiamy i na obecna dlugosc i dokanczamy haslo
                int wylosowana = random.Next(litery.Length); 
                haslo += litery[wylosowana];
            }
            wygenerowaneHaslo = haslo; // przypisujemy haslo do wartosci zmiennej globalnej zeby moc odwolac sie w innej funkcji
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
