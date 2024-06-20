namespace Brenius
{
    partial class FormHome
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHome));
            btn_kuis = new Button();
            btn_nilai = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            panel2 = new Panel();
            btn_logout = new Button();
            label_kelas = new Label();
            label3 = new Label();
            label_nama = new Label();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            btn_materi = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // btn_kuis
            // 
            btn_kuis.Anchor = AnchorStyles.None;
            btn_kuis.AutoSize = true;
            btn_kuis.BackColor = Color.RoyalBlue;
            btn_kuis.Font = new Font("Bebas Neue", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_kuis.ForeColor = SystemColors.ButtonHighlight;
            btn_kuis.Image = Properties.Resources._1718203878162;
            btn_kuis.Location = new Point(422, 255);
            btn_kuis.Margin = new Padding(3, 10, 3, 10);
            btn_kuis.Name = "btn_kuis";
            btn_kuis.Padding = new Padding(10, 0, 10, 0);
            btn_kuis.Size = new Size(224, 222);
            btn_kuis.TabIndex = 2;
            btn_kuis.Text = "KUIS";
            btn_kuis.TextAlign = ContentAlignment.BottomCenter;
            btn_kuis.UseVisualStyleBackColor = false;
            btn_kuis.Click += btn_kuis_Click;
            // 
            // btn_nilai
            // 
            btn_nilai.Anchor = AnchorStyles.None;
            btn_nilai.AutoSize = true;
            btn_nilai.BackColor = Color.RoyalBlue;
            btn_nilai.Font = new Font("Bebas Neue", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_nilai.ForeColor = SystemColors.ButtonHighlight;
            btn_nilai.Image = Properties.Resources.clipart3413602;
            btn_nilai.Location = new Point(683, 255);
            btn_nilai.Margin = new Padding(3, 10, 3, 10);
            btn_nilai.Name = "btn_nilai";
            btn_nilai.Padding = new Padding(10, 0, 10, 0);
            btn_nilai.Size = new Size(224, 222);
            btn_nilai.TabIndex = 3;
            btn_nilai.Text = "NILAI";
            btn_nilai.TextAlign = ContentAlignment.BottomCenter;
            btn_nilai.UseVisualStyleBackColor = false;
            btn_nilai.Click += btn_nilai_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Bebas Neue", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(288, -151);
            label1.Name = "label1";
            label1.Size = new Size(288, 114);
            label1.TabIndex = 0;
            label1.Text = "Selamat Datang\r\ndi brenius";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.image_7;
            pictureBox1.Location = new Point(573, -301);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(242, 216);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.BackColor = Color.RoyalBlue;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1089, 0);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.RoyalBlue;
            panel2.Controls.Add(btn_logout);
            panel2.Controls.Add(label_kelas);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label_nama);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1089, 205);
            panel2.TabIndex = 5;
            // 
            // btn_logout
            // 
            btn_logout.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_logout.BackColor = Color.Red;
            btn_logout.Font = new Font("Bebas Neue", 20.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_logout.ForeColor = SystemColors.ButtonHighlight;
            btn_logout.Location = new Point(962, 19);
            btn_logout.Name = "btn_logout";
            btn_logout.Size = new Size(102, 40);
            btn_logout.TabIndex = 6;
            btn_logout.Text = "logout";
            btn_logout.UseVisualStyleBackColor = false;
            btn_logout.Click += btn_logout_Click;
            // 
            // label_kelas
            // 
            label_kelas.AutoSize = true;
            label_kelas.Font = new Font("Bebas Neue", 20.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_kelas.ForeColor = SystemColors.ButtonHighlight;
            label_kelas.Location = new Point(75, 59);
            label_kelas.Name = "label_kelas";
            label_kelas.Size = new Size(29, 32);
            label_kelas.TabIndex = 4;
            label_kelas.Text = " k";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bebas Neue", 20.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(12, 59);
            label3.Name = "label3";
            label3.Size = new Size(69, 32);
            label3.TabIndex = 3;
            label3.Text = " kelas";
            // 
            // label_nama
            // 
            label_nama.AutoSize = true;
            label_nama.Font = new Font("Bebas Neue", 20.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_nama.ForeColor = SystemColors.ButtonHighlight;
            label_nama.Location = new Point(12, 27);
            label_nama.Name = "label_nama";
            label_nama.Size = new Size(29, 32);
            label_nama.TabIndex = 2;
            label_nama.Text = " k";
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.None;
            pictureBox2.BackgroundImageLayout = ImageLayout.None;
            pictureBox2.Image = Properties.Resources.image_7;
            pictureBox2.Location = new Point(689, -7);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(229, 219);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Bebas Neue", 47.9999924F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(331, 27);
            label2.Name = "label2";
            label2.Size = new Size(374, 154);
            label2.TabIndex = 0;
            label2.Text = "SELAMAT DATANG\r\nDI BRENIUS";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btn_materi
            // 
            btn_materi.Anchor = AnchorStyles.None;
            btn_materi.AutoSize = true;
            btn_materi.BackColor = Color.RoyalBlue;
            btn_materi.Font = new Font("Bebas Neue", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_materi.ForeColor = SystemColors.ButtonHighlight;
            btn_materi.Image = (Image)resources.GetObject("btn_materi.Image");
            btn_materi.Location = new Point(155, 255);
            btn_materi.Margin = new Padding(3, 10, 3, 10);
            btn_materi.Name = "btn_materi";
            btn_materi.Padding = new Padding(10, 0, 10, 0);
            btn_materi.Size = new Size(224, 222);
            btn_materi.TabIndex = 6;
            btn_materi.Text = "MATERI";
            btn_materi.TextAlign = ContentAlignment.BottomCenter;
            btn_materi.UseVisualStyleBackColor = false;
            btn_materi.Click += btn_materi_Click;
            // 
            // FormHome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(1089, 528);
            Controls.Add(btn_materi);
            Controls.Add(panel2);
            Controls.Add(btn_nilai);
            Controls.Add(btn_kuis);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormHome";
            Text = "Brenius";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btn_kuis;
        private Button btn_nilai;
        private Label label1;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Panel panel2;
        private Button btn_materi;
        private Label label_nama;
        private Label label_kelas;
        private Label label3;
        private Button btn_logout;
        private PictureBox pictureBox2;
        private Label label2;
    }
}