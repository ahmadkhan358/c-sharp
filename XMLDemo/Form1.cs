using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace xmlDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            if(searchtxt.Text != null && searchtxt.Text.Length >= 3)
            {
                XmlDocument doc = new XmlDocument();
                doc.Load("data.xml");

                foreach(XmlNode node in doc.DocumentElement)
                {
                    string name = node.Attributes[0].InnerText.ToString();
                    if(name == searchtxt.Text)
                    {
                        foreach(XmlNode child in node.ChildNodes)
                        {
                            listView.Items.Add(child.InnerText);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Invalid Input");
                searchtxt.Text = string.Empty;
                searchtxt.Focus();
            }
        }
    }
}
