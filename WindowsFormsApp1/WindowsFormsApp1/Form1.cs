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

namespace KayitSistemi
{
    public partial class Form1 : Form
    {
        public static string fileName;
        public Form1()
        {
            InitializeComponent();
            textBox4.Text += "Kayitlar.txt";
            fileName = textBox4.Text.Trim();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
        }

        private void SetTextBoxBottom(object sender, EventArgs e)
        {
            TextBox tb = sender as TextBox;
            if (tb.Multiline)
            {
                int paddingTop = tb.Height - tb.Font.Height - 2;
                tb.Padding = new Padding(0, paddingTop, 0, 0);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim().Length == 0 ||
                textBox2.Text.Trim().Length == 0 ||
                textBox3.Text.Trim().Length == 0)
            {
                if (textBox1.Text.Trim().Length == 0 ||
                    textBox2.Text.Trim().Length == 0 ||
                    textBox3.Text.Trim().Length == 0 &&
                    textBox3.Text.Trim().Length < 8)
                {
                    MessageBox.Show("Lütfen tüm alanları doldurunuz.\nŞifre en az 8 karakter olmalıdır.");
                }
                else
                {
                    MessageBox.Show("Lütfen tüm alanları doldurunuz.");
                }

            }
            else if (textBox1.Text.Trim().Length == 0 ||
                    textBox2.Text.Trim().Length == 0 ||
                    textBox3.Text.Trim().Length == 0 &&
                    textBox3.Text.Trim().Length < 8)
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz.\nŞifre en az 8 karakter olmalıdır.");
            }
            else if (textBox3.Text.Trim().Length < 8)
            {
                MessageBox.Show("Şifre en az 8 karakter olmalıdır.");
            }
            else
            {
                Program.adSoyad = textBox1.Text.Trim();
                Program.ePosta = textBox2.Text.Trim();
                Program.sifre = textBox3.Text.Trim();
                MessageBox.Show($"Bilgiler Kaydedildi\n\n" +
                    $"{Program.adSoyad}\n" +
                    $"{Program.ePosta}\n" +
                    $"{Program.sifre}");

                string directoryPath = Program.mainPath;
                if (!Directory.Exists(directoryPath))
                {
                    Directory.CreateDirectory(directoryPath);
                }
                string filePath = Path.Combine(directoryPath, textBox4.Text.Trim());

                try
                {
                    using (StreamWriter sw = File.AppendText(filePath))
                    {
                        sw.WriteLine($"{Program.adSoyad}\n{Program.ePosta}\n{Program.sifre}\n***");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Dosya kaydedilemedi: {ex.Message}");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                string directoryPath = Program.mainPath;
                if (!Directory.Exists(directoryPath))
                {
                    Directory.CreateDirectory(directoryPath);
                }
                string filePath = Path.Combine(directoryPath, textBox4.Text.Trim());

                try
                {
                    Program.adSoyad = "";
                    textBox1.Text = "";

                    Program.ePosta = "";
                    textBox2.Text = "";

                    Program.sifre = "";
                    textBox3.Text = "";
                    File.Delete(filePath);
                    File.Create(filePath).Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Dosya temizlenemedi: {ex.Message}");
                }
            }
            else
            {
                Program.adSoyad = "";
                textBox1.Text = "";

                Program.ePosta = "";
                textBox2.Text = "";

                Program.sifre = "";
                textBox3.Text = "";
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (!textBox4.Text.EndsWith(".txt"))
            {
                string currentText = textBox4.Text;
                if (currentText.Contains(".txt"))
                {
                    currentText = currentText.Replace(".txt", "");
                }
                textBox4.TextChanged -= textBox4_TextChanged;
                textBox4.Text = currentText + ".txt";
                textBox4.SelectionStart = textBox4.Text.Length;
                textBox4.TextChanged += textBox4_TextChanged;
            }
        }
    }
}
