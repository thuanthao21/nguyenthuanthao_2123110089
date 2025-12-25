namespace example
{
    partial class Finish
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btEnd = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1 (Thông tin thí sinh)
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(20, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(560, 130);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin thí sinh";
            // 
            // Các Label thông tin
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 30);
            this.label1.Text = "Mã: 0001";

            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(100, 55);
            this.label2.Text = "Tên: Nguyễn Văn A";

            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(100, 80);
            this.label3.Text = "Ngày sinh: 01/01/1996";

            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(100, 105);
            this.label4.Text = "Nơi sinh: TP. Hồ Chí Minh";

            // 
            // groupBox2 (Kết quả thi)
            // 
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(20, 160);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(560, 130);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kết quả thi";
            // 
            // Các Label Kết quả
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(150, 30);
            this.label5.Text = "Tổng số câu hỏi: 100";

            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(150, 55);
            this.label6.Text = "Tổng số câu trả lời: 85";

            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(150, 80);
            this.label7.Text = "Tổng số câu trả lời đúng: 62";

            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(150, 105);
            this.label8.Text = "Tổng số điểm đạt được: 6.2";

            // 
            // btEnd (PUBLIC)
            // 
            this.btEnd.Location = new System.Drawing.Point(490, 310);
            this.btEnd.Name = "btEnd";
            this.btEnd.Size = new System.Drawing.Size(90, 30);
            this.btEnd.Text = "Kết thúc";
            this.btEnd.UseVisualStyleBackColor = true;

            // Setup
            this.Controls.Add(this.btEnd);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Finish";
            this.Size = new System.Drawing.Size(600, 350);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;

        public System.Windows.Forms.Button btEnd;
    }
}