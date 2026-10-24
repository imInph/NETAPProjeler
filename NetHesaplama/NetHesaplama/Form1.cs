using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetHesaplama
{
    public partial class Form1 : Form
    {
        public static double turkceDogru, turkceYanlis, matematikDogru, matematikYanlis, turkceNet, matematikNet;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            turkceDogru = Convert.ToDouble(textBox1.Text);
            turkceYanlis = Convert.ToDouble(textBox3.Text);
            matematikDogru = Convert.ToDouble(textBox2.Text);
            matematikYanlis = Convert.ToDouble(textBox4.Text);
            turkceNet = (turkceDogru - (turkceYanlis / 4));
            matematikNet = (matematikDogru - (matematikYanlis / 4));
            textBox5.Text = turkceNet.ToString();
            textBox6.Text = matematikNet.ToString();
        }
    }
}
