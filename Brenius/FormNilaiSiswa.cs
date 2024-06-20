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
    public partial class FormNilaiSiswa : Form
    {
        private string namaSiswa;
        private string kelasSiswa;
        private string nisnSiswa;
        private string connectionString = "server=localhost;database=brenius;uid=root;pwd=";

        public FormNilaiSiswa(string nisnSiswa, string namaSiswa, string kelasSiswa)
        {
            InitializeComponent();
            this.nisnSiswa = nisnSiswa;
            this.namaSiswa = namaSiswa;
            this.kelasSiswa = kelasSiswa;
            TampilkanNilaiSiswa();
        }

        private void TampilkanNilaiSiswa()
        {
            try
            {
                string query = "SELECT mapel.nama_mapel, nilai_siswa.nilai FROM nilai_siswa " +
                               "INNER JOIN mapel ON nilai_siswa.id_mapel = mapel.id_mapel " +
                               "WHERE nilai_siswa.nisn = @nisn";

                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@nisn", nisnSiswa);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    foreach (DataRow row in dt.Rows)
                    {
                        string namaMapel = row["nama_mapel"].ToString();
                        int nilai = Convert.ToInt32(row["nilai"]);

                        // Menambahkan progress bar untuk setiap nilai
                        ProgressBar progressBar = new ProgressBar();
                        progressBar.Name = "progressBar_" + namaMapel;
                        progressBar.Width = 300;
                        progressBar.Height = 30;
                        progressBar.Maximum = 100;
                        progressBar.Value = nilai;

                        // Menentukan warna berdasarkan nilai
                        if (nilai < 50)
                            progressBar.ForeColor = Color.Red;
                        else
                            progressBar.ForeColor = Color.Green;

                        // Membuat label untuk nama mata pelajaran
                        Label labelMapel = new Label();
                        labelMapel.Text = namaMapel;
                        labelMapel.AutoSize = true;
                        labelMapel.Font = new Font("Arial", 12, FontStyle.Bold);
                        labelMapel.Margin = new Padding(0, 10, 0, 0);

                        // Menambahkan ke flowLayoutPanel
                        flowLayoutPanel.Controls.Add(labelMapel);
                        flowLayoutPanel.Controls.Add(progressBar);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            FormHome formHome = new FormHome(nisnSiswa, namaSiswa, kelasSiswa);
            formHome.Show();
            this.Close();
        }
    }
}
