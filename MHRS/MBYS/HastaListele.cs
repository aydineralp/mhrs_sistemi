using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Npgsql;
using System.Data.Common;
using System.Collections;

namespace MBYS
{
    public partial class HastaListele : Form
    {
        public HastaListele()
        {
            InitializeComponent();
        }

        NpgsqlConnection cnctn = new NpgsqlConnection("server=localHost; port=5432;Database=mbys; user ID=postgres; password=1234");
        private void HastaListeleBtn2_Click(object sender, EventArgs e)
        {
            string query = "select * from hastalar";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, cnctn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            DataGridViewListele1.DataSource = ds.Tables[0];
        }
    }
}
