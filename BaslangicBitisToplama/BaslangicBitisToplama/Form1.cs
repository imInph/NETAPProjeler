using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaslangicBitisToplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /* Başlangıç ve bitiş değeri kullanıcı tarafından girilen,
             * sayıların toplamını bulan programı yazınız. */
            int baslangicDegeri = Convert.ToInt32(textBox1.Text);
            int bitisDegeri = Convert.ToInt32(textBox2.Text);
            int sonuc = 0;
            listBox1.Items.Clear();
            for (int i = baslangicDegeri; i <= bitisDegeri; i++)
            {
                string listBoxOutput = $"{sonuc}+{i}";
                sonuc += i;
                listBox1 .Items.Add($"{listBoxOutput} Sonuç: {sonuc}");
            }
            label3.Text = $"Sonuc: {sonuc.ToString()}";
        }
    }
}
