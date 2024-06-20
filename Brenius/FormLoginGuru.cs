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
    public partial class FormLoginGuru : Form
    {
        public FormLoginGuru()
        {
            InitializeComponent();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            // Membuat instance dari FormPilihan dan menampilkannya
            FormPilihan formPilihan = new FormPilihan();
            formPilihan.Show();

            // Menutup form saat ini
            this.Close();
        }

        private void btn_login_guru_Click(object sender, EventArgs e)
        {
            // Mendapatkan input dari textbox
            string nip_guru = nip.Text;  // TextBox untuk NISN
            string nama = nama_guru.Text;  // TextBox untuk Nama

            // String koneksi ke database
            string connectionString = "server=localhost;database=brenius;uid=root;pwd=";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM guru WHERE nip = @nip AND nama = @nama";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@nip", nip_guru);
                    cmd.Parameters.AddWithValue("@nama", nama);

                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        string namaGuru = reader["nama"].ToString();
                        string mapelGuru = reader["mata_pelajaran"].ToString();
                        string nipGuru = reader["nip"].ToString();

                        MessageBox.Show("Login berhasil!");
                        // Lakukan sesuatu setelah login berhasil, misalnya buka form lain
                        // Membuat instance dari FormHome dan menampilkannya
                        FormHomeGuru formHomeGuru = new FormHomeGuru(nipGuru, namaGuru, mapelGuru);
                        formHomeGuru.Show();

                        // Menutup form saat ini
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("NIP atau Nama tidak ditemukan.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Terjadi kesalahan: " + ex.Message);
                }
            }
        }
    }
}
