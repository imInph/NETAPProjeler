using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Faktoriyel
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
            int sonuc = 1;
            listBox1.Items.Clear();
            for (int i = girilenSayi; i > 0; i--)
            {
                int tempI = i;
                sonuc *= i;
            }
            label2.Text = sonuc.ToString();
            listBox1.Items.Add($"{girilenSayi}! = {sonuc}");
        }
    }
}
