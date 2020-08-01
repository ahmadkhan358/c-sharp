using System;
using System.Windows.Forms;
using System.Reflection;
using System.Threading;
using System.Globalization;

namespace SatelliteAssemblies
{
    public partial class Form1 : Form
    {
        System.Resources.ResourceManager rm = new System.Resources.ResourceManager("SatelliteAssemblies.String", Assembly.GetExecutingAssembly());

        private void ChangeCulture(string sLangCode)
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(sLangCode);
            Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture(sLangCode);
            resultlbl.Text = rm.GetString("Result");
        }
        public Form1()
        {
            InitializeComponent();
            cmblanguage.Items.Add("English");
            cmblanguage.Items.Add("Arabic");
            ChangeCulture("en-US");
        }

        private void cmblanguage_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sLangCode;
            if(cmblanguage.SelectedIndex == 0)
            {
                sLangCode = "en-US";
                ChangeCulture(sLangCode);
            }
            else if(cmblanguage.SelectedIndex == 1)
            {
                sLangCode = "ar-sa";
                ChangeCulture(sLangCode);
            }
        }
    }
}
