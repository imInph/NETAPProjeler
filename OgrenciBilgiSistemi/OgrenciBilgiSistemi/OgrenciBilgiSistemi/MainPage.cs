using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OgrenciBilgiSistemi
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void ogrenciEkSil_Click(object sender, EventArgs e)
        {
            Methods.FormSwitching.FormSwitch(this, new OgrenciEkleSil());
            this.Close();
        }

        private void logOutBtn_Click(object sender, EventArgs e)
        {
            Methods.FormSwitching.FormSwitch(this, new LogIn());
            this.Close();
        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            if (Variables.Session.tempAccountType == "Admin" ||
                Variables.Session.tempAccountType == "Both")
            {
                ogrenciEkSil.Enabled = true;
                kullaniciEkDeg.Enabled = true;
            }
            else
            {
                ogrenciEkSil.Enabled = false;
                kullaniciEkDeg.Enabled = false;
            }
        }

        private void kullaniciEkDeg_Click(object sender, EventArgs e)
        {
            Methods.FormSwitching.FormSwitch(this, new kullaniciEkDeg());
            this.Close();
        }

        private void ogrenciNot_Click(object sender, EventArgs e)
        {
            Methods.FormSwitching.FormSwitch(this, new ogrenciNotGirisi());
            this.Close();
        }
    }
}