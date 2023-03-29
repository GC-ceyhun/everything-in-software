using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Random_Uygulama_2__sayı_tahmini_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int sayi = 0, tahmin_sayisi = 0, puan = 1000;

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Enabled = false;
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            try                     // eğer sayı dışında bir karakter girilirse try komutu programın hata vermesini engeller.
            {

            
                int tahmin;
                tahmin_sayisi++;

                if (tahmin_sayisi <= 10)
                {
                    tahmin = int.Parse(textBox1.Text);
                    label6.Text = tahmin_sayisi.ToString();

                    if (sayi < tahmin)
                    {
                        label5.Text = "Tahmininizi azaltın";
                        puan = puan - 100;
                        label7.Text = puan.ToString();
                    }
                    else if (tahmin < sayi)
                    {
                        label5.Text = "Tahmininizi arttırın";
                        puan = puan - 100;
                        label7.Text = puan.ToString();
                    }
                    else
                    {
                        label5.Text = "Tebrikler! " + label6.Text + " denemede buldup," + label7.Text + " puan kazandınız..";
                        button2.Enabled = true;
                        button1.Enabled = false;
                        tahmin_sayisi = 0;
                        puan = 1000;
                    }
                textBox1.Text = "";
            }

                else
                {
                    textBox1.Enabled = false;
                    MessageBox.Show("Tahmin hakkınız kalmadı.Oyun Kapatılacak");
                    this.Close();
                }
            }
            catch (Exception)        // yanlış girilen karakter olduğunu catch komutu içindki kullandığımız messagebox ile kullanıcıya ikaz olarak bildiririz.
            {
                MessageBox.Show("Hatalı Giriş!");
                label5.Text= "Lütfen Sayı Dışında Karakter Girişi Yapmayınız!";
                tahmin_sayisi = tahmin_sayisi-1;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = false;
            Random r = new Random();
            sayi = r.Next(100);
            label8.Text = sayi.ToString();
            label5.Text = "";
            label6.Text = "0";
            label7.Text = "1000";
        }

    }
}
