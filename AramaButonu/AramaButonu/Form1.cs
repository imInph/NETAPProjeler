using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AramaButonu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text.Trim());
            textBox1.Text = string.Empty;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string musteriAdiAratma = textBox2.Text.Trim();
            bool musteriBulunduMu = false;
            foreach (string i in listBox1.Items)
            {
                if (musteriAdiAratma == i)
                {
                    musteriBulunduMu = true;
                }
            }
            if (musteriBulunduMu == true)
            {
                MessageBox.Show($"Müşteri bulundu: {musteriAdiAratma}");
            }
            else
            {
                MessageBox.Show($"{musteriAdiAratma} adında bir kullanıcı bulunamadı.");
            }
            textBox2.Text = string.Empty;
        }
    }
}
