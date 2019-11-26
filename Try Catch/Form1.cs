using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Try_Catch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string s = "3";
            string pi = "3.14159265";
            int i = int.Parse(s);
            double d = double.Parse(pi);
            richTextBox1.AppendText(i.ToString() + "\n");
            richTextBox1.AppendText(d.ToString() + "\n");
            string st = "three";
            try
            {
                int it = int.Parse(st);
            }
            catch
            {
               MessageBox.Show(st + " is not an integer");
            }
            string s2 = "3.2";
            try
            {
                int i2 = int.Parse(s2);
            }
            catch
            {
                MessageBox.Show(s2 + " is not an integer");
                int i2 = 0;
            }
            string s3 = "pi";
            try
            {
                double d2 = double.Parse(s3);
            }
            catch
            {
                double d2 = 0;
            }

        }

        private void RichTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
    }
