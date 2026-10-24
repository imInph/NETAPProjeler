using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KullaniciAdiSifre
{
    public partial class Form1 : Form
    {
        public static string kullaniciAdi = "admin", sifre = "123";
        public static int girisHakki = 3;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == kullaniciAdi && textBox2.Text == sifre)
            {
                panel1.Visible = false;
                label4.Visible = true;
                label4.Location = new Point(54, 112);
                return;
            }

            girisHakki--;

            label3.Visible = true;
            label3.Text = $"Kullanıcı adı veya şifre yanlış.\nGiriş hakkınız: {girisHakki}";

            if (girisHakki <= 0)
            {
                label3.Visible=true;
                label3.Text = "Giriş hakkınız bitti.";
                button1.Enabled = false;
            }
        }
    }
}
