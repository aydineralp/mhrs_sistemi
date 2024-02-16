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
    public partial class Recete : Form
    {
        public Recete()
        {
            InitializeComponent();
        }

        NpgsqlConnection cnctn = new NpgsqlConnection("server=localHost; port=5432;Database=mbys; user ID=postgres; password=1234");
        private void ListeleBtn4_Click(object sender, EventArgs e)
        {

            string query = "select * from receteler";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, cnctn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

        }

        private void EkleBtn4_Click(object sender, EventArgs e)
        {
            cnctn.Open();
            NpgsqlCommand kmt = new NpgsqlCommand("INSERT INTO receteler (hasta_tc, recete_no, barkod_no, hasta_adi ) values(@hasta_tc, @recete_no, @barkod_no, @hasta_adi)", cnctn);
            kmt.Parameters.AddWithValue("@hasta_tc", Convert.ToInt64(textBox1.Text));
            kmt.Parameters.AddWithValue("@barkod_no", Convert.ToInt64(textBox3.Text));
            kmt.Parameters.AddWithValue("@recete_no", Convert.ToInt64(textBox2.Text));
            kmt.Parameters.AddWithValue("@hasta_adi", (textBox4.Text));
            kmt.ExecuteNonQuery();
            cnctn.Close();
            MessageBox.Show("Kayıt işlemi başarılı bir şekilde gerçekleşti");
        }
    }
}
