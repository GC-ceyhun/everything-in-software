using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timer_Ekleme_Ayarlama_Kullanım
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int i = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            timer2.Interval = 1000;
            timer2.Enabled = true;

            timer1.Interval = 1000;
            timer1.Enabled = true;
            pictureBox1.Image = ımageList1.Images[0];

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            i++;
            if (i==6)
            {
                i = 0;
            }
            pictureBox1.Image = ımageList1.Images[i];
        }
    }
}
