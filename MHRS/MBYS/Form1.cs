using System.Data;
using Npgsql;

namespace MBYS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void HastaListeleBtn1_Click(object sender, EventArgs e)
        {
           HastaListele hastaListele= new HastaListele();
            hastaListele.Show();
        }

        private void HastaKayitBtn1_Click(object sender, EventArgs e)
        {
            HastaKayit hastaKayit= new HastaKayit();
            hastaKayit.Show();
        }

        private void MuayeneDefteriBtn1_Click(object sender, EventArgs e)
        {
            Muayene muayene= new Muayene();
            muayene.Show();
        }

        private void RecetelerBtn1_Click(object sender, EventArgs e)
        {
            Recete recete = new Recete();
            recete.Show();
        }

        private void Hasta›lacTakip1_Click(object sender, EventArgs e)
        {
            HastaTakip hastaTakip = new HastaTakip();
            hastaTakip.Show();
        }

        private void ›lacEkleBtn1_Click(object sender, EventArgs e)
        {
            ›lacEkle ilacEkle = new ›lacEkle();
            ilacEkle.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HastaArama hastaArama= new HastaArama();
            hastaArama.Show();
        }
    }
}