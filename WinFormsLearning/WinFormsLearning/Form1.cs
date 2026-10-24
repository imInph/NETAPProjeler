namespace WinFormsLearning
{
    public partial class Form1 : Form
    {
        Control ActiveControl;
        public Form1()
        {
            InitializeComponent();
            ActiveControl = textBox1;
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            if (ActiveControl != null)
            {
                Button btn = (Button)sender;
                ActiveControl.Focus();
                SendKeys.Send(btn.Text == "+" ? "{+}" : btn.Text);
            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            ActiveControl = (Control)sender;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        int progress = 0;

        private void button13_Click(object sender, EventArgs e)
        {
            progress = 0;
            progressBar1.Value = 0;
            progressBar1.Visible = true;
            timer1.Start();
            textBox1.Text = "Hello, World!";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progress += 4;
            progressBar1.Value = progressBar1.Maximum * progress / 100;
            if (progress >= 100)
            {
                timer1.Stop();
                progressBar1.Visible = false;
            }
        }
    }
}
