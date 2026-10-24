using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SwitchCaseForms
{
    public partial class Form1 : Form
    {
        public static int birinciSayi, ikinciSayi;
        public static double sonuc;
        public static string seciliButon;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked) seciliButon = "toplama";
            if (radioButton2.Checked) seciliButon = "cikarma";
            if (radioButton3.Checked) seciliButon = "carpma";
            if (radioButton4.Checked) seciliButon = "bolme";

            birinciSayi = Convert.ToInt32(textBox1.Text);
            ikinciSayi = Convert.ToInt32(textBox2.Text);

            switch (seciliButon)
            {
                case "toplama":
                    sonuc = birinciSayi + ikinciSayi;
                    MessageBox.Show(sonuc.ToString());
                    break;
                case "cikarma":
                    sonuc = birinciSayi - ikinciSayi;
                    MessageBox.Show(sonuc.ToString());
                    break;
                case "carpma":
                    sonuc = birinciSayi * ikinciSayi;
                    MessageBox.Show(sonuc.ToString());
                    break;
                case "bolme":
                    sonuc = birinciSayi / ikinciSayi;
                    MessageBox.Show(sonuc.ToString());
                    break;
                default:
                    MessageBox.Show("bunun olmaması lazım :(");
                    break;
            }
        }
    }
}
