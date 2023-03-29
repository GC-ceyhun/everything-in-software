using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Random_Örnek_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Color[] renkler = new Color[8] { Color.Red, Color.Yellow, Color.Black, Color.Blue,
                                             Color.White, Color.Purple, Color.Orange, Color.Brown };
            Random x = new Random();
            int dizi_elemanı = x.Next(0, 7);
            this.BackColor = renkler[dizi_elemanı];
        }
    }
}
