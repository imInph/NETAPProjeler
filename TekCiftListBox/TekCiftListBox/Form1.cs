using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TekCiftListBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int girilenSayi = Convert.ToInt32(textBox1.Text);
            int tekSayi = 0;
            int ciftSayi = 0;
            for (int i = 1; i <= girilenSayi; i++)
            {
                int sayiKontrol = i % 2;
                if (sayiKontrol == 0)
                {
                    listBox2.Items.Add(i.ToString());
                    ciftSayi++;
                }
                else
                {
                    listBox1.Items.Add(i.ToString());
                    tekSayi++;
                }
                label2.Text = $"Tek: {tekSayi}";
                label3.Text = $"Çift: {ciftSayi}";
            }
        }
    }
}
