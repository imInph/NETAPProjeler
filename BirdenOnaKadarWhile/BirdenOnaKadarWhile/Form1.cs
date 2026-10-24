using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BirdenOnaKadarWhile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = 0;
            int y = 20;
            while (x < 10)
            {
                listBox1.Items.Add(x);
                x++;
            }
            while (y > 0)
            {
                if (y%2 == 1)
                {
                    listBox2.Items.Add(y);
                }
                y--;
            }
        }
    }
}
