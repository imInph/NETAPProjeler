using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public static double firstNumEntry, secondNumEntry, calculationOutput;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Convert.ToDouble(textBox1.Text);

                if (textBox1.Text.Contains(","))
                {
                    textBox1.TextChanged -= textBox1_TextChanged;
                    textBox1.Text = textBox1.Text.Replace(",", ".");
                    textBox1.SelectionStart = textBox1.Text.Length;
                    textBox1.TextChanged += textBox1_TextChanged;
                }
                else
                {
                    firstNumEntry = Convert.ToDouble(textBox1.Text);
                }
            }
            catch (FormatException)
            {
                if (textBox1.Text != String.Empty)
                {
                    textBox1.TextChanged -= textBox1_TextChanged;
                    textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
                    textBox1.TextChanged += textBox1_TextChanged;
                }
                else
                {
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Convert.ToDouble(textBox2.Text);

                if (textBox2.Text.Contains(","))
                {
                    textBox2.TextChanged -= textBox2_TextChanged;
                    textBox2.Text = textBox2.Text.Replace(",", ".");
                    textBox2.SelectionStart = textBox2.Text.Length;
                    textBox2.TextChanged += textBox2_TextChanged;
                }
                else
                {
                    secondNumEntry = Convert.ToDouble(textBox2.Text);
                }
            }
            catch (FormatException)
            {
                if (textBox2.Text != String.Empty)
                {
                    textBox2.TextChanged -= textBox2_TextChanged;
                    textBox2.Text = textBox2.Text.Substring(0, textBox2.Text.Length - 1);
                    textBox2.TextChanged += textBox2_TextChanged;
                }
                else
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            firstNumEntry = Convert.ToDouble(textBox1.Text);
            secondNumEntry = Convert.ToDouble(textBox2.Text);
            if (radioButton1.Checked == false && radioButton2.Checked == false)
            {
                MessageBox.Show("Please select an option first.");
            }
            else if (radioButton1.Checked)
            {
                calculationOutput = firstNumEntry + secondNumEntry;
                label3.Text = $"Result: {calculationOutput.ToString()}";
            }
            else if (radioButton2.Checked)
            {
                calculationOutput = firstNumEntry * secondNumEntry;
                label3.Text = $"Result: {calculationOutput.ToString()}";
            }
        }
    }
}
