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
    public partial class ValidationForm : Form
    {
        public ValidationForm()
        {
            InitializeComponent();
        }

        private void nametxtbox_Validating(object sender, CancelEventArgs e)
        {
            checkTextBoxes(nametxtbox, e);
            checkTextBoxes(fnametxtbox, e);
            checkTextBoxes(emailtxtbox, e);
            checkTextBoxes(passtxtbox, e);
            checkTextBoxes(cnfrmpasstxtbox, e);

            if (string.IsNullOrEmpty(cnicmaskedtxtbox.Text))
            {
                e.Cancel = true;
                cnicmaskedtxtbox.Focus();
                errorProviderApp.SetError(cnicmaskedtxtbox, "This feild is required");
            }
            else
            {
                e.Cancel = false;
                errorProviderApp.SetError(cnicmaskedtxtbox, "");
            }
        }

        public void checkTextBoxes(TextBox t, CancelEventArgs e1)
        {
            if (string.IsNullOrEmpty(t.Text))
            {
                e1.Cancel = true;
                t.Focus();
                errorProviderApp.SetError(t, "This Feild is required");
            }
            else
            {
                e1.Cancel = false;
                errorProviderApp.SetError(t, "");
            }
        }
    }
}
