using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Brenius
{
    public partial class FormKuis : Form
    {
        private string nipGuru;
        private string namaGuru;
        private string mapelGuru;
        private string connectionString = "server=localhost;database=brenius;uid=root;pwd=;";

        public FormKuis(string nipGuru, string namaGuru, string mapelGuru)
        {
            InitializeComponent();
            this.nipGuru = nipGuru;
            this.namaGuru = namaGuru;
            this.mapelGuru = mapelGuru;
            LoadSoal();
        }

        private void btn_buat_Click(object sender, EventArgs e)
        {
            string soal = txt_soal.Text;
            string jawaban = txt_jawaban.Text;

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO soal (nip, id_mapel, pertanyaan, jawaban_benar) VALUES (@nip, @id_mapel, @soal, @jawaban)";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@nip", nipGuru);
                cmd.Parameters.AddWithValue("@id_mapel", GetMapelId(mapelGuru));
                cmd.Parameters.AddWithValue("@soal", soal);
                cmd.Parameters.AddWithValue("@jawaban", jawaban);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Soal berhasil dibuat!");
                LoadSoal();
            }
        }

        private void LoadSoal()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT id_soal, pertanyaan, jawaban_benar FROM soal WHERE id_mapel = @id_mapel";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id_mapel", GetMapelId(mapelGuru));
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridViewSoal.DataSource = dt;
            }
        }

        private int GetMapelId(string namaMapel)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT id_mapel FROM mapel WHERE nama_mapel = @nama_mapel";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@nama_mapel", namaMapel);
                object result = cmd.ExecuteScalar();
                return Convert.ToInt32(result);
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            int idSoal = Convert.ToInt32(txt_id_soal.Text);
            string soal = txt_soal.Text;
            string jawaban = txt_jawaban.Text;

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "UPDATE soal SET pertanyaan = @soal, jawaban_benar = @jawaban WHERE id_soal = @id_soal";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id_soal", idSoal);
                cmd.Parameters.AddWithValue("@soal", soal);
                cmd.Parameters.AddWithValue("@jawaban", jawaban);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Soal berhasil diperbarui!");
                LoadSoal();
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            int idSoal = Convert.ToInt32(txt_id_soal.Text);

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "DELETE FROM soal WHERE id_soal = @id_soal";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id_soal", idSoal);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Soal berhasil dihapus!");
                LoadSoal();
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            // Membuat instance dari FormHomeGuru dan menampilkannya
            FormHomeGuru formHomeGuru = new FormHomeGuru(nipGuru, namaGuru, mapelGuru);
            formHomeGuru.Show();

            // Menutup form saat ini
            this.Close();
        }
    }
}
