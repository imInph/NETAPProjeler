using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ForDongusuBirdenElliye
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= 50; i++)
            {
                comboBox1.Items.Add(i.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 20; i <= 100; i+=5)
            {
                listBox1.Items.Add(i.ToString());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int taban = Convert.ToInt32(textBox1.Text);
            int us = Convert.ToInt32(textBox2.Text);
            int sonuc = 1;
            for (int i = 0; i < us; i++)
            {
                sonuc *= taban;
            }
            label1.Text = sonuc.ToString();

        }
    }
}
