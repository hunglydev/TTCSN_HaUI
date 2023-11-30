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
            this.SuspendLayout();
            // 
            // btnTaiKhoan
            // 
            this.btnTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaiKhoan.Location = new System.Drawing.Point(73, 146);
            this.btnTaiKhoan.Name = "btnTaiKhoan";
            this.btnTaiKhoan.Size = new System.Drawing.Size(141, 56);
            this.btnTaiKhoan.TabIndex = 0;
            this.btnTaiKhoan.Text = "Tài khoản";
            this.btnTaiKhoan.UseVisualStyleBackColor = true;
            this.btnTaiKhoan.Click += new System.EventHandler(this.btnTaiKhoan_Click);
            // 
            // btnSuKien
            // 
            this.btnSuKien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuKien.Location = new System.Drawing.Point(333, 146);
            this.btnSuKien.Name = "btnSuKien";
            this.btnSuKien.Size = new System.Drawing.Size(141, 56);
            this.btnSuKien.TabIndex = 1;
            this.btnSuKien.Text = "Sự kiện";
            this.btnSuKien.UseVisualStyleBackColor = true;
            this.btnSuKien.Click += new System.EventHandler(this.btnSuKien_Click);
            // 
            // btnVoucher
            // 
            this.btnVoucher.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoucher.Location = new System.Drawing.Point(175, 274);
            this.btnVoucher.Name = "btnVoucher";
            this.btnVoucher.Size = new System.Drawing.Size(141, 57);
            this.btnVoucher.TabIndex = 2;
            this.btnVoucher.Text = "Voucher";
            this.btnVoucher.UseVisualStyleBackColor = true;
            this.btnVoucher.Click += new System.EventHandler(this.btnVoucher_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(570, 148);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 52);
            this.button1.TabIndex = 3;
            this.button1.Text = "Phòng";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(458, 275);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(186, 54);
            this.button2.TabIndex = 4;
            this.button2.Text = "Tài khoản - Vou";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // adminMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnVoucher);
            this.Controls.Add(this.btnSuKien);
            this.Controls.Add(this.btnTaiKhoan);
            this.Name = "adminMenu";
            this.Text = "adminMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTaiKhoan;
        private System.Windows.Forms.Button btnSuKien;
        private System.Windows.Forms.Button btnVoucher;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}