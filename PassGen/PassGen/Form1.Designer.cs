namespace PassGen
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button1 = new Button();
            textBox1 = new TextBox();
            button2 = new Button();
            trackBar1 = new TrackBar();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            label17 = new Label();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(12, 152);
            button1.Name = "button1";
            button1.Size = new Size(150, 75);
            button1.TabIndex = 0;
            button1.Text = "Generate";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(12, 61);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(306, 85);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(168, 152);
            button2.Name = "button2";
            button2.Size = new Size(150, 75);
            button2.TabIndex = 2;
            button2.Text = "Copy";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(12, 233);
            trackBar1.Maximum = 16;
            trackBar1.Minimum = 1;
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(306, 45);
            trackBar1.TabIndex = 3;
            trackBar1.Value = 1;
            trackBar1.ValueChanged += trackBar1_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 9);
            label1.Name = "label1";
            label1.Size = new Size(272, 40);
            label1.TabIndex = 4;
            label1.Text = "Password Generator";
            label1.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._20088;
            pictureBox1.Location = new Point(276, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(40, 40);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 263);
            label2.Name = "label2";
            label2.Size = new Size(13, 15);
            label2.TabIndex = 6;
            label2.Text = "1";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(38, 263);
            label3.Name = "label3";
            label3.Size = new Size(13, 15);
            label3.TabIndex = 7;
            label3.Text = "2";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(75, 263);
            label4.Name = "label4";
            label4.Size = new Size(13, 15);
            label4.TabIndex = 9;
            label4.Text = "4";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(56, 263);
            label5.Name = "label5";
            label5.Size = new Size(13, 15);
            label5.TabIndex = 8;
            label5.Text = "3";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(149, 263);
            label6.Name = "label6";
            label6.Size = new Size(13, 15);
            label6.TabIndex = 13;
            label6.Text = "8";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(130, 263);
            label7.Name = "label7";
            label7.Size = new Size(13, 15);
            label7.TabIndex = 12;
            label7.Text = "7";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(112, 263);
            label8.Name = "label8";
            label8.Size = new Size(13, 15);
            label8.TabIndex = 11;
            label8.Text = "6";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(93, 263);
            label9.Name = "label9";
            label9.Size = new Size(13, 15);
            label9.TabIndex = 10;
            label9.Text = "5";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(295, 263);
            label10.Name = "label10";
            label10.Size = new Size(19, 15);
            label10.TabIndex = 21;
            label10.Text = "16";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(276, 263);
            label11.Name = "label11";
            label11.Size = new Size(19, 15);
            label11.TabIndex = 20;
            label11.Text = "15";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(258, 263);
            label12.Name = "label12";
            label12.Size = new Size(19, 15);
            label12.TabIndex = 19;
            label12.Text = "14";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(239, 263);
            label13.Name = "label13";
            label13.Size = new Size(19, 15);
            label13.TabIndex = 18;
            label13.Text = "13";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(221, 263);
            label14.Name = "label14";
            label14.Size = new Size(19, 15);
            label14.TabIndex = 17;
            label14.Text = "12";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(202, 263);
            label15.Name = "label15";
            label15.Size = new Size(19, 15);
            label15.TabIndex = 16;
            label15.Text = "11";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(184, 263);
            label16.Name = "label16";
            label16.Size = new Size(19, 15);
            label16.TabIndex = 15;
            label16.Text = "10";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(169, 263);
            label17.Name = "label17";
            label17.Size = new Size(13, 15);
            label17.TabIndex = 14;
            label17.Text = "9";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Beige;
            ClientSize = new Size(330, 292);
            Controls.Add(label10);
            Controls.Add(label11);
            Controls.Add(label12);
            Controls.Add(label13);
            Controls.Add(label14);
            Controls.Add(label15);
            Controls.Add(label16);
            Controls.Add(label17);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(trackBar1);
            Controls.Add(button2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            Text = "Password Generator";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private Button button2;
        private TrackBar trackBar1;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label17;
    }
}
