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
    public partial class OgrenciEkleSil : Form
    {
        public OgrenciEkleSil()
        {
            InitializeComponent();
        }

        private async Task giveAlert()
        {
            System.Media.SystemSounds.Exclamation.Play();
            infoCopyBtn.Text = "Kopyalandi";
            await Task.Delay(1000);
            infoCopyBtn.Text = "Ogrenci Bilgilerini Kopyala";
        }
        private async void infoCopyBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(studentNoEntry.Text) ||
                !string.IsNullOrEmpty(studentNameEntry.Text) ||
                !string.IsNullOrEmpty(studentGradeEntry.Text) ||
                !string.IsNullOrEmpty(studentClassEntry.Text))
            {
                Clipboard.SetText($"{studentNoEntry.Text} {studentNameEntry.Text} {studentGradeEntry.Text}-{studentClassEntry.Text}");
                await giveAlert();
            }
            else
            {
                MessageBox.Show("Eksik bilgi oldugu icin kopyalanamadi.", "Bilgilendirme", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        private void listeleBtn_Click(object sender, EventArgs e)
        {
            Methods.DbList.ListDb("students", ogrenciDBGrid);
        }

        private void kaydetBtn_Click(object sender, EventArgs e)
        {
            Methods.DbConn.DbConnectionOpen("students");
            OleDbCommand cmd = new OleDbCommand("INSERT INTO Students ([StudentNO], [StudentName], [StudentGrade], [StudentClass]) " +
                                                "VALUES (@p1, @p2, @p3, @p4)", Variables.DbConn.StudentsConn);
            cmd.Parameters.AddWithValue("@p1", Convert.ToInt32(studentNoEntry.Text));
            cmd.Parameters.AddWithValue("@p2", studentNameEntry.Text);
            cmd.Parameters.AddWithValue("@p3", Convert.ToInt32(studentGradeEntry.Text));
            cmd.Parameters.AddWithValue("@p4", studentClassEntry.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Basariyla kaydedildi.", "Bilgilendirme", MessageBoxButtons.OK);
            Methods.DbConn.DbConnectionClose("students");
            Methods.DbList.ListDb("students", ogrenciDBGrid);
        }

        private void silBtn_Click(object sender, EventArgs e)
        {
            Methods.DbConn.DbConnectionOpen("students");
            OleDbCommand cmd = new OleDbCommand("DELETE FROM Students WHERE StudentID = ?", Variables.DbConn.StudentsConn);
            cmd.Parameters.AddWithValue("?", Convert.ToInt32(studentIDEntry.Text));
            cmd.ExecuteNonQuery();
            MessageBox.Show("Basariyla silindi.", "Bilgilendirme", MessageBoxButtons.OK);
            Methods.DbConn.DbConnectionClose("students");
            Methods.DbList.ListDb("students", ogrenciDBGrid);
        }

        private void guncelleBtn_Click(object sender, EventArgs e)
        {
            Methods.DbConn.DbConnectionOpen("students");
            OleDbCommand cmd = new OleDbCommand("UPDATE Students set StudentNO=@p1, StudentName=@p2, " +
                                                "StudentGrade=@p3, StudentClass=@p4", Variables.DbConn.StudentsConn);
            cmd.Parameters.AddWithValue("@p1", Convert.ToInt32(studentNoEntry.Text));
            cmd.Parameters.AddWithValue("@p2", studentNameEntry.Text);
            cmd.Parameters.AddWithValue("@p3", Convert.ToInt32(studentGradeEntry.Text));
            cmd.Parameters.AddWithValue("@p4", studentClassEntry.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Basariyla guncellendi.", "Bilgilendirme", MessageBoxButtons.OK);
            Methods.DbConn.DbConnectionClose("students");
            Methods.DbList.ListDb("students", ogrenciDBGrid);
        }

        private void OgrenciEkleSil_Shown(object sender, EventArgs e)
        {
            Methods.DbList.ListDb("students", ogrenciDBGrid);
        }

        private void byGradeBtn_Click(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter($"Select * from Students " +
                                                                $"WHERE StudentGrade={Convert.ToInt32(gradeListEntry.Text)}", 
                Variables.DbConn.StudentsConn);
            dataAdapter.Fill(dataTable);
            ogrenciDBGrid.DataSource = dataTable;
        }

        private void ogrenciDBGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = ogrenciDBGrid.SelectedCells[0].RowIndex;
            studentIDEntry.Text = ogrenciDBGrid.Rows[secilen].Cells[0].Value.ToString();
            studentNoEntry.Text = ogrenciDBGrid.Rows[secilen].Cells[1].Value.ToString();
            studentNameEntry.Text = ogrenciDBGrid.Rows[secilen].Cells[2].Value.ToString();
            studentGradeEntry.Text = ogrenciDBGrid.Rows[secilen].Cells[3].Value.ToString();
            studentClassEntry.Text = ogrenciDBGrid.Rows[secilen].Cells[4].Value.ToString();
        }



        private void byClassBtn_Click(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter($"Select * from Students " +
                                                                $"WHERE StudentClass='{classListEntry.Text}'",
                Variables.DbConn.StudentsConn);
            dataAdapter.Fill(dataTable);
            ogrenciDBGrid.DataSource = dataTable;
        }

        private void backBtnInfo_Click(object sender, EventArgs e)
        {
            Methods.FormSwitching.FormSwitch(this, new MainPage());
            this.Close();
        }
    }
}
