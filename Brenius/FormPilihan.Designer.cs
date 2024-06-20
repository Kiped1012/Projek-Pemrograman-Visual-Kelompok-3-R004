namespace Brenius
{
    partial class FormPilihan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPilihan));
            label1 = new Label();
            btn_siswa = new Button();
            btn_guru = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("All the Way to the Sun", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(219, 65);
            label1.Name = "label1";
            label1.Size = new Size(395, 67);
            label1.TabIndex = 0;
            label1.Text = "LOGIN SEBAGAI";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // btn_siswa
            // 
            btn_siswa.Anchor = AnchorStyles.None;
            btn_siswa.AutoSize = true;
            btn_siswa.BackColor = Color.RoyalBlue;
            btn_siswa.Font = new Font("All the Way to the Sun", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_siswa.ForeColor = SystemColors.ButtonHighlight;
            btn_siswa.Image = (Image)resources.GetObject("btn_siswa.Image");
            btn_siswa.Location = new Point(136, 203);
            btn_siswa.Name = "btn_siswa";
            btn_siswa.Size = new Size(236, 236);
            btn_siswa.TabIndex = 1;
            btn_siswa.Text = "SISWA";
            btn_siswa.TextAlign = ContentAlignment.BottomCenter;
            btn_siswa.UseVisualStyleBackColor = false;
            btn_siswa.Click += btn_siswa_Click;
            // 
            // btn_guru
            // 
            btn_guru.Anchor = AnchorStyles.None;
            btn_guru.AutoSize = true;
            btn_guru.BackColor = Color.RoyalBlue;
            btn_guru.Font = new Font("All the Way to the Sun", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_guru.ForeColor = SystemColors.ButtonHighlight;
            btn_guru.Image = (Image)resources.GetObject("btn_guru.Image");
            btn_guru.Location = new Point(449, 203);
            btn_guru.Name = "btn_guru";
            btn_guru.Size = new Size(236, 236);
            btn_guru.TabIndex = 2;
            btn_guru.Text = "GURU";
            btn_guru.TextAlign = ContentAlignment.BottomCenter;
            btn_guru.UseVisualStyleBackColor = false;
            btn_guru.Click += btn_guru_Click;
            // 
            // FormPilihan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(838, 522);
            Controls.Add(btn_guru);
            Controls.Add(btn_siswa);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormPilihan";
            Text = "Brenius";
            WindowState = FormWindowState.Maximized;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btn_siswa;
        private Button btn_guru;
    }
}