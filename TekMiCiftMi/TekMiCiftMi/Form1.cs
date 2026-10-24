using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TekMiCiftMi
{
    public partial class Form1 : Form
    {
        public static int girilenSayi, modSonucu;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                girilenSayi = Convert.ToInt32(textBox1.Text);
                modSonucu = girilenSayi % 2;
                if (modSonucu == 1)
                {
                    listBox1.Items.Add(girilenSayi.ToString());
                }
                else
                {
                    listBox2.Items.Add(girilenSayi.ToString());
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Girdiginiz sayı ondalıklı veya geçersiz.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu");
            }
        }
    }
}
