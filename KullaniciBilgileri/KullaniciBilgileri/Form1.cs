using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KullaniciBilgileri
{
    public partial class Form1 : Form
    {
        public static int currentYear = DateTime.Now.Year, kullaniciYasi, kullaniciDogumYili;
        public static string kullaniciAdiSoyadi, kullaniciSehri;

        public Form1()
        {
            InitializeComponent();
            comboBox1.Items.Add("İstanbul");
            comboBox1.Items.Add("İzmir");
            comboBox1.Items.Add("Tekirdağ");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            kullaniciDogumYili = Convert.ToInt16(textBox3.Text);
            kullaniciAdiSoyadi = textBox1.Text;
            kullaniciSehri = comboBox1.Text;
            kullaniciYasi = currentYear - kullaniciDogumYili;
            listBox1.Items.Add($"{kullaniciAdiSoyadi}-{kullaniciSehri}-{kullaniciYasi.ToString()}");
            
        }
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            textBox3.Text = string.Empty;
            comboBox1.Text = string.Empty;
            listBox1.Items.Clear();
            listBox1.Items.Add("Ad Soyad-Şehir-Yaş");
        }
    }
}
