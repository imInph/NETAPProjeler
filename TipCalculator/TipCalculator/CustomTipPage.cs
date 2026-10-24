using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TipCalculator
{
    public partial class CustomTipPage : Form
    {
        private TipEntry tipEntry;
        private Form1 formOne;
        private ThankYouPage thankYouForm;
        public CustomTipPage()
        {
            InitializeComponent();
        }

        public void ThankYouSwitch()
        {
            this.Hide();
            thankYouForm.Show();
            thankYouForm.Location = new Point(this.Location.X, this.Location.Y);
        }

        public void IfItsPercentage()
        {
            try
            {
                Convert.ToDouble(textBox1.Text);
                if (textBox1.Text.EndsWith(","))
                {
                    textBox1.TextChanged -= textBox1_TextChanged;
                    textBox1.Text = textBox1.Text.Replace(",", ".");
                    textBox1.SelectionStart = textBox1.Text.Length;
                    textBox1.TextChanged += textBox1_TextChanged;
                }
                else
                {

                }
            }
            catch (FormatException)
            {
                textBox1.TextChanged -= textBox1_TextChanged;
                if (textBox1.Text.Length == 0)
                {
                    textBox1.Text = "";
                }
                else
                {
                    textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
                    textBox1.SelectionStart = textBox1.Text.Length;
                }
                textBox1.TextChanged += textBox1_TextChanged;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            if (textBox1.Text != "")
            {
                Variables.totalAmount = Variables.billAmount + ((Variables.billAmount / 100) * Convert.ToDouble(textBox1.Text));
                label3.Text = $"${Variables.totalAmount:F2}";
            }
            else
            {

            }
        }

        public void IfItsAmount()
        {
            try
            {
                Convert.ToDouble(textBox1.Text);
                if (textBox1.Text.EndsWith(","))
                {
                    textBox1.TextChanged -= textBox1_TextChanged;
                    textBox1.Text = textBox1.Text.Replace(",", ".");
                    textBox1.SelectionStart = textBox1.Text.Length;
                    textBox1.TextChanged += textBox1_TextChanged;
                }
                else
                {

                }
            }
            catch (FormatException)
            {
                textBox1.TextChanged -= textBox1_TextChanged;
                if (textBox1.Text.Length == 0)
                {
                    textBox1.Text = "";
                }
                else
                {
                    textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
                    textBox1.SelectionStart = textBox1.Text.Length;
                }
                textBox1.TextChanged += textBox1_TextChanged;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            if (textBox1.Text != "")
            {
                Variables.totalAmount = Variables.billAmount + Convert.ToDouble(textBox1.Text);
                label3.Text = $"${Variables.totalAmount:F2}";
            }
            else
            {

            }
        }

        public void TipEntrySwitch()
        {
            this.Hide();
            tipEntry.Show();
            tipEntry.Location = new Point(this.Location.X, this.Location.Y);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (Variables.percentageOrNot == true)
            {
                IfItsPercentage();
                if (textBox1.Text == "")
                {
                    label3.Text = $"${Variables.billAmount:F2}";
                    int panelThreeWidth = panel1.Size.Width;
                    int labelOneWidth = label3.Size.Width;
                    label3.Location = new Point((panelThreeWidth - labelOneWidth) / 2, label3.Location.Y);
                }
                else
                {
                    int panelThreeWidth = panel1.Size.Width;
                    int labelOneWidth = label3.Size.Width;
                    label3.Location = new Point((panelThreeWidth - labelOneWidth) / 2, label3.Location.Y);
                }
            }
            else
            {
                IfItsAmount();
                if (textBox1.Text == "")
                {
                    label3.Text = $"${Variables.billAmount:F2}";
                    int panelThreeWidth = panel1.Size.Width;
                    int labelOneWidth = label3.Size.Width;
                    label3.Location = new Point((panelThreeWidth - labelOneWidth) / 2, label3.Location.Y);
                }
                else
                {
                    int panelThreeWidth = panel1.Size.Width;
                    int labelOneWidth = label3.Size.Width;
                    label3.Location = new Point((panelThreeWidth - labelOneWidth) / 2, label3.Location.Y);
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            tipEntry = new TipEntry();
            formOne = new Form1();
            Variables.billAmount = Convert.ToDouble(Variables.formOneTextBoxOne);
            tipEntry.label2.Text = $"${Variables.billAmount:F2}";
            int panelTwoWidth = tipEntry.panel2.Size.Width;
            int labelTwoWidth = tipEntry.label2.Size.Width;
            tipEntry.label2.Location = new Point((panelTwoWidth - labelTwoWidth) / 2, tipEntry.label2.Location.Y);
            TipEntrySwitch();
            tipEntry.button4.Visible = true;
            tipEntry.button6.Visible = false;
            tipEntry.button7.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            thankYouForm = new ThankYouPage();
            thankYouForm.label2.Text = $"${Variables.totalAmount:F2}";
            int panelTwoWidth = thankYouForm.panel2.Size.Width;
            int labelTwoWidth = thankYouForm.label2.Size.Width;
            thankYouForm.label2.Location = new Point((panelTwoWidth - labelTwoWidth) / 2, thankYouForm.label2.Location.Y);
            ThankYouSwitch();
        }
    }
}
