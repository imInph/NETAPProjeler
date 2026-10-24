using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace proj
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=""C:\Users\ogrenci.DESKTOP-75FI9G7.000\Desktop\Miraç Arda Canbulat\proj\kutuphane.mdb""");
        void listele()
        {
            DataTable DataTable = new DataTable();
            OleDbDataAdapter DataAdapter = new OleDbDataAdapter("Select * from kitaplık", baglanti);
            DataAdapter.Fill(DataTable);
            dataGridView1.DataSource = DataTable;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            listele();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (baglanti.State == ConnectionState.Open)
            {
            }
            else if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }
            OleDbCommand KomutBir = new OleDbCommand("insert into kitaplık (KitapAd,KitapYazar,Tür,Sayfa) values" +
                "(@p1,@p2,@p3,@p4)", baglanti);
            KomutBir.Parameters.AddWithValue("@p1", textBox2.Text);
            KomutBir.Parameters.AddWithValue("@p2", textBox3.Text);
            KomutBir.Parameters.AddWithValue("@p3", comboBox1.Text);
            KomutBir.Parameters.AddWithValue("@p4", textBox4.Text);
            KomutBir.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kitap sisteme kaydedildi", "Bilgilendirme", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            listele();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            textBox1.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            comboBox1.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (baglanti.State == ConnectionState.Open)
            {
            }
            else if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }
            OleDbCommand komut1 = new OleDbCommand("update [kitaplık] set [KitapAd]=@p1, [KitapYazar]=@p2, " +
                "[Sayfa]=@p3, [Tür]=@p4 " +
                "where [KitapID]=@p5", baglanti);

            komut1.Parameters.AddWithValue("@p1", textBox2.Text);
            komut1.Parameters.AddWithValue("@p2", textBox3.Text);
            komut1.Parameters.AddWithValue("@p3", textBox4.Text);
            komut1.Parameters.AddWithValue("@p4", comboBox1.Text);
            komut1.Parameters.AddWithValue("@p5", textBox1.Text);

            komut1.ExecuteNonQuery();

            baglanti.Close();

            listele();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (baglanti.State == ConnectionState.Open)
            {
            }
            else if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }
            OleDbCommand komut1 = new OleDbCommand("delete from [kitaplık] where KitapID=@p1", baglanti);
            komut1.Parameters.AddWithValue("@p1", textBox1.Text);
            komut1.ExecuteNonQuery();
            baglanti.Close();
            listele();
        }
    }
}
