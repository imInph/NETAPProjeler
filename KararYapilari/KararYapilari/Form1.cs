using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KararYapilari
{
    public partial class Form1 : Form
    {
        public static int kullaniciYasi;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Girilen yaşa göre askerlik durumunu yazan program
            kullaniciYasi = Convert.ToInt32(textBox1.Text);
            if (kullaniciYasi < 150)
            {
                if (kullaniciYasi >= 20 && kullaniciYasi < 65)
                {
                    label3.Text = "Askere gidebilir";
                }
                else
                {
                    label3.Text = "Askere gidemez";
                }
            }
            else
            {
                label3.Text = "Yaş çok büyük";
            }
        }
    }
}
