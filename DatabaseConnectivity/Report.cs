using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Database_Connectivity
{
    public partial class Report : Form
    {
        public Report()
        {
            InitializeComponent();
        }

        private void Report_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'HRDBDataSet1.tblEmployeeDetails' table. You can move, or remove it, as needed.
            this.tblEmployeeDetailsTableAdapter.Fill(this.HRDBDataSet1.tblEmployeeDetails);

            this.reportViewer1.RefreshReport();
        }

        private void filterbtn_Click(object sender, EventArgs e)
        {
            try
            {
                this.tblEmployeeDetailsTableAdapter.FillBy(this.HRDBDataSet1.tblEmployeeDetails, ((int)(System.Convert.ChangeType(sorttxtbox.Text, typeof(int)))));
                this.reportViewer1.RefreshReport();
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void refreshbtn_Click(object sender, EventArgs e)
        {
            try
            {
                this.tblEmployeeDetailsTableAdapter.Fill(this.HRDBDataSet1.tblEmployeeDetails);

                this.reportViewer1.RefreshReport();
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
    }
}
