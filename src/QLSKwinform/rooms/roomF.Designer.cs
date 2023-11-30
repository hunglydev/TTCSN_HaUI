namespace QLSKwinform
{
    partial class roomF
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAgree = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lbnameRoom = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(524, 459);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(175, 53);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "HỦY BỎ";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAgree
            // 
            this.btnAgree.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAgree.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgree.Location = new System.Drawing.Point(169, 459);
            this.btnAgree.Name = "btnAgree";
            this.btnAgree.Size = new System.Drawing.Size(175, 53);
            this.btnAgree.TabIndex = 15;
            this.btnAgree.Text = "ĐẶT PHÒNG";
            this.btnAgree.UseVisualStyleBackColor = false;
            this.btnAgree.Click += new System.EventHandler(this.btnAgree_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(441, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 16);
            this.label3.TabIndex = 12;
            // 
            // lbnameRoom
            // 
            this.lbnameRoom.AutoSize = true;
            this.lbnameRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbnameRoom.Location = new System.Drawing.Point(389, 107);
            this.lbnameRoom.Name = "lbnameRoom";
            this.lbnameRoom.Size = new System.Drawing.Size(86, 25);
            this.lbnameRoom.TabIndex = 11;
            this.lbnameRoom.Text = "Phòng F";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.BackgroundImage = global::QLSKwinform.Properties.Resources.roomF;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(157, 96);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(202, 157);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(158, 280);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(496, 110);
            this.textBox1.TabIndex = 19;
            this.textBox1.Text = "Phòng có đầy đủ điều hòa, quạt, sân khấu, có hệ thống chiếu sáng, âm thanh thích " +
    "hợp cho nhóm đông người";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(312, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 25);
            this.label1.TabIndex = 20;
            this.label1.Text = "CHI TIẾT PHÒNG";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(389, 209);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(203, 25);
            this.label8.TabIndex = 6;
            this.label8.Text = "203 Phan Đình Phùng";
            this.label8.Click += new System.EventHandler(this.lbRoomA_Click);
            // 
            // roomF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QLSKwinform.Properties.Resources.dia_diem_khach_san_to_chuc_su_kien_intercontinental_Hanoi_Landmark72;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 544);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAgree);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbnameRoom);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label8);
            this.Name = "roomF";
            this.Text = "roomF";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAgree;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbnameRoom;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
    }
}