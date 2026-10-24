using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proje2
{
    public partial class Form1 : Form
    {
        public static bool listBoxGotData = false;
        public static string kullaniciEPostasi;
        public Form1()
        {
            InitializeComponent();
            this.BackColor = Color.Bisque;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!listBoxGotData)
            {
                label6.Text = "Henüz bir giriş yapılmamıştır";
                label6.Visible = true;
            }
            else
            {
                bool loginSuccess =
                    listBox1.Items.Contains($"Adı:{textBox1.Text.Trim()}") &&
                    listBox1.Items.Contains($"Soyadı:{textBox2.Text.Trim()}") &&
                    listBox1.Items.Contains($"Şifresi:{textBox3.Text.Trim()}") &&
                    listBox1.Items.Contains($"E-Postasi:{kullaniciEPostasi.Trim()}");

                if (loginSuccess)
                {
                    label6.Text = $"Hoşgeldiniz {textBox1.Text} {textBox2.Text}";
                    label6.Visible = true;
                }
                else
                {
                    label6.Text = "Giriş bilgileri yanlış.";
                    label6.Visible = true;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            kullaniciEPostasi = String.Concat(textBox4.Text, comboBox1.Text);
            if (String.IsNullOrEmpty(textBox1.Text) ||
                String.IsNullOrEmpty(textBox2.Text) ||
                String.IsNullOrEmpty(textBox3.Text) ||
                String.IsNullOrEmpty(textBox4.Text))
            {
                label6.Text = "Eksik bilgi girdiniz.";
                label6.Visible = true;
            }
            else 
            {
                if (comboBox1.Text == "Başka (Sonuna domain ekleyin)")
                {
                    int index = kullaniciEPostasi.IndexOf("Başka (Sonuna domain ekleyin)");
                    if (index >= 0)
                    {
                        kullaniciEPostasi = kullaniciEPostasi.Remove(index);
                    }
                }
                else if (comboBox1.Text == "Bir domain seciniz.")
                {
                    int index = kullaniciEPostasi.IndexOf("Bir domain seciniz.");
                    if (index >= 0)
                    {
                        kullaniciEPostasi = kullaniciEPostasi.Remove(index);
                    }
                }
                listBox1.Items.Add($"Adı:{textBox1.Text}");
                listBox1.Items.Add($"Soyadı:{textBox2.Text}");
                listBox1.Items.Add($"Şifresi:{textBox3.Text}");
                listBox1.Items.Add($"E-Postasi:{kullaniciEPostasi}");
                listBoxGotData = true; 
            }

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
