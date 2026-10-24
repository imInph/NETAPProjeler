using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AkılliEvSistemi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Kontrol için kod bloğu

            // Lamba
            if (checkBox1.Checked == true)
            {
                label4.Text = "Açık";
            }
            else
            {
                label4.Text = "Kapalı";
            }

            // Kombi
            if (checkBox2.Checked == true)
            {
                label5.Text = "Açık";
            }
            else
            {
                label5.Text = "Kapalı";
            }

            // Petek
            if (checkBox3.Checked == true)
            {
                label6.Text = "Açık";
            }
            else
            {
                label6.Text = "Kapalı";
            }
        }
    }
}
