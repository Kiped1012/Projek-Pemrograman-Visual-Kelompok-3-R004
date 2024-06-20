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
    public partial class FormPilihan : Form
    {
        public FormPilihan()
        {
            InitializeComponent();
        }

        private void btn_siswa_Click(object sender, EventArgs e)
        {
            // Membuat instance dari FormLoginSiswa dan menampilkannya
            FormLoginSiswa formLoginSiswa = new FormLoginSiswa();
            formLoginSiswa.Show();

            // Opsional, menyembunyikan atau menutup form saat ini
            this.Hide();
        }

        private void btn_guru_Click(object sender, EventArgs e)
        {
            // Membuat instance dari FormLoginGuru dan menampilkannya
            FormLoginGuru formLoginGuru = new FormLoginGuru();
            formLoginGuru.Show();

            // Opsional, menyembunyikan atau menutup form saat ini
            this.Hide();
        }
    }
}
