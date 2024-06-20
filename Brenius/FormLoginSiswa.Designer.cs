namespace Brenius
{
    partial class FormLoginSiswa
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLoginSiswa));
            PanelLoginSiswa = new Panel();
            btn_back = new Button();
            btn_login_siswa = new Button();
            nisn = new TextBox();
            label3 = new Label();
            label2 = new Label();
            nama_siswa = new TextBox();
            label1 = new Label();
            PanelLoginSiswa.SuspendLayout();
            SuspendLayout();
            // 
            // PanelLoginSiswa
            // 
            PanelLoginSiswa.Anchor = AnchorStyles.None;
            PanelLoginSiswa.BackColor = Color.LightBlue;
            PanelLoginSiswa.Controls.Add(btn_back);
            PanelLoginSiswa.Controls.Add(btn_login_siswa);
            PanelLoginSiswa.Controls.Add(nisn);
            PanelLoginSiswa.Controls.Add(label3);
            PanelLoginSiswa.Controls.Add(label2);
            PanelLoginSiswa.Controls.Add(nama_siswa);
            PanelLoginSiswa.Location = new Point(139, 82);
            PanelLoginSiswa.Name = "PanelLoginSiswa";
            PanelLoginSiswa.Size = new Size(500, 358);
            PanelLoginSiswa.TabIndex = 0;
            // 
            // btn_back
            // 
            btn_back.BackColor = Color.Green;
            btn_back.Font = new Font("Bebas Neue", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_back.ForeColor = SystemColors.ButtonHighlight;
            btn_back.Location = new Point(23, 307);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(92, 32);
            btn_back.TabIndex = 5;
            btn_back.Text = "Back";
            btn_back.UseVisualStyleBackColor = false;
            btn_back.Click += btn_back_Click;
            // 
            // btn_login_siswa
            // 
            btn_login_siswa.BackColor = Color.RoyalBlue;
            btn_login_siswa.Font = new Font("Bebas Neue", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_login_siswa.ForeColor = SystemColors.ButtonHighlight;
            btn_login_siswa.Location = new Point(198, 221);
            btn_login_siswa.Name = "btn_login_siswa";
            btn_login_siswa.Size = new Size(92, 32);
            btn_login_siswa.TabIndex = 4;
            btn_login_siswa.Text = "Login";
            btn_login_siswa.UseVisualStyleBackColor = false;
            btn_login_siswa.Click += btn_login_siswa_Click;
            // 
            // nisn
            // 
            nisn.Font = new Font("Bebas Neue", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nisn.Location = new Point(103, 160);
            nisn.Name = "nisn";
            nisn.Size = new Size(281, 27);
            nisn.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Bebas Neue", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(103, 138);
            label3.Name = "label3";
            label3.Size = new Size(32, 19);
            label3.TabIndex = 2;
            label3.Text = "NISN";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Bebas Neue", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(103, 71);
            label2.Name = "label2";
            label2.Size = new Size(84, 19);
            label2.TabIndex = 1;
            label2.Text = "Nama Lengkap";
            // 
            // nama_siswa
            // 
            nama_siswa.Font = new Font("Bebas Neue", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nama_siswa.Location = new Point(103, 93);
            nama_siswa.Name = "nama_siswa";
            nama_siswa.Size = new Size(281, 27);
            nama_siswa.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("All the Way to the Sun", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(263, 12);
            label1.Name = "label1";
            label1.Size = new Size(236, 67);
            label1.TabIndex = 1;
            label1.Text = "BRENIUS";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FormLoginSiswa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(800, 521);
            Controls.Add(label1);
            Controls.Add(PanelLoginSiswa);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormLoginSiswa";
            Text = "Brenius";
            WindowState = FormWindowState.Maximized;
            Load += FormLoginSiswa_Load;
            PanelLoginSiswa.ResumeLayout(false);
            PanelLoginSiswa.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel PanelLoginSiswa;
        private Label label1;
        private TextBox nama_siswa;
        private Label label2;
        private TextBox nisn;
        private Label label3;
        private Button btn_login_siswa;
        private Button btn_back;
    }
}
