using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BirIleBinArasinda15Rastgele
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Random rnd = new Random();
            int i = 0, rastgeleSayi;
            do
            {
                rastgeleSayi = rnd.Next(1, 1000);
                i++;
                listBox1.Items.Add(rastgeleSayi);
            } while (i < 15);
            label6.Text = $"Adet: {i}";
            label6.Visible = true;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            int hesapBes = 0, besAdet = 0;
            foreach (int a in listBox1.Items)
            {
                hesapBes = a % 5;
                if (hesapBes == 0)
                {
                    listBox2.Items.Add(a);
                    besAdet++;
                }
            }
            label5.Text = $"Adet: {besAdet}";
            label5.Visible = true;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            listBox3.Items.Clear();
            int hesapUc = 0, ucAdet = 0;
            foreach (int b in listBox1.Items)
            {
                hesapUc = b % 3;
                if (hesapUc == 0)
                {
                    listBox3.Items.Add(b);
                    ucAdet++;
                }
            }
            label4.Text = $"Adet: {ucAdet}";
            label4.Visible = true;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            listBox4.Items.Clear();
            int ortalamaHesap = 0, buyukAdet = 0;
            foreach (int c in listBox1.Items)
            {
                if (c > 437)
                {
                    listBox4.Items.Add(c);
                    ortalamaHesap += c;
                    buyukAdet++;
                }
            }
            label7.Text = $"Adet: {buyukAdet}, Ortalama: {ortalamaHesap / buyukAdet}";
            label7.Visible = true;
        }
    }
}
