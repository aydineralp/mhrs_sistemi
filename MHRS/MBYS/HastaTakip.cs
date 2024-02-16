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
    public partial class HastaTakip : Form
    {
        public HastaTakip()
        {
            InitializeComponent();
        }
        NpgsqlConnection cnctn = new NpgsqlConnection("server=localHost; port=5432;Database=mbys; user ID=postgres; password=1234");

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void HastaListeleBtn2_Click(object sender, EventArgs e)
        {
            cnctn.Open();

            NpgsqlCommand kmt = new NpgsqlCommand("select * from hastara where ilac_adi Like '%" + textBox1.Text + "%'", cnctn);
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(kmt);
            DataSet ds = new DataSet();
            da.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];

            cnctn.Close();
        }

        private void ListeleBtn5_Click(object sender, EventArgs e)
        {
            cnctn.Open();

            string query = "select * from hastara";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, cnctn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            cnctn.Close();

        }
    }
}
