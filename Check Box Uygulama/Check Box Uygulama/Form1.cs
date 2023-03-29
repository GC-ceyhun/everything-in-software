using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Check_Box_Uygulama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
                label1.Text = "Sigarnın Dumanını Yel Alır, Parasını El Alır!!";
            else if (checkBox1.Checked == false)
                label1.Text = "Aferin!";
        }
    }
}
