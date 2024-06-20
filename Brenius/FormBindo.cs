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
    public partial class FormBindo : Form
    {
        private string namaSiswa;
        private string kelasSiswa;
        private string nisnSiswa;
        public FormBindo(string nisnSiswa, string namaSiswa, string kelasSiswa)
        {
            InitializeComponent();
            this.namaSiswa = namaSiswa;
            this.kelasSiswa = kelasSiswa;
            this.nisnSiswa = nisnSiswa;
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            // Membuat instance dari FormHome dan menampilkannya
            FormPilihanMateri formPilihanMateri = new FormPilihanMateri(nisnSiswa, namaSiswa, kelasSiswa);
            formPilihanMateri.Show();

            // Menutup form saat ini
            this.Close();
        }
    }
}
