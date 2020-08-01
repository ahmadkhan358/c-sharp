using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace Database_Connectivity
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void showbtn_Click(object sender, EventArgs e)
        {
            String conn = @"Data Source=HP-FOLIO-1040; Initial Catalog=HRDB; Integrated Security=true;";
            SqlConnection sqlconn = new SqlConnection(conn);

            sqlconn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = sqlconn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "dataFetch";

            SqlDataAdapter adapter = new SqlDataAdapter("dataFetch", sqlconn);
            DataSet set = new DataSet();

            adapter.Fill(set);

            showdatagrid.DataSource = set.Tables[0];

        }

        private void insertbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }

        private void showvalidationbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            ValidationForm vf = new ValidationForm();
            vf.ShowDialog();
        }

        private void reportbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Report r = new Report();
            r.ShowDialog();
        }
    }
}
