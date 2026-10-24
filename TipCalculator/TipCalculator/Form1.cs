using System.CodeDom;

namespace TipCalculator
{
    public partial class Form1 : Form
    {
        private TipEntry tipEntry;
        public Form1()
        {
            InitializeComponent();
        }

        public void TipEntrySwitch()
        {
            this.Hide();
            tipEntry.Show();
            tipEntry.Location = new Point(this.Location.X, this.Location.Y);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tipEntry = new TipEntry();
            Variables.formOneTextBoxOne = textBox1.Text;
            Variables.billAmount = Convert.ToDouble(textBox1.Text);
            tipEntry.label2.Text = $"${Variables.billAmount:F2}";
            int panelTwoWidth = tipEntry.panel2.Size.Width;
            int labelTwoWidth = tipEntry.label2.Size.Width;
            tipEntry.label2.Location = new Point((panelTwoWidth - labelTwoWidth) / 2, tipEntry.label2.Location.Y);
            TipEntrySwitch();
        }
    }
}
