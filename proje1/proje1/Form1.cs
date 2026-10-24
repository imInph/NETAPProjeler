using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proje1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Deneme_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            textBox1.Text = btn.Text;
            textBox1.SelectionStart = textBox1.Text.Length;
            textBox1.Focus();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Length == 0 || 
                textBox3.Text.Length == 0 ||
                textBox4.Text.Length == 0 ||
                textBox3.Text.Length < 8)
            {
                if (textBox3.Text.Length < 8)
                {
                    MessageBox.Show("Şifreniz 8 karakterden az olamaz ve eksik bilgi girdiniz.");
                }
                else
                {
                    MessageBox.Show("Eksik bilgi girdiniz.");
                }
            }
            else
            {
                string adSoyad = textBox2.Text;
                string sifre = textBox3.Text;
                string sehir = textBox4.Text;
                MessageBox.Show($"Bilgiler Kaydedildi\n\n" +
                    $"{adSoyad}\n" +
                    $"{sifre}\n" +
                    $"{sehir}\n" +
                    $"{textBox1.Text}");
                File.WriteAllText("C:\\Users\\ogrenci\\Desktop\\Miraç Arda\\Ders\\Netap\\proje1\\proje1\\KayitBilgileri.txt", adSoyad + "\n" + sifre + "\n" + sehir);
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello, World");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
