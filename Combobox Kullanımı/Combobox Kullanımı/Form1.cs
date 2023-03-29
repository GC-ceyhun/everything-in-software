using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Combobox_Kullanımı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] markalar = { "AUDI", "BMW", "MERCEDES", "OPEL" }; // dizi kullanımı
            comboBox1.Items.AddRange(markalar);

            //comboBox1.Items.Add("AUDI"); comboBox1.Items.Add("BMW");  //tek tek tanımlama
            //comboBox1.Items.Add("MERCEDES"); comboBox1.Items.Add("OPEL"); 
        }
    }
}
