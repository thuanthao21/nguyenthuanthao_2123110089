namespace example
{
    partial class FormBai15
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.btOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1 (Chữ "Date")
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.Text = "Date";
            // 
            // dtpDate (Bộ chọn ngày)
            // 
            this.dtpDate.CustomFormat = "dd/MM/yyyy";
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short; // Hiển thị dạng ngắn cho gọn
            this.dtpDate.Location = new System.Drawing.Point(60, 27);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(200, 20);
            this.dtpDate.TabIndex = 0;
            // Gắn sự kiện khi thay đổi ngày (ValueChanged) - Slide 110
            this.dtpDate.ValueChanged += new System.EventHandler(this.dtpDate_ValueChanged);
            // 
            // btOK (Nút OK)
            // 
            this.btOK.Location = new System.Drawing.Point(185, 70);
            this.btOK.Name = "btOK";
            this.btOK.Size = new System.Drawing.Size(75, 23);
            this.btOK.Text = "OK";
            this.btOK.UseVisualStyleBackColor = true;
            // Gắn sự kiện Click - Slide 110
            this.btOK.Click += new System.EventHandler(this.btOK_Click);
            // 
            // FormBai15
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 121);
            this.Controls.Add(this.btOK);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.label1);
            this.Name = "FormBai15";
            this.Text = "DateTimePicker";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Button btOK;
    }
}