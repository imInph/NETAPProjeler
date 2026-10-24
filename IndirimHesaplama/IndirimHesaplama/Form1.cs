using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IndirimHesaplama
{
    public partial class Form1 : Form
    {
        public static double girilenSayi;
        public static double indirimliFiyat;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            girilenSayi = Convert.ToDouble(textBox1.Text);
            indirimliFiyat = girilenSayi-((girilenSayi / 100) * 10);
            label2.Text = $"İndirimli Fiyat: {indirimliFiyat.ToString()}";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            girilenSayi = Convert.ToDouble(textBox1.Text);
            indirimliFiyat = girilenSayi - ((girilenSayi / 100) * 25);
            label2.Text = $"İndirimli Fiyat: {indirimliFiyat.ToString()}";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            girilenSayi = Convert.ToDouble(textBox1.Text);
            indirimliFiyat = girilenSayi - ((girilenSayi / 100) * 50);
            label2.Text = $"İndirimli Fiyat: {indirimliFiyat.ToString()}";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            girilenSayi = Convert.ToDouble(textBox1.Text);
            indirimliFiyat = girilenSayi - ((girilenSayi / 100) * 75);
            label2.Text = $"İndirimli Fiyat: {indirimliFiyat.ToString()}";
        }
    }
}
