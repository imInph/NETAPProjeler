namespace OgrenciBilgiSistemi
{
    partial class OgrenciEkleSil
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.classListEntry = new System.Windows.Forms.TextBox();
            this.gradeListEntry = new System.Windows.Forms.TextBox();
            this.byClassBtn = new System.Windows.Forms.Button();
            this.byGradeBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.guncelleBtn = new System.Windows.Forms.Button();
            this.silBtn = new System.Windows.Forms.Button();
            this.kaydetBtn = new System.Windows.Forms.Button();
            this.listeleBtn = new System.Windows.Forms.Button();
            this.infoCopyBtn = new System.Windows.Forms.Button();
            this.studentClassEntry = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.studentGradeEntry = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.studentNameEntry = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.studentNoEntry = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.studentIDEntry = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ogrenciDBGrid = new System.Windows.Forms.DataGridView();
            this.backBtnInfo = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciDBGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backBtnInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.backBtnInfo);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.ogrenciDBGrid);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(988, 709);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.classListEntry);
            this.groupBox1.Controls.Add(this.gradeListEntry);
            this.groupBox1.Controls.Add(this.byClassBtn);
            this.groupBox1.Controls.Add(this.byGradeBtn);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(530, 232);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(455, 147);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Secerek Listeleme";
            // 
            // classListEntry
            // 
            this.classListEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classListEntry.Location = new System.Drawing.Point(6, 95);
            this.classListEntry.Name = "classListEntry";
            this.classListEntry.Size = new System.Drawing.Size(219, 38);
            this.classListEntry.TabIndex = 17;
            // 
            // gradeListEntry
            // 
            this.gradeListEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gradeListEntry.Location = new System.Drawing.Point(6, 34);
            this.gradeListEntry.Name = "gradeListEntry";
            this.gradeListEntry.Size = new System.Drawing.Size(219, 38);
            this.gradeListEntry.TabIndex = 15;
            // 
            // byClassBtn
            // 
            this.byClassBtn.Location = new System.Drawing.Point(229, 75);
            this.byClassBtn.Name = "byClassBtn";
            this.byClassBtn.Size = new System.Drawing.Size(220, 71);
            this.byClassBtn.TabIndex = 16;
            this.byClassBtn.Text = "Subeye Gore Listele";
            this.byClassBtn.UseVisualStyleBackColor = true;
            this.byClassBtn.Click += new System.EventHandler(this.byClassBtn_Click);
            // 
            // byGradeBtn
            // 
            this.byGradeBtn.Location = new System.Drawing.Point(229, 3);
            this.byGradeBtn.Name = "byGradeBtn";
            this.byGradeBtn.Size = new System.Drawing.Size(220, 72);
            this.byGradeBtn.TabIndex = 15;
            this.byGradeBtn.Text = "Sinifa Gore\r\nListele";
            this.byGradeBtn.UseVisualStyleBackColor = true;
            this.byGradeBtn.Click += new System.EventHandler(this.byGradeBtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(571, 1);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(380, 216);
            this.label6.TabIndex = 3;
            this.label6.Text = "Ogrenci\r\nBilgi\r\n";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.guncelleBtn);
            this.panel2.Controls.Add(this.silBtn);
            this.panel2.Controls.Add(this.kaydetBtn);
            this.panel2.Controls.Add(this.listeleBtn);
            this.panel2.Controls.Add(this.infoCopyBtn);
            this.panel2.Controls.Add(this.studentClassEntry);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.studentGradeEntry);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.studentNameEntry);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.studentNoEntry);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.studentIDEntry);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(525, 376);
            this.panel2.TabIndex = 1;
            // 
            // guncelleBtn
            // 
            this.guncelleBtn.Location = new System.Drawing.Point(384, 193);
            this.guncelleBtn.Name = "guncelleBtn";
            this.guncelleBtn.Size = new System.Drawing.Size(137, 82);
            this.guncelleBtn.TabIndex = 14;
            this.guncelleBtn.Text = "Guncelle";
            this.guncelleBtn.UseVisualStyleBackColor = true;
            this.guncelleBtn.Click += new System.EventHandler(this.guncelleBtn_Click);
            // 
            // silBtn
            // 
            this.silBtn.Location = new System.Drawing.Point(241, 193);
            this.silBtn.Name = "silBtn";
            this.silBtn.Size = new System.Drawing.Size(137, 82);
            this.silBtn.TabIndex = 13;
            this.silBtn.Text = "Sil";
            this.silBtn.UseVisualStyleBackColor = true;
            this.silBtn.Click += new System.EventHandler(this.silBtn_Click);
            // 
            // kaydetBtn
            // 
            this.kaydetBtn.Location = new System.Drawing.Point(384, 105);
            this.kaydetBtn.Name = "kaydetBtn";
            this.kaydetBtn.Size = new System.Drawing.Size(137, 82);
            this.kaydetBtn.TabIndex = 12;
            this.kaydetBtn.Text = "Kaydet";
            this.kaydetBtn.UseVisualStyleBackColor = true;
            this.kaydetBtn.Click += new System.EventHandler(this.kaydetBtn_Click);
            // 
            // listeleBtn
            // 
            this.listeleBtn.Location = new System.Drawing.Point(241, 105);
            this.listeleBtn.Name = "listeleBtn";
            this.listeleBtn.Size = new System.Drawing.Size(137, 82);
            this.listeleBtn.TabIndex = 11;
            this.listeleBtn.Text = "Listele";
            this.listeleBtn.UseVisualStyleBackColor = true;
            this.listeleBtn.Click += new System.EventHandler(this.listeleBtn_Click);
            // 
            // infoCopyBtn
            // 
            this.infoCopyBtn.Location = new System.Drawing.Point(3, 323);
            this.infoCopyBtn.Name = "infoCopyBtn";
            this.infoCopyBtn.Size = new System.Drawing.Size(232, 48);
            this.infoCopyBtn.TabIndex = 10;
            this.infoCopyBtn.Text = "Ogrenci Bilgilerini Kopyala";
            this.infoCopyBtn.UseVisualStyleBackColor = true;
            this.infoCopyBtn.Click += new System.EventHandler(this.infoCopyBtn_Click);
            // 
            // studentClassEntry
            // 
            this.studentClassEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentClassEntry.Location = new System.Drawing.Point(3, 279);
            this.studentClassEntry.Name = "studentClassEntry";
            this.studentClassEntry.Size = new System.Drawing.Size(232, 38);
            this.studentClassEntry.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 256);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Ogrenci Sube";
            // 
            // studentGradeEntry
            // 
            this.studentGradeEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentGradeEntry.Location = new System.Drawing.Point(3, 215);
            this.studentGradeEntry.Name = "studentGradeEntry";
            this.studentGradeEntry.Size = new System.Drawing.Size(232, 38);
            this.studentGradeEntry.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ogrenci Sinif";
            // 
            // studentNameEntry
            // 
            this.studentNameEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentNameEntry.Location = new System.Drawing.Point(3, 151);
            this.studentNameEntry.Name = "studentNameEntry";
            this.studentNameEntry.Size = new System.Drawing.Size(232, 38);
            this.studentNameEntry.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ogrenci Ad Soyad";
            // 
            // studentNoEntry
            // 
            this.studentNoEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentNoEntry.Location = new System.Drawing.Point(3, 87);
            this.studentNoEntry.Name = "studentNoEntry";
            this.studentNoEntry.Size = new System.Drawing.Size(232, 38);
            this.studentNoEntry.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ogrenci No";
            // 
            // studentIDEntry
            // 
            this.studentIDEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentIDEntry.Location = new System.Drawing.Point(3, 23);
            this.studentIDEntry.Name = "studentIDEntry";
            this.studentIDEntry.Size = new System.Drawing.Size(232, 38);
            this.studentIDEntry.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ogrenci ID";
            // 
            // ogrenciDBGrid
            // 
            this.ogrenciDBGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ogrenciDBGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ogrenciDBGrid.Location = new System.Drawing.Point(3, 385);
            this.ogrenciDBGrid.Name = "ogrenciDBGrid";
            this.ogrenciDBGrid.Size = new System.Drawing.Size(985, 321);
            this.ogrenciDBGrid.TabIndex = 0;
            this.ogrenciDBGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ogrenciDBGrid_CellContentClick);
            // 
            // backBtnInfo
            // 
            this.backBtnInfo.Image = global::OgrenciBilgiSistemi.Properties.Resources.backarrow;
            this.backBtnInfo.Location = new System.Drawing.Point(950, 3);
            this.backBtnInfo.Name = "backBtnInfo";
            this.backBtnInfo.Size = new System.Drawing.Size(35, 35);
            this.backBtnInfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.backBtnInfo.TabIndex = 5;
            this.backBtnInfo.TabStop = false;
            this.backBtnInfo.Click += new System.EventHandler(this.backBtnInfo_Click);
            // 
            // OgrenciEkleSil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(1012, 733);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "OgrenciEkleSil";
            this.Text = "Ogrenci Ekle/Sil";
            this.Shown += new System.EventHandler(this.OgrenciEkleSil_Shown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciDBGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backBtnInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.DataGridView ogrenciDBGrid;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox studentClassEntry;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox studentGradeEntry;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox studentNameEntry;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox studentNoEntry;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox studentIDEntry;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button infoCopyBtn;
        private System.Windows.Forms.Button listeleBtn;
        private System.Windows.Forms.Button kaydetBtn;
        private System.Windows.Forms.Button guncelleBtn;
        private System.Windows.Forms.Button silBtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button byGradeBtn;
        private System.Windows.Forms.Button byClassBtn;
        private System.Windows.Forms.TextBox classListEntry;
        private System.Windows.Forms.TextBox gradeListEntry;
        private System.Windows.Forms.PictureBox backBtnInfo;
    }
}