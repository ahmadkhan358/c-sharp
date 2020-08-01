using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee_Information
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void resetbtn_Click(object sender, EventArgs e)
        {
            resulttxtbox.Text = "";
            empnomaskedtxtbox.Text = "";
            nametxtbox.Text = "";
            addresstxtbox.Text = "";
            citycombobox.Text = "";
            provincelistbox.ClearSelected();
            if(maleradio.Checked == true)
            {
                maleradio.Checked = false;
            }

            if(femaleradio.Checked == true)
            {
                femaleradio.Checked = false;
            }
            for(int i=0; i<hobbieschecklist.Items.Count; i++)
            {
                hobbieschecklist.SetItemChecked(i, false);
            }
        }

        private void submitbtn_Click(object sender, EventArgs e)
        {
            string result = "";

            string gender = "";

            if (maleradio.Checked == true) gender = "Male";
            else gender = "Female";

            result += "Employee # : " + empnomaskedtxtbox.Text + Environment.NewLine;
            result += "Name : " + nametxtbox.Text + Environment.NewLine;
            result += "Address : " + addresstxtbox.Text + Environment.NewLine;
            result += "City : " + citycombobox.Text + Environment.NewLine;
            result += "Province : " + provincelistbox.SelectedItem.ToString() + Environment.NewLine;
            result += "DOB : " + dobdatetimepicker.Value.ToString() + Environment.NewLine;
            result += "Age : " + agenumericupdown.Value.ToString() + Environment.NewLine;
            result += "Gender : " + gender + Environment.NewLine;
            result += "Hobbies : ";
            foreach(string i in hobbieschecklist.CheckedItems)
            {
                result += i + Environment.NewLine;
            }


            resulttxtbox.Text = result;
        }
    }
}
