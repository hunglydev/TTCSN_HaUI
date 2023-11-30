namespace QLSKwinform.Admin.SuKien
{
    partial class BaoTriSuKien
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
            this.dgvBaoTriSuKien = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaoTriSuKien)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBaoTriSuKien
            // 
            this.dgvBaoTriSuKien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBaoTriSuKien.Location = new System.Drawing.Point(90, 186);
            this.dgvBaoTriSuKien.Name = "dgvBaoTriSuKien";
            this.dgvBaoTriSuKien.RowHeadersWidth = 51;
            this.dgvBaoTriSuKien.RowTemplate.Height = 24;
            this.dgvBaoTriSuKien.Size = new System.Drawing.Size(1364, 354);
            this.dgvBaoTriSuKien.TabIndex = 0;
            this.dgvBaoTriSuKien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBaoTriSuKien_CellClick);
            this.dgvBaoTriSuKien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBaoTriSuKien_CellContentClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(236, 587);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(273, 54);
            this.button1.TabIndex = 1;
            this.button1.Text = "Trở lại";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(1031, 587);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(273, 54);
            this.button3.TabIndex = 2;
            this.button3.Text = "Các sự kiện chưa duyệt";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(579, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(334, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "CÁC SỰ KIỆN ĐÃ ĐƯỢC DUYỆT";
            // 
            // BaoTriSuKien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QLSKwinform.Properties.Resources.dia_diem_khach_san_to_chuc_su_kien_intercontinental_Hanoi_Landmark721;
            this.ClientSize = new System.Drawing.Size(1553, 838);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvBaoTriSuKien);
            this.Name = "BaoTriSuKien";
            this.Text = "BaoTriSuKien";
            this.Load += new System.EventHandler(this.BaoTriSuKien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaoTriSuKien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBaoTriSuKien;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
    }
}