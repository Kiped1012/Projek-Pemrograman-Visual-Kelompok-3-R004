using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Brenius
{
    public partial class FormHome : Form
    {
        private string namaSiswa;
        private string kelasSiswa;
        private string nisnSiswa;
        public FormHome(string nisnSiswa, string namaSiswa, string kelasSiswa)
        {
            InitializeComponent();
            this.namaSiswa = namaSiswa;
            this.kelasSiswa = kelasSiswa;
            this.nisnSiswa = nisnSiswa;
            // Ubah label_nama dan label_kelas dengan informasi yang diberikan
            label_nama.Text = namaSiswa;
            label_kelas.Text = kelasSiswa;
        }

        private void btn_materi_Click(object sender, EventArgs e)
        {
            // Membuat instance dari FormPilihanKuis dan menampilkannya
            FormPilihanMateri formPilihanMateri = new FormPilihanMateri(nisnSiswa, namaSiswa, kelasSiswa);
            formPilihanMateri.Show();

            // Menutup form saat ini
            this.Close();
        }

        private void btn_kuis_Click(object sender, EventArgs e)
        {
            // Membuat instance dari FormPilihanKuis dan menampilkannya
            FormPilihanKuis formPilihanKuis = new FormPilihanKuis(nisnSiswa, namaSiswa, kelasSiswa);
            formPilihanKuis.Show();

            // Menutup form saat ini
            this.Close();
        }

        private void btn_nilai_Click(object sender, EventArgs e)
        {
            FormNilaiSiswa formNilaiSiswa = new FormNilaiSiswa(nisnSiswa, namaSiswa, kelasSiswa);
            formNilaiSiswa.Show();
            this.Close();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            // Membuat instance dari FormPilihan dan menampilkannya
            FormPilihan formPilihan = new FormPilihan();
            formPilihan.Show();

            // Menutup form saat ini
            this.Close();
        }
    }
}
