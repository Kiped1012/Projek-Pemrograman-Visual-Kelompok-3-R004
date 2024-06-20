using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Brenius
{
    public partial class FormSoal : Form
    {
        private string nisnSiswa;
        private string namaSiswa;
        private string kelasSiswa;
        private string mapel;
        private string connectionString = "server=localhost;database=brenius;uid=root;pwd=";
        private List<Soal> daftarSoal;
        private int indexSoal = 0;
        private int nilai = 0;
        private Dictionary<int, string> jawabanSiswa;

        public FormSoal(string nisnSiswa, string namaSiswa, string kelasSiswa, string mapel)
        {
            InitializeComponent();
            this.nisnSiswa = nisnSiswa;
            this.namaSiswa = namaSiswa;
            this.kelasSiswa = kelasSiswa;
            this.mapel = mapel;
            jawabanSiswa = new Dictionary<int, string>();
            LoadSoal();
        }

        private void LoadSoal()
        {
            daftarSoal = new List<Soal>();
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT id_soal, pertanyaan, jawaban_benar FROM soal WHERE id_mapel = @id_mapel";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id_mapel", GetMapelId(mapel));
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Soal soal = new Soal
                    {
                        IdSoal = reader.GetInt32("id_soal"),
                        Pertanyaan = reader.GetString("pertanyaan"),
                        JawabanBenar = reader.GetString("jawaban_benar")
                    };
                    daftarSoal.Add(soal);
                }
            }
            TampilkanSoal();
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

        private void TampilkanSoal()
        {
            if (indexSoal < daftarSoal.Count)
            {
                lbl_pertanyaan.Text = daftarSoal[indexSoal].Pertanyaan;
                txt_jawaban.Text = jawabanSiswa.ContainsKey(indexSoal) ? jawabanSiswa[indexSoal] : "";
            }
            else
            {
                lbl_pertanyaan.Text = "Anda telah menjawab semua soal.";
                txt_jawaban.Enabled = false;
                btn_kumpulkan.Enabled = true;
                btn_kumpulkan.Focus();
            }
        }

        private void btn_soal_selanjutnya_Click(object sender, EventArgs e)
        {
            jawabanSiswa[indexSoal] = txt_jawaban.Text.Trim();
            indexSoal++;
            if (indexSoal < daftarSoal.Count)
            {
                TampilkanSoal();
            }
            else
            {
                MessageBox.Show("Anda telah menjawab semua soal. Silakan klik 'Kumpulkan' untuk mengirim jawaban Anda.");
                txt_jawaban.Enabled = false;
                btn_soal_selanjutnya.Enabled = false;
                btn_kumpulkan.Enabled = true;
                btn_kumpulkan.Focus();
            }
        }

        private void btn_kumpulkan_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < daftarSoal.Count; i++)
            {
                if (jawabanSiswa.ContainsKey(i) && jawabanSiswa[i].Equals(daftarSoal[i].JawabanBenar, StringComparison.OrdinalIgnoreCase))
                {
                    nilai += 20;
                }
            }
            lbl_nilai.Text = "Nilai Anda: " + nilai.ToString();
            SimpanNilaiKeDatabase(nisnSiswa, mapel, nilai);
            btn_kumpulkan.Enabled = false;
        }

        private void SimpanNilaiKeDatabase(string nisnSiswa, string mapel, int nilai)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "INSERT INTO nilai_siswa (nisn, id_mapel, nilai) VALUES (@nisn, @id_mapel, @nilai)";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@nisn", nisnSiswa);
                    cmd.Parameters.AddWithValue("@id_mapel", GetMapelId(mapel));
                    cmd.Parameters.AddWithValue("@nilai", nilai);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Nilai berhasil disimpan.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            if (indexSoal >= daftarSoal.Count)
            {
                FormPilihanKuis formPilihanKuis = new FormPilihanKuis(nisnSiswa, namaSiswa, kelasSiswa);
                formPilihanKuis.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Selesaikan semua soal terlebih dahulu.");
            }
        }
    }

    public class Soal
    {
        public int IdSoal { get; set; }
        public string Pertanyaan { get; set; }
        public string JawabanBenar { get; set; }
    }
}
