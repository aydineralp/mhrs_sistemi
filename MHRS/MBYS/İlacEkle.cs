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
    public partial class İlacEkle : Form
    {
        public İlacEkle()
        {
            InitializeComponent();
        }
        NpgsqlConnection cnctn = new NpgsqlConnection("server=localHost; port=5432;Database=mbys; user ID=postgres; password=1234");

        private void İlacEkleBtn1_Click(object sender, EventArgs e)
        {
            string query = "select * from ilaclar";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, cnctn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void İlacEkleBtn2_Click(object sender, EventArgs e)
        {
            cnctn.Open();
            NpgsqlCommand kmt = new NpgsqlCommand("INSERT INTO ilaclar (barkod_no, ilac_adi, ilac_tipi) values(@barkod_no, @ilac_adi, @ilac_tipi)", cnctn);
            kmt.Parameters.AddWithValue("@barkod_no", Convert.ToInt64(textBox1.Text));
            kmt.Parameters.AddWithValue("@ilac_adi", textBox2.Text);
            kmt.Parameters.AddWithValue("@ilac_tipi", textBox3.Text);
            kmt.ExecuteNonQuery();
            cnctn.Close();
            MessageBox.Show("Kayıt işlemi başarılı bir şekilde gerçekleşti");
        }
    }
}
