using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomTahmin
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        readonly int rastgeleDeger;
        int sayac = 0;
        public Form1()
        {
            InitializeComponent();
            rastgeleDeger = rnd.Next(1, 10);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sayac++;

            int kullaniciGirisi = Convert.ToInt32(textBox1.Text);

            if (kullaniciGirisi == rastgeleDeger)
            {
                label2.Visible = true;
                label2.Text = $"{sayac}. denemede tahmin\nettiniz.";
            }
            else
            {
                label2.Visible = true;
                label2.Text = "Bir daha deneyiniz.";
            }
        }
    }
}
