using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace Database_Connectivity
{
    public partial class Form2 : Form
    {

        private int id;

        public Form2()
        {
            id = -1;
            InitializeComponent();
        }

        private void insertbtn_Click(object sender, EventArgs e)
        {
            string name = nametxtbox.Text;
            int salary = int.Parse(salarytxtbox.Text);
            string designation = designationtxtbox.Text;

            try
            {
                String conn = @"Data Source=HP-FOLIO-1040; Initial Catalog=HRDB; Integrated Security=true;";
                SqlConnection sqlconn = new SqlConnection(conn);

                sqlconn.Open();
                
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = sqlconn;

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "dataInsert";

                cmd.Parameters.Add(new SqlParameter("@empName", SqlDbType.VarChar)).Value = name;
                cmd.Parameters.Add(new SqlParameter("@empSalary", SqlDbType.VarChar)).Value = salary;
                cmd.Parameters.Add(new SqlParameter("@desig", SqlDbType.VarChar)).Value = designation;

                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("The record has been inserted");
                }
                else
                {
                    MessageBox.Show("Record not inserted");
                }

            }
            catch(Exception excp)
            {
                MessageBox.Show(excp.Message.ToString());
            }
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

        private void resetbtn_Click(object sender, EventArgs e)
        {
            nametxtbox.Text = "";
            salarytxtbox.Text = "";
            designationtxtbox.Text = "";
        }

        private void showdatagrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if(e.RowIndex >= 0)
                {
                    showdatagrid.Rows[e.RowIndex].Selected = true;
                    if(showdatagrid.Columns[e.ColumnIndex].Name == "Delete")
                    {
                        String conn = @"Data Source=HP-FOLIO-1040; Initial Catalog=HRDB; Integrated Security=true;";
                        SqlConnection sqlconn = new SqlConnection(conn);

                        sqlconn.Open();
                        string id = showdatagrid.Rows[e.RowIndex].Cells["EmployeeSID"].Value.ToString();
                        string query = "delete from tblEmployeeDetails where EmployeeSID=" + id;
                        SqlDataAdapter adapter = new SqlDataAdapter(query, sqlconn);
                        DataSet ds = new DataSet();
                        adapter.Fill(ds);
                    }
                    else if(showdatagrid.Columns[e.ColumnIndex].Name == "Update")
                    {
                        id = int.Parse(showdatagrid.Rows[e.RowIndex].Cells[2].Value.ToString());
                        nametxtbox.Text = showdatagrid.Rows[e.RowIndex].Cells[3].Value.ToString();
                        salarytxtbox.Text = showdatagrid.Rows[e.RowIndex].Cells[4].Value.ToString();
                        designationtxtbox.Text = showdatagrid.Rows[e.RowIndex].Cells[5].Value.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {

            string name = nametxtbox.Text;
            int salary = int.Parse(salarytxtbox.Text);
            string designation = designationtxtbox.Text;
            

            String conn = @"Data Source=HP-FOLIO-1040; Initial Catalog=HRDB; Integrated Security=true;";
            SqlConnection sqlconn = new SqlConnection(conn);

            sqlconn.Open();

            string query = "update tblEmployeeDetails set EmployeeName='" + name + "', EmployeeSalary='" + salary + "', Designation='" + designation + "' where EmployeeSID='"+ id +"'";

            SqlCommand cmd = new SqlCommand(query, sqlconn);
            if(cmd.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("Record updated");
            }
            else
            {
                MessageBox.Show("Record is not updated");
            }

        }
    }
}
