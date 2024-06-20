namespace Brenius
{
    partial class FormNilai
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNilai));
            dataGridViewNilai = new DataGridView();
            btn_delete = new Button();
            btn_back = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewNilai).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewNilai
            // 
            dataGridViewNilai.BackgroundColor = Color.RoyalBlue;
            dataGridViewNilai.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewNilai.Location = new Point(12, 50);
            dataGridViewNilai.Name = "dataGridViewNilai";
            dataGridViewNilai.Size = new Size(776, 350);
            dataGridViewNilai.TabIndex = 0;
            // 
            // btn_delete
            // 
            btn_delete.BackColor = Color.Red;
            btn_delete.Font = new Font("Bebas Neue", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_delete.ForeColor = SystemColors.ButtonHighlight;
            btn_delete.Location = new Point(12, 420);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(75, 23);
            btn_delete.TabIndex = 1;
            btn_delete.Text = "Delete";
            btn_delete.UseVisualStyleBackColor = false;
            btn_delete.Click += btn_delete_Click;
            // 
            // btn_back
            // 
            btn_back.BackColor = Color.SeaGreen;
            btn_back.Font = new Font("Bebas Neue", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_back.ForeColor = SystemColors.ButtonHighlight;
            btn_back.Location = new Point(713, 420);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(75, 23);
            btn_back.TabIndex = 2;
            btn_back.Text = "Kembali";
            btn_back.UseVisualStyleBackColor = false;
            btn_back.Click += btn_back_Click;
            // 
            // FormNilai
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_back);
            Controls.Add(btn_delete);
            Controls.Add(dataGridViewNilai);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormNilai";
            Text = "Brenius";
            WindowState = FormWindowState.Maximized;
            Load += FormNilai_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewNilai).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewNilai;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_back;
    }
}
