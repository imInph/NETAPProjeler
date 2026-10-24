using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/* cok satırlı 
 ornek olarak uzattım */
// tek satırlı

namespace Degiskenler
{
    public partial class Form1 : Form
    {
        public static string ad, soyad, sehir;
        public static string kullaniciAdi, kullaniciSoyadi;
        public static int sayi1, sayi2, toplam;

        private void button2_Click(object sender, EventArgs e)
        { // ad soyad yazdıran kod bloğu
            kullaniciAdi = textBox4.Text;
            kullaniciSoyadi = textBox3.Text;
            label6.Text = $"Adı: {kullaniciAdi}\nSoyadı: {kullaniciSoyadi}";
        }

        private void button3_Click(object sender, EventArgs e)
        { // iki sayinin toplamını bulan kod bloğu
            sayi1 = Convert.ToInt32(textBox1.Text);
            sayi2 = Convert.ToInt32(textBox2.Text);
            toplam = sayi1 + sayi2;
            label7.Text = toplam.ToString();
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // adınızı, soyadınızı ve sehir bilgilerinizi label1'e yazdırınız
            ad = "Miraç Arda";
            soyad = "Canbulat";
            sehir = "İstanbul";
            label1.Text = $"Adı: {ad},\nSoyadı: {soyad},\nŞehir: {sehir}";
        }
    }
}
