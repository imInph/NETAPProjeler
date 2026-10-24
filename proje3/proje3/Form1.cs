using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proje3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("9");
            comboBox1.Items.Add("10");
            comboBox1.Items.Add("11");
            comboBox1.Items.Add("12");
            comboBox2.Items.Add("BTT");
            comboBox2.Items.Add("BTU");
            comboBox2.Items.Add("PT");
            comboBox2.Items.Add("NTP");
            comboBox2.Items.Add("RK");
            comboBox3.Items.Add("Geçti");
            comboBox3.Items.Add("Kaldı");
            comboBox3.Items.Add("Devamsız");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add($"No: {textBox1.Text}, Ad Soyad: {textBox2.Text}");
            listBox1.Items.Add($"1. Not: {textBox3.Text}");
            listBox1.Items.Add($"2. Not: {textBox4.Text}");
            listBox1.Items.Add($"Sınıfı: {comboBox1.Text}, Ders: {comboBox2.Text}");
            listBox1.Items.Add($"Durumu: {comboBox3.Text}");
            listBox1.Items.Add("");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
    }
}
