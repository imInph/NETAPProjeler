using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static OgrenciBilgiSistemi.Variables;

namespace OgrenciBilgiSistemi
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void logInBtn_Click(object sender, EventArgs e)
        {
            Methods.DbConn.DbConnectionOpen("users");

            OleDbCommand cmd = new OleDbCommand(
                "SELECT * FROM Users WHERE Username=? AND Password=?",
                Variables.DbConn.UserConn);

            cmd.Parameters.AddWithValue("", usernameEntry.Text);
            cmd.Parameters.AddWithValue("", passwordEntry.Text);

            OleDbDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                Variables.Session.tempAccountType = reader["AccountType"].ToString();
                Methods.FormSwitching.FormSwitch(this, new MainPage());
            }
            else
            {
                MessageBox.Show("Kullanici adi veya sifre yanlis.");
            }

            reader.Close();

            Methods.DbConn.DbConnectionClose("users");
        }

        bool passIsHidden = true;

        private void passShowToggleBtn_Click(object sender, EventArgs e)
        {
            if (passIsHidden)
            {
                passwordEntry.UseSystemPasswordChar = false;
                passShowToggleBtn.Image = Properties.Resources.eyeclosedpng;
                passIsHidden = false;
            }
            else
            {
                passwordEntry.UseSystemPasswordChar = true;
                passShowToggleBtn.Image = Properties.Resources.eyeopenpng;
                passIsHidden = true;
            }
        }

        private void LogIn_Shown(object sender, EventArgs e)
        {
            Variables.Session.tempAccountType = "";
            usernameEntry.Text = String.Empty;
            passwordEntry.Text = String.Empty;
        }
    }
}
