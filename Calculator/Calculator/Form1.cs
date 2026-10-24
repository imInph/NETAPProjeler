using System.Data;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ActiveControl = textBox1;
            textBox1.KeyPress += textBox1_KeyPress;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (textBox1.Text.Contains(".") && btn.Text == ".")
            {

            }
            else
            {
                textBox1.Text += btn.Text;
            }
            textBox1.SelectionStart = textBox1.Text.Length;
            textBox1.Focus();
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            ActiveControl = (Control)sender;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string op = btn.Text;
            if (string.IsNullOrEmpty(textBox1.Text) && op == "-")
            {
                textBox1.Text += op;
                textBox1.SelectionStart = textBox1.Text.Length;
                textBox1.Focus();
                return;
            }
            if (string.IsNullOrEmpty(textBox1.Text) && (op == "." ||
                op == "%" || op == "/" || op == "*" || op == "+"))
            {
                return;
            }
            if (!textBox1.Text.EndsWith("+") &&
                     !textBox1.Text.EndsWith("/") &&
                     !textBox1.Text.EndsWith("*") &&
                     !textBox1.Text.EndsWith("%") &&
                     !textBox1.Text.EndsWith("."))
            {
                textBox1.Text += op;
                textBox1.SelectionStart = textBox1.Text.Length;
                textBox1.Focus();
            }
            else if (textBox1.Text.EndsWith("+") ||
                    textBox1.Text.EndsWith("/") ||
                    textBox1.Text.EndsWith("*") ||
                    textBox1.Text.EndsWith("%") ||
                    textBox1.Text.EndsWith(".") && op == "-")
            {
                textBox1.Text += op;
                textBox1.SelectionStart = textBox1.Text.Length;
                textBox1.Focus();
            }
            else
            {

            }

        }

        private void button17_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (!textBox1.Text.EndsWith("+") &&
                !textBox1.Text.EndsWith("/") &&
                !textBox1.Text.EndsWith("*") &&
                !textBox1.Text.EndsWith("-") &&
                !textBox1.Text.EndsWith("%") &&
                !textBox1.Text.EndsWith("."))
            {
                if (string.IsNullOrEmpty(textBox1.Text))
                {

                }
                else
                {
                    double textBoxAbsolute = Convert.ToDouble(textBox1.Text);
                    textBox1.Text = Convert.ToString(Math.Abs(textBoxAbsolute));
                    textBox1.SelectionStart = textBox1.Text.Length;
                }
            }
            else
            {

            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            try
            {
                string expr = textBox1.Text;
                if (!string.IsNullOrEmpty(expr))
                {
                    var result = new DataTable().Compute(expr, null);
                    textBox1.Text = result.ToString();
                    textBox1.SelectionStart = textBox1.Text.Length;
                }
            }
            catch
            {
                textBox1.Text = "Error";
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
