namespace QLSKwinform
{
    partial class EventForm
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
            this.dGVEvent = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGVEvent)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(433, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Các Sự Kiện Đã Đặt";
            // 
            // dGVEvent
            // 
            this.dGVEvent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVEvent.Location = new System.Drawing.Point(58, 93);
            this.dGVEvent.Name = "dGVEvent";
            this.dGVEvent.RowHeadersWidth = 51;
            this.dGVEvent.RowTemplate.Height = 24;
            this.dGVEvent.Size = new System.Drawing.Size(937, 366);
            this.dGVEvent.TabIndex = 2;
            this.dGVEvent.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVEvent_CellClick);
            this.dGVEvent.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVEvent_CellContentClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(438, 488);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(176, 48);
            this.button1.TabIndex = 3;
            this.button1.Text = "Thoát";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // EventForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QLSKwinform.Properties.Resources.backxanh;
            this.ClientSize = new System.Drawing.Size(1046, 548);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dGVEvent);
            this.Controls.Add(this.label1);
            this.Name = "EventForm";
            this.Text = "EventForm";
            this.Load += new System.EventHandler(this.EventForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGVEvent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dGVEvent;
        private System.Windows.Forms.Button button1;
    }
}