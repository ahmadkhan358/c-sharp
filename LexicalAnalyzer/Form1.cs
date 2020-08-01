using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LexicalAnalyzer
{
    public partial class LA : Form
    {
        public LA()
        {
            InitializeComponent();
        }

        private void runbtn_Click(object sender, EventArgs e)
        {
            //string input = inputPreprocessing(inputtxtbox.Text);
            string input = inputtxtbox.Text;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '\n')
                {
                    stacktxtbox.Text += "";
                }
                else
                {
                    stacktxtbox.Text += input[i].ToString();
                }
            }


            Scanner scan = new Scanner(input);
            scan.lexAnalyzerInAction();
            List<LexToken> lexTokens = scan.getLexTokens();
           
            foreach (LexToken lt in lexTokens)
            {
                lextokenlist.Items.Add(new ListViewItem(new string[] { lt.Lexeme, lt.Token }));
            }
        }

        private string inputPreprocessing(string i)
        {
            StringReader sr = new StringReader(i);
            string input = "";
            string line;
         
  
            while ((line = sr.ReadLine()) != null)
            {
                input += line;
            }
            

            return input;
        }

     
    }
}
