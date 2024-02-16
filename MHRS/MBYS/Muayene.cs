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

namespace MBYS
{
    public partial class Muayene : Form
    {
        public Muayene()
        {
            InitializeComponent();
        }
        NpgsqlConnection cnctn = new NpgsqlConnection("server=localHost; port=5432;Database=mbys; user ID=postgres; password=1234");
        private void ListeleBtn3_Click(object sender, EventArgs e)
        {
            string query = "select * from muayeneler";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, cnctn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridViewListele3.DataSource = ds.Tables[0];
        }

        
private void EkleBtn3_Click(object sender, EventArgs e)
        {
            cnctn.Open();
            NpgsqlCommand kmt = new NpgsqlCommand("INSERT INTO muayeneler (hasta_tc, muayene_tarihi, hastanin_sikayeti, onerilen_tedavi, recete_no ) values(@hasta_tc, @muayene_tarihi, @hastanin_sikayeti, @onerilen_tedavi, @recete_no)", cnctn);
            kmt.Parameters.AddWithValue("@hasta_tc", Convert.ToInt64(textBox1.Text));
            kmt.Parameters.AddWithValue("@muayene_tarihi", DateTime.Parse(textBox2.Text));
            kmt.Parameters.AddWithValue("@hastanin_sikayeti", richTextBox1.Text);
            kmt.Parameters.AddWithValue("@onerilen_tedavi", richTextBox2.Text);
            kmt.Parameters.AddWithValue("@recete_no", Convert.ToInt64(textBox3.Text));
            kmt.ExecuteNonQuery();
            cnctn.Close();
            MessageBox.Show("Kayıt işlemi başarılı bir şekilde gerçekleşti");

        }
    }
}
