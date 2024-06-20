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
    public partial class FormHomeGuru : Form
    {
        private string namaGuru;
        private string mapelGuru;
        private string nipGuru;

        public FormHomeGuru(string nipGuru, string namaGuru, string mapelGuru)
        {
            InitializeComponent();
            this.nipGuru = nipGuru;
            this.namaGuru = namaGuru;
            this.mapelGuru = mapelGuru;
            label_nama.Text = namaGuru;
            label_mapel.Text = mapelGuru;
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            FormPilihan formPilihan = new FormPilihan();
            formPilihan.Show();
            this.Close();
        }

        private void btn_kuis_Click(object sender, EventArgs e)
        {
            FormKuis formKuis = new FormKuis(nipGuru, namaGuru, mapelGuru);
            formKuis.Show();
            this.Close();
        }

        private void btn_nilai_Click(object sender, EventArgs e)
        {
            FormNilai formNilai = new FormNilai(nipGuru, namaGuru, mapelGuru);
            formNilai.Show();
            this.Close();
        }
    }
}
