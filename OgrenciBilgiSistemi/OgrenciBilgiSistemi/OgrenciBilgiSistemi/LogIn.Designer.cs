namespace OgrenciBilgiSistemi
{
    partial class LogIn
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.logInBtn = new System.Windows.Forms.Button();
            this.passwordEntry = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.usernameEntry = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.passShowToggleBtn = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.passShowToggleBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(984, 705);
            this.panel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(220, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(543, 146);
            this.label3.TabIndex = 1;
            this.label3.Text = "Bilisim Ogrencileri\r\nBilgi Sistemi";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.passShowToggleBtn);
            this.panel2.Controls.Add(this.logInBtn);
            this.panel2.Controls.Add(this.passwordEntry);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.usernameEntry);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(390, 273);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(236, 158);
            this.panel2.TabIndex = 0;
            // 
            // logInBtn
            // 
            this.logInBtn.Location = new System.Drawing.Point(7, 123);
            this.logInBtn.Name = "logInBtn";
            this.logInBtn.Size = new System.Drawing.Size(189, 26);
            this.logInBtn.TabIndex = 4;
            this.logInBtn.Text = "Giris Yap";
            this.logInBtn.UseVisualStyleBackColor = true;
            this.logInBtn.Click += new System.EventHandler(this.logInBtn_Click);
            // 
            // passwordEntry
            // 
            this.passwordEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordEntry.Location = new System.Drawing.Point(7, 82);
            this.passwordEntry.Name = "passwordEntry";
            this.passwordEntry.Size = new System.Drawing.Size(189, 35);
            this.passwordEntry.TabIndex = 3;
            this.passwordEntry.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Sifre";
            // 
            // usernameEntry
            // 
            this.usernameEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameEntry.Location = new System.Drawing.Point(7, 23);
            this.usernameEntry.Name = "usernameEntry";
            this.usernameEntry.Size = new System.Drawing.Size(189, 35);
            this.usernameEntry.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanici Adi";
            // 
            // passShowToggleBtn
            // 
            this.passShowToggleBtn.Image = global::OgrenciBilgiSistemi.Properties.Resources.eyeopenpng;
            this.passShowToggleBtn.Location = new System.Drawing.Point(198, 89);
            this.passShowToggleBtn.Name = "passShowToggleBtn";
            this.passShowToggleBtn.Size = new System.Drawing.Size(25, 20);
            this.passShowToggleBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.passShowToggleBtn.TabIndex = 2;
            this.passShowToggleBtn.TabStop = false;
            this.passShowToggleBtn.Click += new System.EventHandler(this.passShowToggleBtn_Click);
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "LogIn";
            this.Text = "Giris Sayfasi";
            this.Shown += new System.EventHandler(this.LogIn_Shown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.passShowToggleBtn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox passwordEntry;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox usernameEntry;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button logInBtn;
        private System.Windows.Forms.PictureBox passShowToggleBtn;
    }
}