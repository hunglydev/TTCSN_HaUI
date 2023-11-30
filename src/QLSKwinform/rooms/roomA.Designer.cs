namespace QLSKwinform
{
    partial class roomA
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbnameRoom = new System.Windows.Forms.Label();
            this.btnAgree = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(341, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "CHI TIẾT PHÒNG";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.BackgroundImage = global::QLSKwinform.Properties.Resources.roomA;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(174, 89);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(159, 147);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lbnameRoom
            // 
            this.lbnameRoom.AutoSize = true;
            this.lbnameRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbnameRoom.Location = new System.Drawing.Point(364, 108);
            this.lbnameRoom.Name = "lbnameRoom";
            this.lbnameRoom.Size = new System.Drawing.Size(88, 25);
            this.lbnameRoom.TabIndex = 2;
            this.lbnameRoom.Text = "Phòng A";
            this.lbnameRoom.Click += new System.EventHandler(this.lbnameRoom_Click);
            // 
            // btnAgree
            // 
            this.btnAgree.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAgree.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgree.Location = new System.Drawing.Point(133, 482);
            this.btnAgree.Name = "btnAgree";
            this.btnAgree.Size = new System.Drawing.Size(175, 53);
            this.btnAgree.TabIndex = 6;
            this.btnAgree.Text = "ĐẶT PHÒNG";
            this.btnAgree.UseVisualStyleBackColor = false;
            this.btnAgree.Click += new System.EventHandler(this.btnAgree_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(522, 482);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(175, 53);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "HỦY BỎ";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(174, 304);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(496, 110);
            this.textBox1.TabIndex = 19;
            this.textBox1.Text = "Phòng có đầy đủ điều hòa, quạt, sân khấu, có hệ thống chiếu sáng, âm thanh thích " +
    "hợp cho nhóm đông người";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(364, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "158 Cầu Giấy";
            this.label2.Click += new System.EventHandler(this.lbRoomA_Click);
            // 
            // roomA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QLSKwinform.Properties.Resources.dia_diem_khach_san_to_chuc_su_kien_intercontinental_Hanoi_Landmark72;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(854, 582);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAgree);
            this.Controls.Add(this.lbnameRoom);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "roomA";
            this.Text = "roomA";
            this.Load += new System.EventHandler(this.roomA_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbnameRoom;
        private System.Windows.Forms.Button btnAgree;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
    }
}