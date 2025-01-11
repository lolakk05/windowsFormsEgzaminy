namespace Albumy
{
    public partial class Form1 : Form
    {
        List<Album> albumy = new List<Album>();
        public int aktualnyIndex = 0;

        public class Album
        {
            public string Artysta { get; set; }
            public string Tytul { get; set; }
            public string LiczbaPiosenek { get; set; }
            public int Rok { get; set; }
            public ulong LiczbaPobran { get; set; }

            public Album(string artysta, string tytul, string liczbaPiosenek, int rok, ulong liczbaPobran)
            {
                Artysta = artysta;
                Tytul = tytul;
                LiczbaPiosenek = liczbaPiosenek;
                Rok = rok;
                LiczbaPobran = liczbaPobran;
            }
        }

        public Form1()
        {
            InitializeComponent();
            string[] linie = File.ReadAllLines("Data.txt");
            int i = 0;
            while (i + 4 < linie.Length)
            {
                string artysta = linie[i];
                string tytul = linie[i + 1];
                string liczbaPiosenek = linie[i + 2];
                int rok = int.Parse(linie[i + 3]);
                ulong liczbaPobran = ulong.Parse(linie[i + 4]);

                Album nowyAlbum = new Album(artysta, tytul, liczbaPiosenek, rok, liczbaPobran);
                albumy.Add(nowyAlbum);
                i += 6;
                wyswietlAlbum();
            }
        }
        private void wyswietlAlbum()
        {
            Album aktualnyAlbum = albumy[aktualnyIndex];
            label1.Text = aktualnyAlbum.Artysta;
            label2.Text = aktualnyAlbum.Tytul;
            label3.Text = aktualnyAlbum.LiczbaPiosenek;
            label4.Text = aktualnyAlbum.Rok.ToString();
            label5.Text = aktualnyAlbum.LiczbaPobran.ToString();
        }
        private void przyciskPrawo_Click(object sender, EventArgs e)
        {
            aktualnyIndex = (aktualnyIndex + 1) % albumy.Count;
            wyswietlAlbum();
        }

        private void przyciskLewo_Click(object sender, EventArgs e)
        {
            aktualnyIndex = (aktualnyIndex - 1 + albumy.Count) % albumy.Count;
            wyswietlAlbum();
        }
    }
}
