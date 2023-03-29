using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Radio_buton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(radioButton1.Checked==true)
            {
                label2.Text = "İLKÖĞRETİM";
            }
            else if (radioButton2.Checked == true)
            {
                label2.Text = "ORTAÖĞRETİM";
            }
            else if (radioButton3.Checked == true)
            {
                label2.Text = "LİSANS";
            }
            else if (radioButton4.Checked == true)
            {
                label2.Text = "YÜKSEK LİSASNS";
            }
        }

    }
}
