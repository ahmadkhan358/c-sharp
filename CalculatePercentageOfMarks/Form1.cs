using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void checkDigit(object s, KeyPressEventArgs kpea)
        {
            char ch = kpea.KeyChar;

            if (!(char.IsDigit(ch) || kpea.KeyChar == '.') && ch != 8)
            {
                kpea.Handled = true;
            }
        }

        public float calculatePercentage(float total, float obtained)
        {
            return (obtained * 100) / total;
        }

        public string divisionObtained(float obtained)
        {
            string division = "4th";

            if(obtained >= 80)
            {
                division = "1st";
            }
            else if(obtained < 80 && obtained >= 60)
            {
                division = "2nd";
            }
            else if(obtained < 60 && obtained >= 40)
            {
                division = "3rd";
            }

            return division;
        }

        private void mathtxtbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            checkDigit(sender, e);
        }

        private void sciencetxtbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            checkDigit(sender, e);
        }

        private void englishtxtbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            checkDigit(sender, e);
        }

        private void computertxtbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            checkDigit(sender, e);
        }

        private void urdutxtbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            checkDigit(sender, e);
        }

        private void okbtn_Click(object sender, EventArgs e)
        {
            float totalforeachsubject = 100;
            float passingcriteria = 40;

            float math = float.Parse(mathtxtbox.Text);
            float science = float.Parse(sciencetxtbox.Text);
            float english = float.Parse(englishtxtbox.Text);
            float computer = float.Parse(computertxtbox.Text);
            float urdu = float.Parse(urdutxtbox.Text);

            float totalmarks = totalforeachsubject * 5;
            float obtainedmarks = math + science + english + computer + urdu;

            string result = "Pass";

            float percentage = calculatePercentage(totalmarks, obtainedmarks);

            if (math < passingcriteria || science < passingcriteria || english < passingcriteria
                || computer < passingcriteria || urdu < passingcriteria)
            {
                result = "Fail";
            }


            totaltxtbox.Text = totalmarks.ToString();

            obtainedtxtbox.Text = obtainedmarks.ToString();

            percentagetxtbox.Text = percentage.ToString();

            divisiontxtbox.Text = divisionObtained(percentage);

            resulttxtbox.Text = result;

        }

        private void newbtn_Click(object sender, EventArgs e)
        {
            nametxtbox.Text = "";
            rollnotxtbox.Text = "";
            mathtxtbox.Text = "";
            sciencetxtbox.Text = "";
            englishtxtbox.Text = "";
            computertxtbox.Text = "";
            urdutxtbox.Text = "";
            totaltxtbox.Text = "";
            obtainedtxtbox.Text = "";
            percentagetxtbox.Text = "";
            divisiontxtbox.Text = "";
            resulttxtbox.Text = "";
        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                Application.Exit();
            }
        }
    }
}
