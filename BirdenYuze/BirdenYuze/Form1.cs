using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BirdenYuze
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= 100; i++)
            { 
                int besKontrol = i % 5;
                int ucKontrol = i % 3;
                if (besKontrol == 0)
                {
                    listBox1.Items.Add(i.ToString());
                }
                if (ucKontrol == 0)
                {
                    listBox2.Items.Add(i.ToString());
                }
            }
        }
    }
}
