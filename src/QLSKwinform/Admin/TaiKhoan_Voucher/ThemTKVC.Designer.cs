namespace QLSKwinform.Admin.TaiKhoan_Voucher
{
    partial class ThemTKVC
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbMaTaiKhoan = new System.Windows.Forms.ComboBox();
            this.tAIKHOANBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLSKDataSet2 = new QLSKwinform.QLSKDataSet2();
            this.tAIKHOANVOUCHERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLSKDataSet = new QLSKwinform.QLSKDataSet();
            this.tAIKHOAN_VOUCHERTableAdapter = new QLSKwinform.QLSKDataSetTableAdapters.TAIKHOAN_VOUCHERTableAdapter();
            this.cbMaVoucher = new System.Windows.Forms.ComboBox();
            this.vOUCHERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLSKDataSet3 = new QLSKwinform.QLSKDataSet3();
            this.tAIKHOANVOUCHERBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.qLSKDataSet1 = new QLSKwinform.QLSKDataSet1();
            this.tAIKHOANVOUCHERBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.qLSKDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLSKDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tAIKHOAN_VOUCHERTableAdapter1 = new QLSKwinform.QLSKDataSet1TableAdapters.TAIKHOAN_VOUCHERTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.tAIKHOANTableAdapter = new QLSKwinform.QLSKDataSet2TableAdapters.TAIKHOANTableAdapter();
            this.vOUCHERTableAdapter = new QLSKwinform.QLSKDataSet3TableAdapters.VOUCHERTableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tAIKHOANBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLSKDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAIKHOANVOUCHERBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLSKDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vOUCHERBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLSKDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAIKHOANVOUCHERBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLSKDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAIKHOANVOUCHERBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLSKDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLSKDataSetBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(185, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(353, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "THÊM TÀI KHOẢN VỚI VOUCHER";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(80, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Mã tài khoản";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(80, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Mã voucher:";
            // 
            // cbMaTaiKhoan
            // 
            this.cbMaTaiKhoan.DataSource = this.tAIKHOANBindingSource;
            this.cbMaTaiKhoan.DisplayMember = "maTaiKhoan";
            this.cbMaTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMaTaiKhoan.FormattingEnabled = true;
            this.cbMaTaiKhoan.Location = new System.Drawing.Point(265, 124);
            this.cbMaTaiKhoan.Name = "cbMaTaiKhoan";
            this.cbMaTaiKhoan.Size = new System.Drawing.Size(177, 33);
            this.cbMaTaiKhoan.TabIndex = 8;
            // 
            // tAIKHOANBindingSource
            // 
            this.tAIKHOANBindingSource.DataMember = "TAIKHOAN";
            this.tAIKHOANBindingSource.DataSource = this.qLSKDataSet2;
            // 
            // qLSKDataSet2
            // 
            this.qLSKDataSet2.DataSetName = "QLSKDataSet2";
            this.qLSKDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tAIKHOANVOUCHERBindingSource
            // 
            this.tAIKHOANVOUCHERBindingSource.DataMember = "TAIKHOAN_VOUCHER";
            this.tAIKHOANVOUCHERBindingSource.DataSource = this.qLSKDataSet;
            // 
            // qLSKDataSet
            // 
            this.qLSKDataSet.DataSetName = "QLSKDataSet";
            this.qLSKDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tAIKHOAN_VOUCHERTableAdapter
            // 
            this.tAIKHOAN_VOUCHERTableAdapter.ClearBeforeFill = true;
            // 
            // cbMaVoucher
            // 
            this.cbMaVoucher.DataSource = this.vOUCHERBindingSource;
            this.cbMaVoucher.DisplayMember = "maVoucher";
            this.cbMaVoucher.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMaVoucher.FormattingEnabled = true;
            this.cbMaVoucher.Location = new System.Drawing.Point(265, 227);
            this.cbMaVoucher.Name = "cbMaVoucher";
            this.cbMaVoucher.Size = new System.Drawing.Size(177, 33);
            this.cbMaVoucher.TabIndex = 9;
            // 
            // vOUCHERBindingSource
            // 
            this.vOUCHERBindingSource.DataMember = "VOUCHER";
            this.vOUCHERBindingSource.DataSource = this.qLSKDataSet3;
            // 
            // qLSKDataSet3
            // 
            this.qLSKDataSet3.DataSetName = "QLSKDataSet3";
            this.qLSKDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tAIKHOANVOUCHERBindingSource2
            // 
            this.tAIKHOANVOUCHERBindingSource2.DataMember = "TAIKHOAN_VOUCHER";
            this.tAIKHOANVOUCHERBindingSource2.DataSource = this.qLSKDataSet1;
            // 
            // qLSKDataSet1
            // 
            this.qLSKDataSet1.DataSetName = "QLSKDataSet1";
            this.qLSKDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tAIKHOANVOUCHERBindingSource1
            // 
            this.tAIKHOANVOUCHERBindingSource1.DataMember = "TAIKHOAN_VOUCHER";
            this.tAIKHOANVOUCHERBindingSource1.DataSource = this.qLSKDataSet;
            // 
            // qLSKDataSetBindingSource
            // 
            this.qLSKDataSetBindingSource.DataSource = this.qLSKDataSet;
            this.qLSKDataSetBindingSource.Position = 0;
            // 
            // qLSKDataSetBindingSource1
            // 
            this.qLSKDataSetBindingSource1.DataSource = this.qLSKDataSet;
            this.qLSKDataSetBindingSource1.Position = 0;
            // 
            // tAIKHOAN_VOUCHERTableAdapter1
            // 
            this.tAIKHOAN_VOUCHERTableAdapter1.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(96, 345);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 45);
            this.button1.TabIndex = 10;
            this.button1.Text = "Trở lại";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tAIKHOANTableAdapter
            // 
            this.tAIKHOANTableAdapter.ClearBeforeFill = true;
            // 
            // vOUCHERTableAdapter
            // 
            this.vOUCHERTableAdapter.ClearBeforeFill = true;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(442, 338);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(147, 51);
            this.button2.TabIndex = 11;
            this.button2.Text = "Xác nhận";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ThemTKVC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QLSKwinform.Properties.Resources.backxanh;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbMaVoucher);
            this.Controls.Add(this.cbMaTaiKhoan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ThemTKVC";
            this.Text = "ChiTietTKVC";
            this.Load += new System.EventHandler(this.ChiTietTKVC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tAIKHOANBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLSKDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAIKHOANVOUCHERBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLSKDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vOUCHERBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLSKDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAIKHOANVOUCHERBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLSKDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAIKHOANVOUCHERBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLSKDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLSKDataSetBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbMaTaiKhoan;
        private QLSKDataSet qLSKDataSet;
        private System.Windows.Forms.BindingSource tAIKHOANVOUCHERBindingSource;
        private QLSKDataSetTableAdapters.TAIKHOAN_VOUCHERTableAdapter tAIKHOAN_VOUCHERTableAdapter;
        private System.Windows.Forms.ComboBox cbMaVoucher;
        private System.Windows.Forms.BindingSource tAIKHOANVOUCHERBindingSource1;
        private System.Windows.Forms.BindingSource qLSKDataSetBindingSource1;
        private System.Windows.Forms.BindingSource qLSKDataSetBindingSource;
        private QLSKDataSet1 qLSKDataSet1;
        private System.Windows.Forms.BindingSource tAIKHOANVOUCHERBindingSource2;
        private QLSKDataSet1TableAdapters.TAIKHOAN_VOUCHERTableAdapter tAIKHOAN_VOUCHERTableAdapter1;
        private System.Windows.Forms.Button button1;
        private QLSKDataSet2 qLSKDataSet2;
        private System.Windows.Forms.BindingSource tAIKHOANBindingSource;
        private QLSKDataSet2TableAdapters.TAIKHOANTableAdapter tAIKHOANTableAdapter;
        private QLSKDataSet3 qLSKDataSet3;
        private System.Windows.Forms.BindingSource vOUCHERBindingSource;
        private QLSKDataSet3TableAdapters.VOUCHERTableAdapter vOUCHERTableAdapter;
        private System.Windows.Forms.Button button2;
    }
}