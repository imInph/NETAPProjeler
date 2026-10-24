using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KullanicininGirdigiSayiyaKadarToplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int kullaniciGirisi = Convert.ToInt32(textBox1.Text), sayac = 0, toplam = 0;
            while (sayac <= kullaniciGirisi)
            {
                toplam += sayac;
                sayac++;
            }
            label1.Text = toplam.ToString();
        }
    }
}
