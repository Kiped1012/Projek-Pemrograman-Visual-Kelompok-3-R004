using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Brenius
{
    public partial class FormLoginSiswa : Form
    {
        public FormLoginSiswa()
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

        private void btn_login_siswa_Click(object sender, EventArgs e)
        {
            // Mendapatkan input dari textbox
            string nisn_siswa = nisn.Text;  // TextBox untuk NISN
            string nama = nama_siswa.Text;  // TextBox untuk Nama

            // String koneksi ke database
            string connectionString = "server=localhost;database=brenius;uid=root;pwd=";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM siswa WHERE nisn = @nisn AND nama = @nama";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@nisn", nisn_siswa);
                    cmd.Parameters.AddWithValue("@nama", nama);

                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        string namaSiswa = reader["nama"].ToString();
                        string kelasSiswa = reader["kelas"].ToString();
                        string nisnSiswa = reader["nisn"].ToString();

                        MessageBox.Show("Login berhasil!");
                        // Lakukan sesuatu setelah login berhasil, misalnya buka form lain
                        // Membuat instance dari FormHome dan menampilkannya
                        FormHome formHome = new FormHome(nisnSiswa, namaSiswa, kelasSiswa);
                        formHome.Show();

                        // Menutup form saat ini
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("NISN atau Nama tidak ditemukan.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Terjadi kesalahan: " + ex.Message);
                }
            }
        }

        private void FormLoginSiswa_Load(object sender, EventArgs e)
        {

        }
    }
}
