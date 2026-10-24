using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OgrenciGecmeDurumu
{
    public partial class Form1 : Form
    {
        public static double ogrenciNotu;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ogrenciNotu = Convert.ToDouble(textBox1.Text);
                if (ogrenciNotu >= 85 && ogrenciNotu <= 100)
                {
                    label2.Text = "Takdir";
                    int panelOneWidth = panel1.Size.Width;
                    int labelTwoWidth = label2.Size.Width;
                    label2.Location = new Point((panelOneWidth - labelTwoWidth) / 2, label2.Location.Y);
                }
                else if (ogrenciNotu >= 70 && ogrenciNotu <= 100)
                {
                    label2.Text = "Teşekkür";
                    int panelOneWidth = panel1.Size.Width;
                    int labelTwoWidth = label2.Size.Width;
                    label2.Location = new Point((panelOneWidth - labelTwoWidth) / 2, label2.Location.Y);
                }
                else if (ogrenciNotu >= 50 && ogrenciNotu <= 100)
                {
                    label2.Text = "Geçti";
                    int panelOneWidth = panel1.Size.Width;
                    int labelTwoWidth = label2.Size.Width;
                    label2.Location = new Point((panelOneWidth - labelTwoWidth) / 2, label2.Location.Y);
                }
                else if (ogrenciNotu < 50 && ogrenciNotu >= 0 && ogrenciNotu <= 100)
                {
                    label2.Text = "Kaldı";
                    int panelOneWidth = panel1.Size.Width;
                    int labelTwoWidth = label2.Size.Width;
                    label2.Location = new Point((panelOneWidth - labelTwoWidth) / 2, label2.Location.Y);
                }
                else
                {
                    label2.Text = "Not Geçersiz";
                    int panelOneWidth = panel1.Size.Width;
                    int labelTwoWidth = label2.Size.Width;
                    label2.Location = new Point((panelOneWidth - labelTwoWidth) / 2, label2.Location.Y);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Bir sayı giriniz.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu");
            }
        }
    }
}
