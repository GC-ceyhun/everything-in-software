using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Combobox_Örnek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("AUDI"); comboBox1.Items.Add("SUZIKI");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "AUDI") 
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("A1");
                comboBox2.Items.Add("A2");
                comboBox2.Items.Add("A3");
            }

            else if (comboBox1.Text == "SUZIKI") 
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("ALTO");
                comboBox2.Items.Add("BALENO");
                comboBox2.Items.Add("LIANA");
            }   
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.Text == "A1")
            {
                comboBox3.Items.Clear();
                comboBox3.Items.Add("1.4 TFSI");
                comboBox3.Items.Add("1.6 TDI");
            }

            else if (comboBox2.Text == "A2")
            {
                comboBox3.Items.Clear();
                comboBox3.Items.Add("1.6 FSI");
            }

            else if (comboBox2.Text == "A3")
            {   comboBox3.Items.Clear();
                string[] a3_versiyonlar={ "CABRIO","HATCBAK","SPORTBACK", "SEDAN" };
                comboBox3.Items.AddRange(a3_versiyonlar);
            }

            else if (comboBox2.Text == "ALTO")
            {
                comboBox3.Items.Clear();
                comboBox3.Items.Add("0.8 GL");
                comboBox3.Items.Add("1.0");
                comboBox3.Items.Add("1.1");
            }

            else if (comboBox2.Text == "BALENO")
            {
                comboBox3.Items.Clear();
                comboBox3.Items.Add("1.2 ");
                comboBox3.Items.Add("1.6 ");
            }

            else if (comboBox2.Text == "LIANA")
            {
                comboBox3.Items.Clear();
                comboBox3.Items.Add("1.6 GLX");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("MARKA : " + comboBox1.Text + "  -  MODEL : " + comboBox2.Text + "  -  VERSİYON :" + comboBox3.Text);
        }
    }
}
