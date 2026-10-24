using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Formats.Tar;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TipCalculator
{
    public partial class TipEntry : Form
    {
        private Form1 formOne;
        private CustomTipPage customTipForm;
        private ThankYouPage thankYouForm;
        public TipEntry()
        {
            InitializeComponent();
        }

        public void ThankYouSwitch()
        {
            this.Hide();
            thankYouForm.Show();
            thankYouForm.Location = new Point(this.Location.X, this.Location.Y);
        }

        public void FormOneSwitch()
        {
            this.Hide();
            formOne.Show();
            formOne.Location = new Point(this.Location.X, this.Location.Y);
        }

        public void CustomTipSwitch()
        {
            this.Hide();
            customTipForm.Show();
            customTipForm.Location = new Point(this.Location.X, this.Location.Y);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            formOne = new Form1();
            FormOneSwitch();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            thankYouForm = new ThankYouPage();
            Variables.totalAmount = Variables.billAmount + ((Variables.billAmount / 100) * 15);
            thankYouForm.label2.Text = $"${Variables.totalAmount:F2}";
            int panelTwoWidth = thankYouForm.panel2.Size.Width;
            int labelTwoWidth = thankYouForm.label2.Size.Width;
            thankYouForm.label2.Location = new Point((panelTwoWidth - labelTwoWidth) / 2, thankYouForm.label2.Location.Y);
            ThankYouSwitch();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            thankYouForm = new ThankYouPage();
            Variables.totalAmount = Variables.billAmount + ((Variables.billAmount / 100) * 20);
            thankYouForm.label2.Text = $"${Variables.totalAmount:F2}";
            int panelTwoWidth = thankYouForm.panel2.Size.Width;
            int labelTwoWidth = thankYouForm.label2.Size.Width;
            thankYouForm.label2.Location = new Point((panelTwoWidth - labelTwoWidth) / 2, thankYouForm.label2.Location.Y);
            ThankYouSwitch();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            thankYouForm = new ThankYouPage();
            Variables.totalAmount = Variables.billAmount + ((Variables.billAmount / 100) * 25);
            thankYouForm.label2.Text = $"${Variables.totalAmount:F2}";
            int panelTwoWidth = thankYouForm.panel2.Size.Width;
            int labelTwoWidth = thankYouForm.label2.Size.Width;
            thankYouForm.label2.Location = new Point((panelTwoWidth - labelTwoWidth) / 2, thankYouForm.label2.Location.Y);
            ThankYouSwitch();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.Visible = false;
            button6.Visible = true;
            button7.Visible = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            customTipForm = new CustomTipPage();
            Variables.percentageOrNot = true;
            CustomTipSwitch();
            customTipForm.label3.Text = $"${Variables.billAmount:F2}";
            int panelThreeWidth = customTipForm.panel1.Size.Width;
            int labelOneWidth = customTipForm.label3.Size.Width;
            customTipForm.label3.Location = new Point((panelThreeWidth - labelOneWidth) / 2, customTipForm.label3.Location.Y);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            customTipForm = new CustomTipPage();
            Variables.percentageOrNot = false;
            CustomTipSwitch();
            customTipForm.label3.Text = $"${Variables.billAmount:F2}";
            int panelThreeWidth = customTipForm.panel1.Size.Width;
            int labelOneWidth = customTipForm.label3.Size.Width;
            customTipForm.label3.Location = new Point((panelThreeWidth - labelOneWidth) / 2, customTipForm.label3.Location.Y);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            thankYouForm = new ThankYouPage();
            Variables.totalAmount = Variables.billAmount;
            thankYouForm.label2.Text = $"${Variables.totalAmount:F2}";
            int panelTwoWidth = thankYouForm.panel2.Size.Width;
            int labelTwoWidth = thankYouForm.label2.Size.Width;
            thankYouForm.label2.Location = new Point((panelTwoWidth - labelTwoWidth) / 2, thankYouForm.label2.Location.Y);
            ThankYouSwitch();
        }
    }
}
