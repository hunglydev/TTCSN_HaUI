﻿namespace QLSKwinform
{
    partial class roomE
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
            this.lbnameRoom = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtDescript = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbDiaDiem = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(352, 393);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(131, 43);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "HỦY BỎ";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAgree
            // 
            this.btnAgree.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAgree.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgree.Location = new System.Drawing.Point(118, 393);
            this.btnAgree.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAgree.Name = "btnAgree";
            this.btnAgree.Size = new System.Drawing.Size(131, 43);
            this.btnAgree.TabIndex = 15;
            this.btnAgree.Text = "ĐẶT PHÒNG";
            this.btnAgree.UseVisualStyleBackColor = false;
            this.btnAgree.Click += new System.EventHandler(this.btnAgree_Click);
            // 
            // lbnameRoom
            // 
            this.lbnameRoom.AutoSize = true;
            this.lbnameRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbnameRoom.Location = new System.Drawing.Point(280, 85);
            this.lbnameRoom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbnameRoom.Name = "lbnameRoom";
            this.lbnameRoom.Size = new System.Drawing.Size(70, 20);
            this.lbnameRoom.TabIndex = 11;
            this.lbnameRoom.Text = "Phòng E";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.BackgroundImage = global::QLSKwinform.Properties.Resources.roomE;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(130, 62);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(119, 119);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // txtDescript
            // 
            this.txtDescript.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescript.Location = new System.Drawing.Point(118, 205);
            this.txtDescript.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDescript.Multiline = true;
            this.txtDescript.Name = "txtDescript";
            this.txtDescript.ReadOnly = true;
            this.txtDescript.Size = new System.Drawing.Size(373, 90);
            this.txtDescript.TabIndex = 19;
            this.txtDescript.Text = "Phòng có đầy đủ điều hòa, quạt, sân khấu, có hệ thống chiếu sáng, âm thanh thích " +
    "hợp cho nhóm đông người";
            this.txtDescript.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(237, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "CHI TIẾT PHÒNG";
            // 
            // lbDiaDiem
            // 
            this.lbDiaDiem.AutoSize = true;
            this.lbDiaDiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDiaDiem.Location = new System.Drawing.Point(280, 141);
            this.lbDiaDiem.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbDiaDiem.Name = "lbDiaDiem";
            this.lbDiaDiem.Size = new System.Drawing.Size(102, 20);
            this.lbDiaDiem.TabIndex = 6;
            this.lbDiaDiem.Text = "270 Cổ Nhuế";
            this.lbDiaDiem.Click += new System.EventHandler(this.lbRoomA_Click);
            // 
            // roomE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QLSKwinform.Properties.Resources.dia_diem_khach_san_to_chuc_su_kien_intercontinental_Hanoi_Landmark72;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(600, 465);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDescript);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAgree);
            this.Controls.Add(this.lbnameRoom);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbDiaDiem);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "roomE";
            this.Text = "roomE";
            this.Load += new System.EventHandler(this.roomE_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAgree;
        private System.Windows.Forms.Label lbnameRoom;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtDescript;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbDiaDiem;
    }
}