namespace Brenius
{
    partial class FormLoginGuru
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLoginGuru));
            label1 = new Label();
            PanelLoginGuru = new Panel();
            btn_back = new Button();
            btn_login_guru = new Button();
            nip = new TextBox();
            label3 = new Label();
            label2 = new Label();
            nama_guru = new TextBox();
            PanelLoginGuru.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("All the Way to the Sun", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(284, 50);
            label1.Name = "label1";
            label1.Size = new Size(236, 67);
            label1.TabIndex = 2;
            label1.Text = "BRENIUS";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // PanelLoginGuru
            // 
            PanelLoginGuru.Anchor = AnchorStyles.None;
            PanelLoginGuru.BackColor = Color.LightBlue;
            PanelLoginGuru.Controls.Add(btn_back);
            PanelLoginGuru.Controls.Add(btn_login_guru);
            PanelLoginGuru.Controls.Add(nip);
            PanelLoginGuru.Controls.Add(label3);
            PanelLoginGuru.Controls.Add(label2);
            PanelLoginGuru.Controls.Add(nama_guru);
            PanelLoginGuru.Location = new Point(150, 137);
            PanelLoginGuru.Name = "PanelLoginGuru";
            PanelLoginGuru.Size = new Size(500, 358);
            PanelLoginGuru.TabIndex = 3;
            // 
            // btn_back
            // 
            btn_back.BackColor = Color.Green;
            btn_back.Font = new Font("Bebas Neue", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_back.ForeColor = SystemColors.ButtonHighlight;
            btn_back.Location = new Point(23, 305);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(92, 32);
            btn_back.TabIndex = 6;
            btn_back.Text = "Back";
            btn_back.UseVisualStyleBackColor = false;
            btn_back.Click += btn_back_Click;
            // 
            // btn_login_guru
            // 
            btn_login_guru.BackColor = Color.RoyalBlue;
            btn_login_guru.Font = new Font("Bebas Neue", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_login_guru.ForeColor = SystemColors.ButtonHighlight;
            btn_login_guru.Location = new Point(198, 221);
            btn_login_guru.Name = "btn_login_guru";
            btn_login_guru.Size = new Size(92, 32);
            btn_login_guru.TabIndex = 4;
            btn_login_guru.Text = "Login";
            btn_login_guru.UseVisualStyleBackColor = false;
            btn_login_guru.Click += btn_login_guru_Click;
            // 
            // nip
            // 
            nip.Font = new Font("Bebas Neue", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nip.Location = new Point(103, 160);
            nip.Name = "nip";
            nip.Size = new Size(281, 27);
            nip.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Bebas Neue", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(103, 138);
            label3.Name = "label3";
            label3.Size = new Size(25, 19);
            label3.TabIndex = 2;
            label3.Text = "NIP";
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
            // nama_guru
            // 
            nama_guru.Font = new Font("Bebas Neue", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nama_guru.Location = new Point(103, 93);
            nama_guru.Name = "nama_guru";
            nama_guru.Size = new Size(281, 27);
            nama_guru.TabIndex = 0;
            // 
            // FormLoginGuru
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(800, 536);
            Controls.Add(PanelLoginGuru);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormLoginGuru";
            Text = "Brenius";
            WindowState = FormWindowState.Maximized;
            PanelLoginGuru.ResumeLayout(false);
            PanelLoginGuru.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel PanelLoginGuru;
        private Button btn_login_guru;
        private TextBox nip;
        private Label label3;
        private Label label2;
        private TextBox nama_guru;
        private Button btn_back;
    }
}