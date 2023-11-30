namespace QLSKwinform
{
    partial class BaoTriTaiKhoan
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgvTaiKhoan = new System.Windows.Forms.DataGridView();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnTroLai = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaiKhoan)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(444, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "DANH SÁCH TÀI KHOẢN";
            // 
            // dgvTaiKhoan
            // 
            this.dgvTaiKhoan.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dgvTaiKhoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTaiKhoan.Location = new System.Drawing.Point(177, 239);
            this.dgvTaiKhoan.Name = "dgvTaiKhoan";
            this.dgvTaiKhoan.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgvTaiKhoan.RowHeadersWidth = 51;
            this.dgvTaiKhoan.RowTemplate.Height = 24;
            this.dgvTaiKhoan.Size = new System.Drawing.Size(883, 196);
            this.dgvTaiKhoan.TabIndex = 1;
            this.dgvTaiKhoan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTaiKhoan_CellClick);
            this.dgvTaiKhoan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(737, 577);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(169, 51);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "Thêm tài khoản";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnTroLai
            // 
            this.btnTroLai.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnTroLai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTroLai.Location = new System.Drawing.Point(262, 577);
            this.btnTroLai.Name = "btnTroLai";
            this.btnTroLai.Size = new System.Drawing.Size(169, 51);
            this.btnTroLai.TabIndex = 3;
            this.btnTroLai.Text = "Trở lại";
            this.btnTroLai.UseVisualStyleBackColor = false;
            this.btnTroLai.Click += new System.EventHandler(this.btnTroLai_Click);
            // 
            // BaoTriTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QLSKwinform.Properties.Resources.kenny_krosky_2xjk8WWLFC4_unsplash;
            this.ClientSize = new System.Drawing.Size(1199, 674);
            this.Controls.Add(this.btnTroLai);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dgvTaiKhoan);
            this.Controls.Add(this.label1);
            this.Name = "BaoTriTaiKhoan";
            this.Text = "BaoTriTaiKhoan";
            this.Load += new System.EventHandler(this.BaoTriTaiKhoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaiKhoan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvTaiKhoan;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnTroLai;
    }
}