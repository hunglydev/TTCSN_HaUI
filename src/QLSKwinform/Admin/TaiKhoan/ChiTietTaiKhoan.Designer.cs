namespace QLSKwinform.Admin
{
    partial class ChiTietTaiKhoan
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMaTaiKhoan = new System.Windows.Forms.TextBox();
            this.txtTenTaiKhoan = new System.Windows.Forms.TextBox();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.txtTenNguoiChuTri = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.btnTroLai = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(127, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã tài khoản";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(127, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên tài khoản";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(127, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Mật khẩu";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(127, 323);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "Tên người chủ trì";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(127, 404);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 25);
            this.label5.TabIndex = 1;
            this.label5.Text = "Email";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(127, 480);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 25);
            this.label6.TabIndex = 1;
            this.label6.Text = "Số điện thoại";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtMaTaiKhoan
            // 
            this.txtMaTaiKhoan.Location = new System.Drawing.Point(323, 73);
            this.txtMaTaiKhoan.Multiline = true;
            this.txtMaTaiKhoan.Name = "txtMaTaiKhoan";
            this.txtMaTaiKhoan.Size = new System.Drawing.Size(279, 38);
            this.txtMaTaiKhoan.TabIndex = 2;
            this.txtMaTaiKhoan.TextChanged += new System.EventHandler(this.txtMaTaiKhoan_TextChanged);
            // 
            // txtTenTaiKhoan
            // 
            this.txtTenTaiKhoan.Location = new System.Drawing.Point(323, 153);
            this.txtTenTaiKhoan.Multiline = true;
            this.txtTenTaiKhoan.Name = "txtTenTaiKhoan";
            this.txtTenTaiKhoan.Size = new System.Drawing.Size(279, 38);
            this.txtTenTaiKhoan.TabIndex = 2;
            this.txtTenTaiKhoan.TextChanged += new System.EventHandler(this.txtTenTaiKhoan_TextChanged);
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Location = new System.Drawing.Point(323, 229);
            this.txtMatKhau.Multiline = true;
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(279, 38);
            this.txtMatKhau.TabIndex = 2;
            this.txtMatKhau.TextChanged += new System.EventHandler(this.txtMatKhau_TextChanged);
            // 
            // txtTenNguoiChuTri
            // 
            this.txtTenNguoiChuTri.Location = new System.Drawing.Point(323, 310);
            this.txtTenNguoiChuTri.Multiline = true;
            this.txtTenNguoiChuTri.Name = "txtTenNguoiChuTri";
            this.txtTenNguoiChuTri.Size = new System.Drawing.Size(279, 38);
            this.txtTenNguoiChuTri.TabIndex = 2;
            this.txtTenNguoiChuTri.TextChanged += new System.EventHandler(this.txtTenNguoiChuTri_TextChanged);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(323, 391);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(279, 38);
            this.txtEmail.TabIndex = 2;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(323, 467);
            this.txtSDT.Multiline = true;
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(279, 38);
            this.txtSDT.TabIndex = 2;
            this.txtSDT.TextChanged += new System.EventHandler(this.txtSDT_TextChanged);
            // 
            // btnTroLai
            // 
            this.btnTroLai.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnTroLai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTroLai.Location = new System.Drawing.Point(121, 546);
            this.btnTroLai.Name = "btnTroLai";
            this.btnTroLai.Size = new System.Drawing.Size(108, 49);
            this.btnTroLai.TabIndex = 3;
            this.btnTroLai.Text = "Trở lại";
            this.btnTroLai.UseVisualStyleBackColor = false;
            this.btnTroLai.Click += new System.EventHandler(this.btnTroLai_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Location = new System.Drawing.Point(350, 546);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(108, 49);
            this.btnLuu.TabIndex = 3;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(572, 546);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(108, 49);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(277, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(227, 25);
            this.label7.TabIndex = 4;
            this.label7.Text = "CHI TIẾT TÀI KHOẢN";
            // 
            // ChiTietTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QLSKwinform.Properties.Resources.backxanh;
            this.ClientSize = new System.Drawing.Size(800, 607);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnTroLai);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtTenNguoiChuTri);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.txtTenTaiKhoan);
            this.Controls.Add(this.txtMaTaiKhoan);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ChiTietTaiKhoan";
            this.Text = "ChiTietTaiKhoan";
            this.Load += new System.EventHandler(this.ChiTietTaiKhoan_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMaTaiKhoan;
        private System.Windows.Forms.TextBox txtTenTaiKhoan;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.TextBox txtTenNguoiChuTri;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Button btnTroLai;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Label label7;
    }
}