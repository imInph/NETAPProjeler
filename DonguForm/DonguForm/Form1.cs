using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DonguForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // girilen metni 10 kere listboxa yazan program
            for (int i = 0; i < 10; i++)
            {
                listBox1.Items.Add(textBox1.Text);
            }
            /* ekle butonu tıklandığında listbox2ye 1-100 arasındaki
             sayıları yazan program */
            for (int i = 1; i < 101; i++)
            {
                listBox2.Items.Add(i.ToString());
            }
        }
    }
}
