namespace OgrenciBilgiSistemi
{
    partial class MainPage
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
            this.logOutBtn = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ogrenciNot = new System.Windows.Forms.Button();
            this.kullaniciEkDeg = new System.Windows.Forms.Button();
            this.ogrenciEkSil = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logOutBtn)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.logOutBtn);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(984, 705);
            this.panel1.TabIndex = 0;
            // 
            // logOutBtn
            // 
            this.logOutBtn.Image = global::OgrenciBilgiSistemi.Properties.Resources.logout;
            this.logOutBtn.Location = new System.Drawing.Point(3, 3);
            this.logOutBtn.Name = "logOutBtn";
            this.logOutBtn.Size = new System.Drawing.Size(35, 35);
            this.logOutBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logOutBtn.TabIndex = 4;
            this.logOutBtn.TabStop = false;
            this.logOutBtn.Click += new System.EventHandler(this.logOutBtn_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ogrenciNot);
            this.panel2.Controls.Add(this.kullaniciEkDeg);
            this.panel2.Controls.Add(this.ogrenciEkSil);
            this.panel2.Location = new System.Drawing.Point(286, 261);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(411, 183);
            this.panel2.TabIndex = 3;
            // 
            // ogrenciNot
            // 
            this.ogrenciNot.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ogrenciNot.Location = new System.Drawing.Point(106, 95);
            this.ogrenciNot.Name = "ogrenciNot";
            this.ogrenciNot.Size = new System.Drawing.Size(199, 85);
            this.ogrenciNot.TabIndex = 2;
            this.ogrenciNot.Text = "Ogrenci Not Girisi";
            this.ogrenciNot.UseVisualStyleBackColor = true;
            this.ogrenciNot.Click += new System.EventHandler(this.ogrenciNot_Click);
            // 
            // kullaniciEkDeg
            // 
            this.kullaniciEkDeg.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kullaniciEkDeg.Location = new System.Drawing.Point(208, 3);
            this.kullaniciEkDeg.Name = "kullaniciEkDeg";
            this.kullaniciEkDeg.Size = new System.Drawing.Size(199, 85);
            this.kullaniciEkDeg.TabIndex = 1;
            this.kullaniciEkDeg.Text = "Kullanici Ekle/Sil";
            this.kullaniciEkDeg.UseVisualStyleBackColor = true;
            this.kullaniciEkDeg.Click += new System.EventHandler(this.kullaniciEkDeg_Click);
            // 
            // ogrenciEkSil
            // 
            this.ogrenciEkSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ogrenciEkSil.Location = new System.Drawing.Point(3, 3);
            this.ogrenciEkSil.Name = "ogrenciEkSil";
            this.ogrenciEkSil.Size = new System.Drawing.Size(199, 85);
            this.ogrenciEkSil.TabIndex = 0;
            this.ogrenciEkSil.Text = "Ogrenci\r\nEkle/Sil";
            this.ogrenciEkSil.UseVisualStyleBackColor = true;
            this.ogrenciEkSil.Click += new System.EventHandler(this.ogrenciEkSil_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(249, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(486, 108);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ana Sayfa";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "MainPage";
            this.Text = "Ana Sayfa";
            this.Load += new System.EventHandler(this.MainPage_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logOutBtn)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button ogrenciNot;
        private System.Windows.Forms.Button kullaniciEkDeg;
        private System.Windows.Forms.Button ogrenciEkSil;
        private System.Windows.Forms.PictureBox logOutBtn;
    }
}