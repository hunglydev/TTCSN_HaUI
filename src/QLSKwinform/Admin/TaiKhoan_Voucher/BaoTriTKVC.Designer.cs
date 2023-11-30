namespace QLSKwinform.Admin.TaiKhoan_Voucher
{
    partial class BaoTriTKVC
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
            this.dgvTKVC = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTKVC)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(217, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(455, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "THÔNG TIN CÁC TÀI KHOẢN VÀ VOUCHER";
            // 
            // dgvTKVC
            // 
            this.dgvTKVC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTKVC.Location = new System.Drawing.Point(287, 126);
            this.dgvTKVC.Name = "dgvTKVC";
            this.dgvTKVC.RowHeadersWidth = 51;
            this.dgvTKVC.RowTemplate.Height = 24;
            this.dgvTKVC.Size = new System.Drawing.Size(336, 269);
            this.dgvTKVC.TabIndex = 6;
            this.dgvTKVC.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTKVC_CellClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(135, 461);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 61);
            this.button1.TabIndex = 7;
            this.button1.Text = "Trở lại";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(387, 461);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(160, 61);
            this.button2.TabIndex = 8;
            this.button2.Text = "Thêm";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(644, 464);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(160, 61);
            this.button3.TabIndex = 9;
            this.button3.Text = "Xóa";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // BaoTriTKVC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QLSKwinform.Properties.Resources.vou;
            this.ClientSize = new System.Drawing.Size(915, 554);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvTKVC);
            this.Controls.Add(this.label1);
            this.Name = "BaoTriTKVC";
            this.Text = "BaoTriTKVC";
            this.Load += new System.EventHandler(this.BaoTriTKVC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTKVC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvTKVC;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}