using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_Örneği_ve_ListBox_Kullanımı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string tcno="", adsoyad="", cinsiyet="", diller="", mezuniyet="", uzmanlik="";
            tcno = textBox1.Text;
            adsoyad = textBox2.Text;
            if (radioButton5.Checked == true)
                { cinsiyet = radioButton5.Text; }
            else if (radioButton6.Checked == true)
                { cinsiyet = radioButton6.Text; }

            if(radioButton1.Checked==true)
                { mezuniyet = radioButton1.Text; }
            else if(radioButton2.Checked==true)
                { mezuniyet = radioButton2.Text; }
            else if (radioButton3.Checked == true)
                { mezuniyet = radioButton3.Text; }
            else if (radioButton4.Checked == true)
                { mezuniyet = radioButton4.Text; }


            if (checkBox1.Checked == true)
                diller = diller + "," + checkBox1.Text;
            if (checkBox2.Checked == true)
                diller = diller + "," + checkBox2.Text;
            if (checkBox3.Checked == true)
                diller = diller + "," + checkBox3.Text;
            if (checkBox4.Checked == true)
                diller = diller + "," + checkBox4.Text;
            if (checkBox5.Checked == true)
                diller = diller + "," + checkBox5.Text;
            if (checkBox6.Checked == true)
                diller = diller + "," + checkBox6.Text;
            diller = diller.Substring(1);

            if (checkBox7.Checked == true)
                uzmanlik = uzmanlik + "," + checkBox7.Text;
            if (checkBox8.Checked == true)
                uzmanlik = uzmanlik + "," + checkBox8.Text;
            if (checkBox9.Checked == true)
                uzmanlik = uzmanlik + "," + checkBox9.Text;
            if (checkBox10.Checked == true)
                uzmanlik = uzmanlik + "," + checkBox10.Text;
            if (checkBox11.Checked == true)
                uzmanlik = uzmanlik + "," + checkBox11.Text;
            if (checkBox12.Checked == true)
                uzmanlik = uzmanlik + "," + checkBox12.Text;
            uzmanlik = uzmanlik.Substring(1);

            listBox1.Items.Add("TC NO:" + tcno + "  |  " + "ADI SOYADI:" + adsoyad + "  |  " + "CİNSİYETİ:" + cinsiyet + "  |  " + "DİLLER:" + diller + "  |  " + "UZMANLIK:" + uzmanlik);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.SelectedItem);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }
    }
}
