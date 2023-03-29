using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Constant_Uygulama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            const double KDV = 0.18, OTV = 0.45;
            double FIYAT = 0, kdv_tutari = 0, otv_tutari = 0, toplam=0;

            FIYAT = Convert.ToDouble(textBox1.Text);
            kdv_tutari = FIYAT * KDV;
            otv_tutari = FIYAT * OTV;
            toplam = FIYAT + kdv_tutari + otv_tutari;

            textBox2.Text = Convert.ToString(kdv_tutari);
            textBox3.Text = Convert.ToString(otv_tutari);
            textBox4.Text = Convert.ToString(toplam);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }
    }
}
