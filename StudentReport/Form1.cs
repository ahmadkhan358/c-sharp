using System;
using System.Windows.Forms;

namespace Student_Report
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String items = "";
            if (checkBox1.Checked) items += "\nPencil";

            if (checkBox2.Checked) items += "\nSharpener";

            if (checkBox3.Checked) items += "\nPen";

            if (checkBox1.Checked == false && checkBox2.Checked == false && checkBox3.Checked == false) items = "Nothing";

            MessageBox.Show("You have bought : " + items);
        }

        private void button2_Click(object sender, EventArgs e)
        { 
            String gender = "";

            if(radioButton1.Checked == true)
            {
                gender = "Male";
            }
            else
            {
                gender = "Female";
            }

            MessageBox.Show(gender.ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure you want to exit", "Confirm", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Application.Exit();
            }
        }
    }
}
