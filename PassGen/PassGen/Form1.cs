namespace PassGen
{
    public partial class Form1 : Form
    {

        public static int trackBarValue;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBox1.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Variables.generatedPassword = "";
            textBox1.Text = "";
            Methods.RandomStrings();
            textBox1.Text = Variables.generatedPassword;
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            trackBarValue = trackBar1.Value;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }
    }
}
