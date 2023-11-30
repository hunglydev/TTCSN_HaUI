namespace QLSKwinform
{
    partial class adminMenu
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
            this.btnTaiKhoan = new System.Windows.Forms.Button();
            this.btnSuKien = new System.Windows.Forms.Button();
            this.btnVoucher = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnTaiKhoan
            // 
            this.btnTaiKhoan.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaiKhoan.Location = new System.Drawing.Point(327, 189);
            this.btnTaiKhoan.Name = "btnTaiKhoan";
            this.btnTaiKhoan.Size = new System.Drawing.Size(186, 56);
            this.btnTaiKhoan.TabIndex = 0;
            this.btnTaiKhoan.Text = "Tài khoản";
            this.btnTaiKhoan.UseVisualStyleBackColor = false;
            this.btnTaiKhoan.Click += new System.EventHandler(this.btnTaiKhoan_Click);
            // 
            // btnSuKien
            // 
            this.btnSuKien.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSuKien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuKien.Location = new System.Drawing.Point(471, 280);
            this.btnSuKien.Name = "btnSuKien";
            this.btnSuKien.Size = new System.Drawing.Size(186, 56);
            this.btnSuKien.TabIndex = 1;
            this.btnSuKien.Text = "Sự kiện";
            this.btnSuKien.UseVisualStyleBackColor = false;
            this.btnSuKien.Click += new System.EventHandler(this.btnSuKien_Click);
            // 
            // btnVoucher
            // 
            this.btnVoucher.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnVoucher.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoucher.Location = new System.Drawing.Point(183, 381);
            this.btnVoucher.Name = "btnVoucher";
            this.btnVoucher.Size = new System.Drawing.Size(186, 57);
            this.btnVoucher.TabIndex = 2;
            this.btnVoucher.Text = "Voucher";
            this.btnVoucher.UseVisualStyleBackColor = false;
            this.btnVoucher.Click += new System.EventHandler(this.btnVoucher_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(183, 280);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(186, 52);
            this.button1.TabIndex = 3;
            this.button1.Text = "Phòng";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(471, 384);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(186, 54);
            this.button2.TabIndex = 4;
            this.button2.Text = "Tài khoản - Vou";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(656, 32);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(114, 55);
            this.button3.TabIndex = 5;
            this.button3.Text = "Thoát";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(252, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(336, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "QUẢN LÝ SỰ KIỆN VÀ HỘI NGHỊ";
            // 
            // adminMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QLSKwinform.Properties.Resources.adminmenu;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnVoucher);
            this.Controls.Add(this.btnSuKien);
            this.Controls.Add(this.btnTaiKhoan);
            this.Name = "adminMenu";
            this.Text = "adminMenu";
            this.Load += new System.EventHandler(this.adminMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTaiKhoan;
        private System.Windows.Forms.Button btnSuKien;
        private System.Windows.Forms.Button btnVoucher;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
    }
}