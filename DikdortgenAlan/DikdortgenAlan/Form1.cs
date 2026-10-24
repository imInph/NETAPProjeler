using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DikdortgenAlan
{
    public partial class Form1 : Form
    {
        public static double kisaKenar, uzunKenar, cevre, alan;
        public static double sayiBir, sayiIki, sonuc;

        private void button5_Click(object sender, EventArgs e)
        {
            sayiBir = Convert.ToDouble(textBox4.Text);
            sayiIki = Convert.ToDouble(textBox3.Text);
            sonuc = sayiBir - sayiIki;
            label7.Text = $"Sonuç: {sonuc.ToString()}";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox4.Text = String.Empty;
            textBox3.Text = String.Empty;
            label7.Text = "Sonuç:";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sayiBir = Convert.ToDouble(textBox4.Text);
            sayiIki = Convert.ToDouble(textBox3.Text);
            sonuc = sayiBir * sayiIki;
            label7.Text = $"Sonuç: {sonuc.ToString()}";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            sayiBir = Convert.ToDouble(textBox4.Text);
            sayiIki = Convert.ToDouble(textBox3.Text);
            sonuc = sayiBir / sayiIki;
            label7.Text = $"Sonuç: {sonuc.ToString()}";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sayiBir = Convert.ToDouble(textBox4.Text);
            sayiIki = Convert.ToDouble(textBox3.Text);
            sonuc = sayiBir + sayiIki;
            label7.Text = $"Sonuç: {sonuc.ToString()}";
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        { // dikdörtgenin alanını ve cevresini 
            kisaKenar = Convert.ToDouble(textBox2.Text);
            uzunKenar = Convert.ToDouble(textBox1.Text);
            label3.Visible = true;
            label4.Visible = true;
            cevre = (kisaKenar + uzunKenar) * 2;
            alan = kisaKenar * uzunKenar;
            label3.Text = $"Çevre: {cevre.ToString()}";
            label4.Text = $"Alan: {alan.ToString()}";
        }
    }
}
