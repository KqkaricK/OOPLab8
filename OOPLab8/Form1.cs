using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DarkUI.Forms;

namespace OOPLab8
{
    public partial class Form1 : DarkForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        DoubleArray A;
        private void darkButton2_Click(object sender, EventArgs e)
        {
            darkButton1.Visible = true;
            try
            {
                if ((darkTextBox1.Text == "") && (darkTextBox2.Text == "") && (darkTextBox3.Text == ""))
                { 
                    A = new DoubleArray();
                }
                else
                {
                    A = new DoubleArray(darkTextBox2.Text, (Convert.ToInt32(darkTextBox1.Text)), (Convert.ToInt32(darkTextBox3.Text)));
                }
            }
            catch { }
        }

        private void darkButton1_Click(object sender, EventArgs e)
        {
            darkGroupBox1.Visible = true;
            darkGroupBox3.Visible = true;
            darkLabel9.Visible = true;
            darkTextBox9.Visible = true;
            try
            {
                A.Display(dataGridView1);
                A.NName(darkTextBox9);
                A.PR(darkTextBox4, darkTextBox5);
                A.SUM(darkTextBox6, darkTextBox7);
            }
            catch { }
        }

        private void darkButton3_Click(object sender, EventArgs e)
        {
            try
            {
                A.Plus(Convert.ToInt32(darkTextBox8.Text));
            }
            catch { }
        }
    }
}
