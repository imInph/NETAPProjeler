using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EllidenYuzeKadarUcVeBes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayac = 50, toplam = 0, adet = 0, hesapUc = 0, hesapBes = 0, ortalama = 0;
            do
            {
                hesapUc = sayac % 3;
                hesapBes = sayac % 5;
                if (hesapUc == 0 && hesapBes == 0)
                {
                    listBox1.Items.Add(sayac.ToString());
                    toplam += sayac;
                    adet++;
                }
                sayac++;
            } while (sayac <= 150);
            ortalama = toplam / adet;
            label1.Text = $"Toplam: {toplam}";
            label2.Text = $"Adet: {adet}";
            label3.Text = $"Ortalama: {ortalama}";
        }
    }
}
