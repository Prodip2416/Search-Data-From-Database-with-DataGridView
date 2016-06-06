using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace PersonDataView
{
    public partial class Form1 : Form
    {
       string  qury="Data Source=PRODIP-PC;Initial Catalog=UpdateInfo;Integrated Security=True;Pooling=False";

        public Form1()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {   
           SqlConnection con = new SqlConnection(qury);
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from Person_Info", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
           SqlConnection con = new SqlConnection(qury);
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from Person_Info where Name like '" + txtSearch.Text + "%'", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();

        }
    }
}
