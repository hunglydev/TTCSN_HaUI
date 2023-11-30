namespace QLSKwinform
{
    partial class InforEvent
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnXoa = new System.Windows.Forms.Button();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.txtDiaDiem = new System.Windows.Forms.TextBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.txtTenSuKien = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAgree = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(341, 278);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(287, 22);
            this.dateTimePicker1.TabIndex = 26;
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(359, 423);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(115, 52);
            this.btnXoa.TabIndex = 25;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(338, 320);
            this.txtGhiChu.Multiline = true;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(292, 38);
            this.txtGhiChu.TabIndex = 24;
            // 
            // txtDiaDiem
            // 
            this.txtDiaDiem.Location = new System.Drawing.Point(341, 228);
            this.txtDiaDiem.Multiline = true;
            this.txtDiaDiem.Name = "txtDiaDiem";
            this.txtDiaDiem.Size = new System.Drawing.Size(288, 38);
            this.txtDiaDiem.TabIndex = 23;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(341, 180);
            this.txtSoLuong.Multiline = true;
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(289, 38);
            this.txtSoLuong.TabIndex = 22;
            // 
            // txtTenSuKien
            // 
            this.txtTenSuKien.Location = new System.Drawing.Point(343, 133);
            this.txtTenSuKien.Multiline = true;
            this.txtTenSuKien.Name = "txtTenSuKien";
            this.txtTenSuKien.Size = new System.Drawing.Size(288, 38);
            this.txtTenSuKien.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(128, 322);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 25);
            this.label5.TabIndex = 20;
            this.label5.Text = "Ghi chú";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(128, 275);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 25);
            this.label4.TabIndex = 19;
            this.label4.Text = "Thời gian";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(128, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 25);
            this.label3.TabIndex = 18;
            this.label3.Text = "Tên phòng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(128, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 25);
            this.label2.TabIndex = 17;
            this.label2.Text = "Số lượng khách";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(128, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 25);
            this.label1.TabIndex = 16;
            this.label1.Text = "Tên sự kiện";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(542, 423);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(127, 52);
            this.btnExit.TabIndex = 15;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAgree
            // 
            this.btnAgree.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAgree.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgree.Location = new System.Drawing.Point(131, 423);
            this.btnAgree.Name = "btnAgree";
            this.btnAgree.Size = new System.Drawing.Size(137, 45);
            this.btnAgree.TabIndex = 14;
            this.btnAgree.Text = "Đồng Ý";
            this.btnAgree.UseVisualStyleBackColor = false;
            this.btnAgree.Click += new System.EventHandler(this.btnAgree_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(286, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(256, 31);
            this.label6.TabIndex = 16;
            this.label6.Text = "THÔNG TIN SỰ KIỆN";
            // 
            // InforEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QLSKwinform.Properties.Resources.backxanh;
            this.ClientSize = new System.Drawing.Size(800, 493);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.txtGhiChu);
            this.Controls.Add(this.txtDiaDiem);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.txtTenSuKien);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAgree);
            this.Name = "InforEvent";
            this.Text = "InforEvent";
            this.Load += new System.EventHandler(this.InforEvent_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.TextBox txtDiaDiem;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.TextBox txtTenSuKien;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnAgree;
        private System.Windows.Forms.Label label6;
    }
}