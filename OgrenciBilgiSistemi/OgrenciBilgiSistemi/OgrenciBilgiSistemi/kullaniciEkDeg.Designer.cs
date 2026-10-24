namespace OgrenciBilgiSistemi
{
    partial class kullaniciEkDeg
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.guncelleBtn = new System.Windows.Forms.Button();
            this.silBtn = new System.Windows.Forms.Button();
            this.kaydetBtn = new System.Windows.Forms.Button();
            this.listeleBtn = new System.Windows.Forms.Button();
            this.infoCopyBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.userPasswordEntry = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.usernameEntry = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.userIDEntry = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.accountTypeSelect = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.byTypeBtn = new System.Windows.Forms.Button();
            this.listSelectionBox = new System.Windows.Forms.ComboBox();
            this.backBtnUser = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.usersDBGrid = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.backBtnUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersDBGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.usersDBGrid);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.backBtnUser);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(988, 709);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.accountTypeSelect);
            this.panel2.Controls.Add(this.guncelleBtn);
            this.panel2.Controls.Add(this.silBtn);
            this.panel2.Controls.Add(this.kaydetBtn);
            this.panel2.Controls.Add(this.listeleBtn);
            this.panel2.Controls.Add(this.infoCopyBtn);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.userPasswordEntry);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.usernameEntry);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.userIDEntry);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(525, 312);
            this.panel2.TabIndex = 2;
            // 
            // guncelleBtn
            // 
            this.guncelleBtn.Location = new System.Drawing.Point(384, 160);
            this.guncelleBtn.Name = "guncelleBtn";
            this.guncelleBtn.Size = new System.Drawing.Size(137, 82);
            this.guncelleBtn.TabIndex = 14;
            this.guncelleBtn.Text = "Guncelle";
            this.guncelleBtn.UseVisualStyleBackColor = true;
            this.guncelleBtn.Click += new System.EventHandler(this.guncelleBtn_Click);
            // 
            // silBtn
            // 
            this.silBtn.Location = new System.Drawing.Point(241, 160);
            this.silBtn.Name = "silBtn";
            this.silBtn.Size = new System.Drawing.Size(137, 82);
            this.silBtn.TabIndex = 13;
            this.silBtn.Text = "Sil";
            this.silBtn.UseVisualStyleBackColor = true;
            this.silBtn.Click += new System.EventHandler(this.silBtn_Click);
            // 
            // kaydetBtn
            // 
            this.kaydetBtn.Location = new System.Drawing.Point(384, 72);
            this.kaydetBtn.Name = "kaydetBtn";
            this.kaydetBtn.Size = new System.Drawing.Size(137, 82);
            this.kaydetBtn.TabIndex = 12;
            this.kaydetBtn.Text = "Kaydet";
            this.kaydetBtn.UseVisualStyleBackColor = true;
            this.kaydetBtn.Click += new System.EventHandler(this.kaydetBtn_Click);
            // 
            // listeleBtn
            // 
            this.listeleBtn.Location = new System.Drawing.Point(241, 72);
            this.listeleBtn.Name = "listeleBtn";
            this.listeleBtn.Size = new System.Drawing.Size(137, 82);
            this.listeleBtn.TabIndex = 11;
            this.listeleBtn.Text = "Listele";
            this.listeleBtn.UseVisualStyleBackColor = true;
            this.listeleBtn.Click += new System.EventHandler(this.listeleBtn_Click);
            // 
            // infoCopyBtn
            // 
            this.infoCopyBtn.Location = new System.Drawing.Point(3, 259);
            this.infoCopyBtn.Name = "infoCopyBtn";
            this.infoCopyBtn.Size = new System.Drawing.Size(232, 48);
            this.infoCopyBtn.TabIndex = 10;
            this.infoCopyBtn.Text = "Kullanici Bilgilerini Kopyala";
            this.infoCopyBtn.UseVisualStyleBackColor = true;
            this.infoCopyBtn.Click += new System.EventHandler(this.infoCopyBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Kullanici Turu";
            // 
            // userPasswordEntry
            // 
            this.userPasswordEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userPasswordEntry.Location = new System.Drawing.Point(3, 151);
            this.userPasswordEntry.Name = "userPasswordEntry";
            this.userPasswordEntry.Size = new System.Drawing.Size(232, 38);
            this.userPasswordEntry.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Kullanici Sifresi";
            // 
            // usernameEntry
            // 
            this.usernameEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameEntry.Location = new System.Drawing.Point(3, 87);
            this.usernameEntry.Name = "usernameEntry";
            this.usernameEntry.Size = new System.Drawing.Size(232, 38);
            this.usernameEntry.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kullanici Adi";
            // 
            // userIDEntry
            // 
            this.userIDEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userIDEntry.Location = new System.Drawing.Point(3, 23);
            this.userIDEntry.Name = "userIDEntry";
            this.userIDEntry.Size = new System.Drawing.Size(232, 38);
            this.userIDEntry.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanici ID";
            // 
            // accountTypeSelect
            // 
            this.accountTypeSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountTypeSelect.FormattingEnabled = true;
            this.accountTypeSelect.Items.AddRange(new object[] {
            "Ogretmen",
            "Yonetici",
            "Ikiside"});
            this.accountTypeSelect.Location = new System.Drawing.Point(3, 215);
            this.accountTypeSelect.Name = "accountTypeSelect";
            this.accountTypeSelect.Size = new System.Drawing.Size(232, 39);
            this.accountTypeSelect.TabIndex = 15;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listSelectionBox);
            this.groupBox1.Controls.Add(this.byTypeBtn);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(533, 168);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(455, 147);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Secerek Listeleme";
            // 
            // byTypeBtn
            // 
            this.byTypeBtn.Location = new System.Drawing.Point(229, 44);
            this.byTypeBtn.Name = "byTypeBtn";
            this.byTypeBtn.Size = new System.Drawing.Size(220, 72);
            this.byTypeBtn.TabIndex = 15;
            this.byTypeBtn.Text = "Ture Gore\r\nListele";
            this.byTypeBtn.UseVisualStyleBackColor = true;
            this.byTypeBtn.Click += new System.EventHandler(this.byTypeBtn_Click);
            // 
            // listSelectionBox
            // 
            this.listSelectionBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listSelectionBox.FormattingEnabled = true;
            this.listSelectionBox.Items.AddRange(new object[] {
            "Ogretmen",
            "Yonetici",
            "Ikiside"});
            this.listSelectionBox.Location = new System.Drawing.Point(6, 60);
            this.listSelectionBox.Name = "listSelectionBox";
            this.listSelectionBox.Size = new System.Drawing.Size(217, 39);
            this.listSelectionBox.TabIndex = 16;
            // 
            // backBtnUser
            // 
            this.backBtnUser.Image = global::OgrenciBilgiSistemi.Properties.Resources.backarrow;
            this.backBtnUser.Location = new System.Drawing.Point(953, 0);
            this.backBtnUser.Name = "backBtnUser";
            this.backBtnUser.Size = new System.Drawing.Size(35, 35);
            this.backBtnUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.backBtnUser.TabIndex = 6;
            this.backBtnUser.TabStop = false;
            this.backBtnUser.Click += new System.EventHandler(this.backBtnUser_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(564, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(392, 146);
            this.label6.TabIndex = 7;
            this.label6.Text = "Kullanici\r\nEkle/Degistir";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // usersDBGrid
            // 
            this.usersDBGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.usersDBGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usersDBGrid.Location = new System.Drawing.Point(-3, 321);
            this.usersDBGrid.Name = "usersDBGrid";
            this.usersDBGrid.Size = new System.Drawing.Size(985, 385);
            this.usersDBGrid.TabIndex = 8;
            this.usersDBGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.usersDBGrid_CellContentClick);
            // 
            // kullaniciEkDeg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(1012, 733);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "kullaniciEkDeg";
            this.Text = "Kullanici Ekle/Degistir";
            this.Shown += new System.EventHandler(this.kullaniciEkDeg_Shown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.backBtnUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersDBGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button guncelleBtn;
        private System.Windows.Forms.Button silBtn;
        private System.Windows.Forms.Button kaydetBtn;
        private System.Windows.Forms.Button listeleBtn;
        private System.Windows.Forms.Button infoCopyBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox userPasswordEntry;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox usernameEntry;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox userIDEntry;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox accountTypeSelect;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox listSelectionBox;
        private System.Windows.Forms.Button byTypeBtn;
        private System.Windows.Forms.PictureBox backBtnUser;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.DataGridView usersDBGrid;
    }
}