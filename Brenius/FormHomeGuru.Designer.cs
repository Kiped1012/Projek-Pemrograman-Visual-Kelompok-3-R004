namespace Brenius
{
    partial class FormHomeGuru
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHomeGuru));
            panel1 = new Panel();
            btn_logout = new Button();
            pictureBox2 = new PictureBox();
            label_mapel = new Label();
            label_nama = new Label();
            label2 = new Label();
            btn_kuis = new Button();
            btn_nilai = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.RoyalBlue;
            panel1.Controls.Add(btn_logout);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(label_mapel);
            panel1.Controls.Add(label_nama);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1030, 235);
            panel1.TabIndex = 0;
            // 
            // btn_logout
            // 
            btn_logout.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_logout.BackColor = Color.Red;
            btn_logout.Font = new Font("Bebas Neue", 20.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_logout.ForeColor = SystemColors.ButtonHighlight;
            btn_logout.Location = new Point(901, 21);
            btn_logout.Name = "btn_logout";
            btn_logout.Size = new Size(102, 40);
            btn_logout.TabIndex = 7;
            btn_logout.Text = "logout";
            btn_logout.UseVisualStyleBackColor = false;
            btn_logout.Click += btn_logout_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.None;
            pictureBox2.BackgroundImageLayout = ImageLayout.None;
            pictureBox2.Image = Properties.Resources.image_7;
            pictureBox2.Location = new Point(635, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(229, 219);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // label_mapel
            // 
            label_mapel.AutoSize = true;
            label_mapel.Font = new Font("Bebas Neue", 20.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_mapel.ForeColor = SystemColors.ButtonHighlight;
            label_mapel.Location = new Point(21, 53);
            label_mapel.Name = "label_mapel";
            label_mapel.Size = new Size(29, 32);
            label_mapel.TabIndex = 4;
            label_mapel.Text = " k";
            // 
            // label_nama
            // 
            label_nama.AutoSize = true;
            label_nama.Font = new Font("Bebas Neue", 20.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_nama.ForeColor = SystemColors.ButtonHighlight;
            label_nama.Location = new Point(21, 21);
            label_nama.Name = "label_nama";
            label_nama.Size = new Size(29, 32);
            label_nama.TabIndex = 3;
            label_nama.Text = " k";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Bebas Neue", 47.9999924F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(278, 38);
            label2.Name = "label2";
            label2.Size = new Size(374, 154);
            label2.TabIndex = 1;
            label2.Text = "SELAMAT DATANG\r\nDI BRENIUS";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btn_kuis
            // 
            btn_kuis.Anchor = AnchorStyles.None;
            btn_kuis.AutoSize = true;
            btn_kuis.BackColor = Color.RoyalBlue;
            btn_kuis.Font = new Font("Bebas Neue", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_kuis.ForeColor = SystemColors.ButtonHighlight;
            btn_kuis.Image = Properties.Resources._1718203878162;
            btn_kuis.Location = new Point(269, 379);
            btn_kuis.Margin = new Padding(3, 10, 3, 10);
            btn_kuis.Name = "btn_kuis";
            btn_kuis.Padding = new Padding(10, 0, 10, 0);
            btn_kuis.Size = new Size(224, 222);
            btn_kuis.TabIndex = 3;
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
            btn_nilai.Location = new Point(540, 379);
            btn_nilai.Margin = new Padding(3, 10, 3, 10);
            btn_nilai.Name = "btn_nilai";
            btn_nilai.Padding = new Padding(10, 0, 10, 0);
            btn_nilai.Size = new Size(224, 222);
            btn_nilai.TabIndex = 4;
            btn_nilai.Text = "NILAI";
            btn_nilai.TextAlign = ContentAlignment.BottomCenter;
            btn_nilai.UseVisualStyleBackColor = false;
            btn_nilai.Click += btn_nilai_Click;
            // 
            // FormHomeGuru
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(1030, 749);
            Controls.Add(btn_nilai);
            Controls.Add(btn_kuis);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormHomeGuru";
            Text = "Brenius";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label_mapel;
        private Label label_nama;
        private PictureBox pictureBox2;
        private Button btn_logout;
        private Button btn_kuis;
        private Button btn_nilai;
    }
}