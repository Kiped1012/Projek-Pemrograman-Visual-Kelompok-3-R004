using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Brenius
{
    public partial class FormNilai : Form
    {
        private string nipGuru;
        private string namaGuru;
        private string mapelGuru;
        private string connectionString = "server=localhost;database=brenius;uid=root;pwd=";

        public FormNilai(string nipGuru, string namaGuru, string mapelGuru)
        {
            InitializeComponent();
            this.nipGuru = nipGuru;
            this.namaGuru = namaGuru;
            this.mapelGuru = mapelGuru;
        }

        private void FormNilai_Load(object sender, EventArgs e)
        {
            LoadNilai();
        }

        private void LoadNilai()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT siswa.nisn, siswa.nama, nilai_siswa.nilai " +
                               "FROM nilai_siswa " +
                               "JOIN siswa ON nilai_siswa.nisn = siswa.nisn " +
                               "JOIN mapel ON nilai_siswa.id_mapel = mapel.id_mapel " +
                               "WHERE mapel.nama_mapel = @mapel";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@mapel", mapelGuru);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridViewNilai.DataSource = dt;
                dataGridViewNilai.Columns["nilai"].HeaderText = "Nilai";
                dataGridViewNilai.Columns["nama"].HeaderText = "Nama Siswa";
                dataGridViewNilai.Columns["nisn"].HeaderText = "NISN";
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "DELETE nilai_siswa " +
                               "FROM nilai_siswa " +
                               "JOIN mapel ON nilai_siswa.id_mapel = mapel.id_mapel " +
                               "WHERE mapel.nama_mapel = @mapel";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@mapel", mapelGuru);
                cmd.ExecuteNonQuery();
            }
            LoadNilai();
            MessageBox.Show("Semua nilai berhasil dihapus.");
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            FormHomeGuru formHomeGuru = new FormHomeGuru(nipGuru, namaGuru, mapelGuru);
            formHomeGuru.Show();
            this.Close();
        }
    }
}