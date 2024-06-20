namespace Brenius
{
    partial class FormKuis
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormKuis));
            txt_soal = new TextBox();
            txt_jawaban = new TextBox();
            txt_id_soal = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btn_buat = new Button();
            btn_update = new Button();
            btn_delete = new Button();
            btn_back = new Button();
            dataGridViewSoal = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSoal).BeginInit();
            SuspendLayout();
            // 
            // txt_soal
            // 
            txt_soal.BackColor = Color.RoyalBlue;
            txt_soal.Font = new Font("Bebas Neue", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_soal.ForeColor = SystemColors.ButtonHighlight;
            txt_soal.Location = new Point(30, 40);
            txt_soal.Multiline = true;
            txt_soal.Name = "txt_soal";
            txt_soal.Size = new Size(500, 100);
            txt_soal.TabIndex = 0;
            // 
            // txt_jawaban
            // 
            txt_jawaban.BackColor = Color.RoyalBlue;
            txt_jawaban.Font = new Font("Bebas Neue", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_jawaban.ForeColor = SystemColors.ButtonHighlight;
            txt_jawaban.Location = new Point(30, 180);
            txt_jawaban.Name = "txt_jawaban";
            txt_jawaban.Size = new Size(500, 27);
            txt_jawaban.TabIndex = 1;
            // 
            // txt_id_soal
            // 
            txt_id_soal.BackColor = Color.RoyalBlue;
            txt_id_soal.Font = new Font("Bebas Neue", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_id_soal.ForeColor = SystemColors.ButtonHighlight;
            txt_id_soal.Location = new Point(30, 250);
            txt_id_soal.Name = "txt_id_soal";
            txt_id_soal.Size = new Size(100, 27);
            txt_id_soal.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bebas Neue", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(30, 20);
            label1.Name = "label1";
            label1.Size = new Size(36, 19);
            label1.TabIndex = 3;
            label1.Text = "Soal:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bebas Neue", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(30, 160);
            label2.Name = "label2";
            label2.Size = new Size(56, 19);
            label2.TabIndex = 4;
            label2.Text = "Jawaban:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bebas Neue", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(30, 230);
            label3.Name = "label3";
            label3.Size = new Size(49, 19);
            label3.TabIndex = 5;
            label3.Text = "ID Soal:";
            // 
            // btn_buat
            // 
            btn_buat.BackColor = Color.Purple;
            btn_buat.Font = new Font("Bebas Neue", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_buat.ForeColor = SystemColors.ButtonHighlight;
            btn_buat.Location = new Point(30, 290);
            btn_buat.Name = "btn_buat";
            btn_buat.Size = new Size(75, 23);
            btn_buat.TabIndex = 6;
            btn_buat.Text = "Buat";
            btn_buat.UseVisualStyleBackColor = false;
            btn_buat.Click += btn_buat_Click;
            // 
            // btn_update
            // 
            btn_update.BackColor = Color.Orange;
            btn_update.Font = new Font("Bebas Neue", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_update.ForeColor = SystemColors.ButtonHighlight;
            btn_update.Location = new Point(120, 290);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(75, 23);
            btn_update.TabIndex = 7;
            btn_update.Text = "Update";
            btn_update.UseVisualStyleBackColor = false;
            btn_update.Click += btn_update_Click;
            // 
            // btn_delete
            // 
            btn_delete.BackColor = Color.Red;
            btn_delete.Font = new Font("Bebas Neue", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_delete.ForeColor = SystemColors.ButtonHighlight;
            btn_delete.Location = new Point(210, 290);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(75, 23);
            btn_delete.TabIndex = 8;
            btn_delete.Text = "Delete";
            btn_delete.UseVisualStyleBackColor = false;
            btn_delete.Click += btn_delete_Click;
            // 
            // btn_back
            // 
            btn_back.BackColor = Color.MediumSeaGreen;
            btn_back.Font = new Font("Bebas Neue", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_back.ForeColor = SystemColors.ButtonHighlight;
            btn_back.Location = new Point(30, 330);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(75, 23);
            btn_back.TabIndex = 9;
            btn_back.Text = "Back";
            btn_back.UseVisualStyleBackColor = false;
            btn_back.Click += btn_back_Click;
            // 
            // dataGridViewSoal
            // 
            dataGridViewSoal.BackgroundColor = Color.RoyalBlue;
            dataGridViewSoal.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSoal.Location = new Point(30, 370);
            dataGridViewSoal.Name = "dataGridViewSoal";
            dataGridViewSoal.Size = new Size(500, 200);
            dataGridViewSoal.TabIndex = 10;
            // 
            // FormKuis
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(800, 600);
            Controls.Add(dataGridViewSoal);
            Controls.Add(btn_back);
            Controls.Add(btn_delete);
            Controls.Add(btn_update);
            Controls.Add(btn_buat);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txt_id_soal);
            Controls.Add(txt_jawaban);
            Controls.Add(txt_soal);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormKuis";
            Text = "Brenius";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)dataGridViewSoal).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txt_soal;
        private System.Windows.Forms.TextBox txt_jawaban;
        private System.Windows.Forms.TextBox txt_id_soal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_buat;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.DataGridView dataGridViewSoal;
    }
}
