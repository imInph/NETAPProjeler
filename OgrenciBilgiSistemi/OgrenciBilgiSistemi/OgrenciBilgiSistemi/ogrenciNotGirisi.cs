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
    public partial class ogrenciNotGirisi : Form
    {
        public ogrenciNotGirisi()
        {
            InitializeComponent();
        }

        private void backBtnInfo_Click(object sender, EventArgs e)
        {
            Methods.FormSwitching.FormSwitch(this, new MainPage());
            this.Close();
        }

        private void listeleBtn_Click(object sender, EventArgs e)
        {
            Methods.DbList.ListDb("subjects", subjectsDBGrid);
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
            if (!string.IsNullOrEmpty(subjectNameEntry.Text) ||
                !string.IsNullOrEmpty(studentNOEntry.Text) ||
                !string.IsNullOrEmpty(studentNameEntry.Text) ||
                !string.IsNullOrEmpty(studentGradeEntry.Text))
            {
                Clipboard.SetText($"{subjectNameEntry.Text} {studentNOEntry.Text} {studentNameEntry.Text} {studentGradeEntry.Text}");
                await giveAlert();
            }
            else
            {
                MessageBox.Show("Eksik bilgi oldugu icin kopyalanamadi.", "Bilgilendirme", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        private void subjectsDBGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = subjectsDBGrid.SelectedCells[0].RowIndex;
            autoIDEntry.Text = subjectsDBGrid.Rows[secilen].Cells[0].Value.ToString();
            subjectNameEntry.Text = subjectsDBGrid.Rows[secilen].Cells[1].Value.ToString();
            studentNOEntry.Text = subjectsDBGrid.Rows[secilen].Cells[2].Value.ToString();
            studentNameEntry.Text = subjectsDBGrid.Rows[secilen].Cells[3].Value.ToString();
            studentGradeEntry.Text = subjectsDBGrid.Rows[secilen].Cells[4].Value.ToString();
            
        }

        private void ogrenciNotGirisi_Shown(object sender, EventArgs e)
        {
            Methods.DbList.ListDb("subjects", subjectsDBGrid);
        }

        private void bySubjectBtn_Click(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter($"Select * from Subjects " +
                                                                $"WHERE SubjectName={subjectListEntry.Text}",
                Variables.DbConn.SubjectsConn);
            dataAdapter.Fill(dataTable);
            subjectsDBGrid.DataSource = dataTable;
        }

        private void byNumBtn_Click(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter($"Select * from Subjects " +
                                                                $"WHERE StudentNO={Convert.ToInt32(numListEntry.Text)}",
                Variables.DbConn.SubjectsConn);
            dataAdapter.Fill(dataTable);
            subjectsDBGrid.DataSource = dataTable;
        }

        private void kaydetBtn_Click(object sender, EventArgs e)
        {
            Methods.DbConn.DbConnectionOpen("subjects");
            OleDbCommand cmd = new OleDbCommand("INSERT INTO Subjects ([SubjectName], [StudentNO], [StudentName], [ExamGrade]) " +
                                                "VALUES (@p1, @p2, @p3, @p4)", Variables.DbConn.SubjectsConn);
            cmd.Parameters.AddWithValue("@p1", subjectNameEntry.Text);
            cmd.Parameters.AddWithValue("@p2", Convert.ToInt32(studentNOEntry.Text));
            cmd.Parameters.AddWithValue("@p3", studentNameEntry.Text);
            cmd.Parameters.AddWithValue("@p4", Convert.ToInt32(studentGradeEntry.Text));
            cmd.ExecuteNonQuery();
            MessageBox.Show("Basariyla kaydedildi.", "Bilgilendirme", MessageBoxButtons.OK);
            Methods.DbConn.DbConnectionClose("subjects");
            Methods.DbList.ListDb("subjects", subjectsDBGrid);
        }

        private void silBtn_Click(object sender, EventArgs e)
        {
            Methods.DbConn.DbConnectionOpen("subjects");
            OleDbCommand cmd = new OleDbCommand("DELETE FROM Subjects WHERE AutoID = ?", Variables.DbConn.SubjectsConn);
            cmd.Parameters.AddWithValue("?", Convert.ToInt32(autoIDEntry.Text));
            cmd.ExecuteNonQuery();
            MessageBox.Show("Basariyla silindi.", "Bilgilendirme", MessageBoxButtons.OK);
            Methods.DbConn.DbConnectionClose("subjects");
            Methods.DbList.ListDb("subjects", subjectsDBGrid);
        }

        private void guncelleBtn_Click(object sender, EventArgs e)
        {
            Methods.DbConn.DbConnectionOpen("subjects");
            OleDbCommand cmd = new OleDbCommand("UPDATE Subjects set SubjectName=@p1, StudentNO=@p2, " +
                                                "StudentName=@p3, ExamGrade=@p4", Variables.DbConn.SubjectsConn);
            cmd.Parameters.AddWithValue("@p1", subjectNameEntry.Text);
            cmd.Parameters.AddWithValue("@p2", Convert.ToInt32(studentNOEntry.Text));
            cmd.Parameters.AddWithValue("@p3", studentNameEntry.Text);
            cmd.Parameters.AddWithValue("@p4", Convert.ToInt32(studentGradeEntry.Text));
            cmd.ExecuteNonQuery();
            MessageBox.Show("Basariyla guncellendi.", "Bilgilendirme", MessageBoxButtons.OK);
            Methods.DbConn.DbConnectionClose("subjects");
            Methods.DbList.ListDb("subjects", subjectsDBGrid);
        }
    }
}
