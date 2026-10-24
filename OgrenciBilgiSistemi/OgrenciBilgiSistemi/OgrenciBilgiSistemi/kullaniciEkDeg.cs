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

namespace OgrenciBilgiSistemi
{
    public partial class kullaniciEkDeg : Form
    {
        public kullaniciEkDeg()
        {
            InitializeComponent();
        }

        private void listeleBtn_Click(object sender, EventArgs e)
        {
            Methods.DbList.ListDb("users", usersDBGrid);
        }

        private async Task giveAlert()
        {
            System.Media.SystemSounds.Exclamation.Play();
            infoCopyBtn.Text = "Kopyalandi";
            await Task.Delay(1000);
            infoCopyBtn.Text = "Kullanici Bilgilerini Kopyala";
        }

        private async void infoCopyBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(usernameEntry.Text) ||
                !string.IsNullOrEmpty(userPasswordEntry.Text) ||
                !string.IsNullOrEmpty(accountTypeSelect.Text))
            {
                Clipboard.SetText($"{usernameEntry.Text} {userPasswordEntry.Text} {accountTypeSelect.Text}");
                await giveAlert();
            }
            else
            {
                MessageBox.Show("Eksik bilgi oldugu icin kopyalanamadi.", "Bilgilendirme", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        private void kaydetBtn_Click(object sender, EventArgs e)
        {
            string chosenAccType = accountTypeSelect.Text;
            if (chosenAccType == "Yonetici")
            {
                chosenAccType = "Admin";
            }
            else if (chosenAccType == "Ogretmen")
            {
                chosenAccType = "Teacher";
            }
            else if (chosenAccType == "Ikiside")
            {
                chosenAccType = "Both";
            }
            else
            {
                MessageBox.Show("Yanlis hesap tur secimi.", "Bilgilendirme", MessageBoxButtons.OK);
            }
            Methods.DbConn.DbConnectionOpen("users");
            OleDbCommand cmd = new OleDbCommand("INSERT INTO Users ([UserName], [Password], [AccountType]) " +
                                                "VALUES (@p1, @p2, @p3)", Variables.DbConn.UserConn);
            cmd.Parameters.AddWithValue("@p1", usernameEntry.Text);
            cmd.Parameters.AddWithValue("@p2", userPasswordEntry.Text);
            cmd.Parameters.AddWithValue("@p3", chosenAccType);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Basariyla kaydedildi.", "Bilgilendirme", MessageBoxButtons.OK);
            Methods.DbConn.DbConnectionClose("users");
            Methods.DbList.ListDb("users", usersDBGrid);
        }

        private void backBtnUser_Click(object sender, EventArgs e)
        {
            Methods.FormSwitching.FormSwitch(this, new MainPage());
            this.Close();
        }

        private void kullaniciEkDeg_Shown(object sender, EventArgs e)
        {
            Methods.DbList.ListDb("users", usersDBGrid);
        }

        private void usersDBGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = usersDBGrid.SelectedCells[0].RowIndex;
            userIDEntry.Text = usersDBGrid.Rows[secilen].Cells[0].Value.ToString();
            usernameEntry.Text = usersDBGrid.Rows[secilen].Cells[1].Value.ToString();
            userPasswordEntry.Text = usersDBGrid.Rows[secilen].Cells[2].Value.ToString();
            accountTypeSelect.Text = usersDBGrid.Rows[secilen].Cells[3].Value.ToString();
        }

        private void byTypeBtn_Click(object sender, EventArgs e)
        {
            string chosenAccType = listSelectionBox.Text;
            if (chosenAccType == "Yonetici")
            {
                chosenAccType = "Admin";
            }
            else if (chosenAccType == "Ogretmen")
            {
                chosenAccType = "Teacher";
            }
            else if (chosenAccType == "Ikiside")
            {
                chosenAccType = "Both";
            }
            else
            {
                MessageBox.Show("Yanlis hesap tur secimi.", "Bilgilendirme", MessageBoxButtons.OK);
            }
            DataTable dataTable = new DataTable();
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter($"Select * from Users " +
                                                                $"WHERE AccountType='{chosenAccType}'",
                Variables.DbConn.UserConn);
            dataAdapter.Fill(dataTable);
            usersDBGrid.DataSource = dataTable;
        }

        private void silBtn_Click(object sender, EventArgs e)
        {
            Methods.DbConn.DbConnectionOpen("users");
            OleDbCommand cmd = new OleDbCommand("DELETE FROM Users WHERE UserID = ?", Variables.DbConn.UserConn);
            cmd.Parameters.AddWithValue("?", Convert.ToInt32(userIDEntry.Text));
            cmd.ExecuteNonQuery();
            MessageBox.Show("Basariyla silindi.", "Bilgilendirme", MessageBoxButtons.OK);
            Methods.DbConn.DbConnectionClose("users");
            Methods.DbList.ListDb("users", usersDBGrid);
        }

        private void guncelleBtn_Click(object sender, EventArgs e)
        {
            string chosenAccType = accountTypeSelect.Text;
            if (chosenAccType == "Yonetici")
            {
                chosenAccType = "Admin";
            }
            else if (chosenAccType == "Ogretmen")
            {
                chosenAccType = "Teacher";
            }
            else if (chosenAccType == "Ikiside")
            {
                chosenAccType = "Both";
            }
            else
            {
                MessageBox.Show("Yanlis hesap tur secimi.", "Bilgilendirme", MessageBoxButtons.OK);
            }
            Methods.DbConn.DbConnectionOpen("users");
            OleDbCommand cmd = new OleDbCommand("UPDATE Users set [UserName]=@p1, [Password]=@p2, " +
                                                "AccountType=@p3 WHERE UserID=@p4", Variables.DbConn.UserConn);
            cmd.Parameters.AddWithValue("@p1", usernameEntry.Text);
            cmd.Parameters.AddWithValue("@p2", userPasswordEntry.Text);
            cmd.Parameters.AddWithValue("@p3", chosenAccType);
            cmd.Parameters.AddWithValue("@p4", Convert.ToInt32(userIDEntry.Text));
            cmd.ExecuteNonQuery();
            MessageBox.Show("Basariyla guncellendi.", "Bilgilendirme", MessageBoxButtons.OK);
            Methods.DbConn.DbConnectionClose("users");
            Methods.DbList.ListDb("users", usersDBGrid);
        }
    }
}
