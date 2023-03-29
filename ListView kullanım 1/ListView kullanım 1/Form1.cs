using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListView_kullanım_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listView1.Columns.Add("TC KİMLİK NO", 150);                                 // listview sutun oluşturma.
            listView1.Columns.Add("ADI SOYADI", 200);
            listView1.Columns.Add("YAŞ", 50);
            listView1.Columns.Add("MEZUNİYETİ", 150);
            listView1.Columns.Add("CİNSİYET", 125);
            listView1.Columns.Add("DOĞUM YERİ", 125);
            listView1.Columns.Add("TELEFON NO", 130);

            string[] mezuniyet = { "İLK ÖĞRETİM", "LİSE", "LİSANS", "YÜKSEK LİSANS" };  // string türünde dizi oluşturma.
            comboBox1.Items.AddRange(mezuniyet);                                        // combobox üzerinde oluşturulan dizi elemanlarını görme.  
            kayitsayisiyaz();
        }

        private void kayitsayisiyaz()
        {
            int kayitsayisi = listView1.Items.Count;                                    // metot oluşturma. int türünde değişken oluşturuldu ve listview'deki kayıt sayısını oluşturulan değişkende saklandı. 
            label8.Text = Convert.ToString(kayitsayisi);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string tc = "", adsoyad = "", yas = "", mezuniyet = "", cinsiyet = "", dogumyeri = "", telno = "";

            tc = textBox1.Text;         adsoyad = textBox2.Text;                        // textbox aracına girilen verilerin aktarılacağı değişkenler belirlendi.
            yas = textBox3.Text;        mezuniyet = comboBox1.Text;
            dogumyeri = textBox4.Text;  telno = textBox5.Text;

            if (radioButton1.Checked==true)                                             // radiobutton aracı ile yapılan seçimin aktarılacağı değişken belirlendi. 
               cinsiyet = radioButton1.Text;          
            else if (radioButton2.Checked==true)
               cinsiyet = radioButton2.Text;   

            string[] bilgiler = { tc, adsoyad, yas, mezuniyet, cinsiyet, dogumyeri, telno };

            bool aranankayitkonrolu = false;                                            // daha önce aynı bilgilerde bir kayıt yapılıp yapılmadığını kontrol etmek için bir bool türünde değişklen oluşturuldu.

            for (int i = 0; i < listView1.Items.Count; i++)                             // lisyview'deki kayıtlar kadar kontorl edecek for döngüsü oluşturuldu.
            {
                if (listView1.Items[i].SubItems[0].Text==textBox1.Text)                 // eğer listview'deki kayırlar içinde kayıt bulunursa değişken 'fulse' iken 'true' olarak değişecek
                {
                    aranankayitkonrolu = true;
                    MessageBox.Show(textBox1.Text + "TC Kimlik No Kayıtlarda Mevcuttur.");
                }
            }

            if (aranankayitkonrolu==false)
            {
                ListViewItem lst = new ListViewItem(bilgiler);
                if (tc != "" && adsoyad != "" && yas != "" && mezuniyet != "" && cinsiyet != "" && dogumyeri != "" && telno != "")
                {
                    listView1.Items.Add(lst);
                }
                else MessageBox.Show("Kayıt bilgilerinde eksiklik var!!");
            }

            kayitsayisiyaz();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int secilensayisi = listView1.CheckedItems.Count;                           // kaç adet kaydın seşildiğini bilgisi değişkene aktarılır. 'listView1.CheckedItems.Count' komutu, listview menüsünde seşili kayıtların sayısını belirlememizi sağlar.
            foreach (ListViewItem secilikayitbilgisi in listView1.CheckedItems)         // listview1 öğesinin seçili öğeleri kadar döngü çalışacak. Döngü her çalıştığında 'secilikayitbilgisi' isimli 'ListViewItem' öğesinde kayıt bilgilerini tutacak.                 
            {
                secilikayitbilgisi.Remove();                                            // kaçtane kayıt seçilmişse, seçilen tüm kayıtların silinmesini sağladık.
            }

            MessageBox.Show(secilensayisi.ToString() + " Adet Kayıt Silindi.");
            kayitsayisiyaz();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int secilensayisi = listView1.SelectedItems.Count;                           // kaç adet kaydın seşildiğini bilgisi değişkene aktarılır. 'listView1.CheckedItems.Count' komutu, listview menüsünde seşili kayıtların sayısını belirlememizi sağlar.
            foreach (ListViewItem secilikayitbilgisi in listView1.SelectedItems)         // listview1 öğesinin seçili öğeleri kadar döngü çalışacak. Döngü her çalıştığında 'secilikayitbilgisi' isimli 'ListViewItem' öğesinde kayıt bilgilerini tutacak.                 
            {
                secilikayitbilgisi.Remove();                                            // kaçtane kayıt seçilmişse, seçilen tüm kayıtların silinmesini sağladık.
            }

            MessageBox.Show(secilensayisi.ToString() + " Adet Kayıt Silindi.");
            kayitsayisiyaz();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            kayitsayisiyaz();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            bool aranankayitkontrolu = false;
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                if (listView1.Items[i].SubItems[0].Text == textBox1.Text)
                {
                    aranankayitkontrolu = true;
                    textBox2.Text = listView1.Items[i].SubItems[1].Text;
                    textBox3.Text = listView1.Items[i].SubItems[2].Text;
                    comboBox1.Text = listView1.Items[i].SubItems[3].Text;
                    if (listView1.Items[i].SubItems[4].Text=="BAY")
                    {
                        radioButton1.Checked = true;
                    }
                    else if (listView1.Items[i].SubItems[4].Text == "BAYAN")
                    {
                        radioButton2.Checked = true;
                    }
                    textBox4.Text = listView1.Items[i].SubItems[5].Text;
                    textBox5.Text = listView1.Items[i].SubItems[6].Text;

                    textBox2.Enabled = false;
                    textBox3.Enabled = false;
                    textBox4.Enabled = false;
                    textBox5.Enabled = false;
                    comboBox1.Enabled = false;
                    groupBox1.Enabled = false;
                }
            }

            if(aranankayitkontrolu==false)
            {
                MessageBox.Show(textBox1.Text + "TC Kimlik Numaralı Kayıt Bulunamadı!");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox2.Enabled = true;
            textBox3.Enabled = true;
            textBox4.Enabled = true;
            textBox5.Enabled = true;
            comboBox1.Enabled = true;
            groupBox1.Enabled = true;

            textBox1.Text = ("");
            textBox2.Text = ("");
            textBox3.Text = ("");
            textBox4.Text = ("");
            textBox5.Text = ("");
            comboBox1.Text = ("");
            radioButton1.Checked = false ;
            radioButton2.Checked = false;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
