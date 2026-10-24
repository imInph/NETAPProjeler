namespace TestingStuff
{
    public partial class Form1 : Form
    {
        public static bool pageChanged = false;
        public Form1()
        {
            InitializeComponent();
            this.BackColor = Color.AliceBlue;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "Hello World!";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text += "World Hello";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (pageChanged == false)
            {
                this.Size = new Size(1000, 550);
                this.BackColor = Color.Bisque;
                pageChanged = true;
                button3.Text = "Go Back";
                button3.Location = new Point(12, 77);
                button1.Visible = false;
                button2.Visible = false;
                label1.Text = "Page 2";
            }
            else
            {
                this.Size = new Size(710, 550);
                this.BackColor = Color.AliceBlue;
                pageChanged = false;
                button3.Text = "Switch Page";
                button3.Location = new Point(274, 77);
                button1.Visible = true;
                button2.Visible = true;
                label1.Text = "Text";
            }
        }
    }
}
    