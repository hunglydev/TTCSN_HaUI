﻿namespace QLSKwinform.Admin.SuKien
{
    partial class SuKienChuaDuyet
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
            this.dgvSuKienChuaDuyet = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuKienChuaDuyet)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSuKienChuaDuyet
            // 
            this.dgvSuKienChuaDuyet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSuKienChuaDuyet.Location = new System.Drawing.Point(62, 201);
            this.dgvSuKienChuaDuyet.Name = "dgvSuKienChuaDuyet";
            this.dgvSuKienChuaDuyet.RowHeadersWidth = 51;
            this.dgvSuKienChuaDuyet.RowTemplate.Height = 24;
            this.dgvSuKienChuaDuyet.Size = new System.Drawing.Size(1364, 354);
            this.dgvSuKienChuaDuyet.TabIndex = 1;
            this.dgvSuKienChuaDuyet.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSuKienChuaDuyet_CellClick);
            this.dgvSuKienChuaDuyet.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBaoTriSuKien_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(540, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "CÁC SỰ KIỆN CHƯA DUYỆT";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(545, 617);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(273, 54);
            this.button1.TabIndex = 3;
            this.button1.Text = "Trở lại";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SuKienChuaDuyet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1471, 735);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvSuKienChuaDuyet);
            this.Name = "SuKienChuaDuyet";
            this.Text = "SuKienChuaDuyet";
            this.Load += new System.EventHandler(this.SuKienChuaDuyet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuKienChuaDuyet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSuKienChuaDuyet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}