using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MBYS
{
    public partial class HastaKayit : Form
    {
        public HastaKayit()
        {
            InitializeComponent();
        }
        NpgsqlConnection cnctn = new NpgsqlConnection("server=localHost; port=5432;Database=mbys; user ID=postgres; password=1234");

        private void HastaKayit_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void KayitEtBtn1_Click(object sender, EventArgs e)
        {

            cnctn.Open();
            NpgsqlCommand kmt = new NpgsqlCommand("INSERT INTO hastalar (hasta_tc, hasta_adi, hasta_soyadi, dogum_tarih, dogum_yeri, medeni_durum, telefon_no, adres ) values(@hasta_tc, @hasta_adi, @hasta_soyadi, @dogum_tarih, @dogum_yeri, @medeni_durum, @telefon_no, @adres)", cnctn);
            kmt.Parameters.AddWithValue("@hasta_tc", Convert.ToInt64(tcText.Text));
            kmt.Parameters.AddWithValue("@hasta_adi", adText.Text);
            kmt.Parameters.AddWithValue("@hasta_soyadi", soyadText.Text);
            kmt.Parameters.AddWithValue("@dogum_tarih", DateTime.Parse(dogumtarihiText.Text));
            kmt.Parameters.AddWithValue("@dogum_yeri", dogumyeriText.Text);  
            kmt.Parameters.AddWithValue("@medeni_durum", medenidurumText.Text);
            kmt.Parameters.AddWithValue("@telefon_no", Convert.ToInt64(telefonText.Text));
            kmt.Parameters.AddWithValue("@adres", adresText.Text);
            kmt.ExecuteNonQuery();
            cnctn.Close();
            MessageBox.Show("Kayıt işlemi başarılı bir şekilde gerçekleşti");
        }
    }
}
