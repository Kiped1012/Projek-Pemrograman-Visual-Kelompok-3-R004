namespace Brenius
{
    partial class FormSoal
    {
        private System.ComponentModel.IContainer components = null;

        private Label lbl_pertanyaan;
        private TextBox txt_jawaban;
        private Button btn_kumpulkan;
        private Button btn_soal_selanjutnya;
        private Button btn_back;
        private Label lbl_nilai;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify the
        /// contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSoal));
            lbl_pertanyaan = new Label();
            txt_jawaban = new TextBox();
            btn_kumpulkan = new Button();
            btn_soal_selanjutnya = new Button();
            btn_back = new Button();
            lbl_nilai = new Label();
            panel1 = new Panel();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lbl_pertanyaan
            // 
            lbl_pertanyaan.AutoSize = true;
            lbl_pertanyaan.Font = new Font("Bebas Neue", 20.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_pertanyaan.Location = new Point(50, 178);
            lbl_pertanyaan.Name = "lbl_pertanyaan";
            lbl_pertanyaan.Size = new Size(121, 32);
            lbl_pertanyaan.TabIndex = 0;
            lbl_pertanyaan.Text = "Pertanyaan";
            // 
            // txt_jawaban
            // 
            txt_jawaban.Font = new Font("Bebas Neue", 20.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_jawaban.Location = new Point(50, 228);
            txt_jawaban.Multiline = true;
            txt_jawaban.Name = "txt_jawaban";
            txt_jawaban.Size = new Size(700, 150);
            txt_jawaban.TabIndex = 1;
            // 
            // btn_kumpulkan
            // 
            btn_kumpulkan.BackColor = Color.RoyalBlue;
            btn_kumpulkan.Enabled = false;
            btn_kumpulkan.Font = new Font("Bebas Neue", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_kumpulkan.ForeColor = SystemColors.ButtonHighlight;
            btn_kumpulkan.Location = new Point(50, 398);
            btn_kumpulkan.Name = "btn_kumpulkan";
            btn_kumpulkan.Size = new Size(150, 40);
            btn_kumpulkan.TabIndex = 2;
            btn_kumpulkan.Text = "Kumpulkan";
            btn_kumpulkan.UseVisualStyleBackColor = false;
            btn_kumpulkan.Click += btn_kumpulkan_Click;
            // 
            // btn_soal_selanjutnya
            // 
            btn_soal_selanjutnya.BackColor = Color.RoyalBlue;
            btn_soal_selanjutnya.Font = new Font("Bebas Neue", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_soal_selanjutnya.ForeColor = SystemColors.ButtonHighlight;
            btn_soal_selanjutnya.Location = new Point(220, 398);
            btn_soal_selanjutnya.Name = "btn_soal_selanjutnya";
            btn_soal_selanjutnya.Size = new Size(150, 40);
            btn_soal_selanjutnya.TabIndex = 3;
            btn_soal_selanjutnya.Text = "Soal Selanjutnya";
            btn_soal_selanjutnya.UseVisualStyleBackColor = false;
            btn_soal_selanjutnya.Click += btn_soal_selanjutnya_Click;
            // 
            // btn_back
            // 
            btn_back.BackColor = Color.MediumSeaGreen;
            btn_back.Font = new Font("Bebas Neue", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_back.ForeColor = SystemColors.ButtonHighlight;
            btn_back.Location = new Point(600, 398);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(150, 40);
            btn_back.TabIndex = 4;
            btn_back.Text = "Kembali";
            btn_back.UseVisualStyleBackColor = false;
            btn_back.Click += btn_back_Click;
            // 
            // lbl_nilai
            // 
            lbl_nilai.AutoSize = true;
            lbl_nilai.Font = new Font("Bebas Neue", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_nilai.Location = new Point(50, 458);
            lbl_nilai.Name = "lbl_nilai";
            lbl_nilai.Size = new Size(66, 35);
            lbl_nilai.TabIndex = 5;
            lbl_nilai.Text = "Nilai";
            // 
            // panel1
            // 
            panel1.BackColor = Color.RoyalBlue;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 140);
            panel1.TabIndex = 6;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Bebas Neue", 47.9999924F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(346, 36);
            label1.Name = "label1";
            label1.Size = new Size(123, 77);
            label1.TabIndex = 0;
            label1.Text = "KUIS";
            // 
            // FormSoal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(800, 533);
            Controls.Add(panel1);
            Controls.Add(lbl_nilai);
            Controls.Add(btn_back);
            Controls.Add(btn_soal_selanjutnya);
            Controls.Add(btn_kumpulkan);
            Controls.Add(txt_jawaban);
            Controls.Add(lbl_pertanyaan);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormSoal";
            Text = "Brenius";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
    }
}
