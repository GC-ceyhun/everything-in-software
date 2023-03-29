using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Random_Kullanımı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int rastgele_sayi1 = rnd.Next(100);
            int rastgele_sayi2 = rnd.Next(100);
            int rastgele_sayi3 = rnd.Next(100);
            int rastgele_sayi4 = rnd.Next(100);
            int rastgele_sayi5 = rnd.Next(100);
            int rastgele_sayi6 = rnd.Next(100);
            int rastgele_sayi7 = rnd.Next(100);
            label1.Text = Convert.ToString(rastgele_sayi1);
            label2.Text = Convert.ToString(rastgele_sayi2);
            label3.Text = Convert.ToString(rastgele_sayi3);
            label4.Text = Convert.ToString(rastgele_sayi4);
            label5.Text = Convert.ToString(rastgele_sayi5);
            label6.Text = Convert.ToString(rastgele_sayi6);
        }

    }
}
