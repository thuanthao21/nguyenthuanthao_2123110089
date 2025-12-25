namespace example
{
    partial class Login
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
            this.tbID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpDob = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.tbPlace = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbGender = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbExam = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btStart = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1 (Thông tin thí sinh)
            // 
            this.groupBox1.Controls.Add(this.tbAddress);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cbGender);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tbPlace);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dtpDob);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(10, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(580, 200);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin thí sinh";
            // 
            // Các Label và TextBox (Sắp xếp giống ảnh)
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.Text = "Mã";

            this.tbID.Location = new System.Drawing.Point(110, 22);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(150, 20);

            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.Text = "Tên";

            this.tbName.Location = new System.Drawing.Point(110, 52);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(300, 20);

            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.Text = "Ngày sinh";

            this.dtpDob.Location = new System.Drawing.Point(110, 82);
            this.dtpDob.Size = new System.Drawing.Size(200, 20);

            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.Text = "Nơi sinh";

            this.tbPlace.Location = new System.Drawing.Point(110, 112);
            this.tbPlace.Size = new System.Drawing.Size(300, 20);

            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.Text = "Giới tính";

            this.cbGender.Items.AddRange(new object[] { "Nam", "Nữ" });
            this.cbGender.Location = new System.Drawing.Point(110, 142);
            this.cbGender.Size = new System.Drawing.Size(100, 21);
            this.cbGender.Text = "Nam";

            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(50, 175);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.Text = "Địa chỉ";

            this.tbAddress.Location = new System.Drawing.Point(110, 172);
            this.tbAddress.Size = new System.Drawing.Size(300, 20);

            // 
            // groupBox2 (Thông tin kỳ thi)
            // 
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.cbExam);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(10, 220);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(580, 80);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin kỳ thi";

            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 30);
            this.label7.Text = "Danh sách kỳ thi";

            this.cbExam.Items.AddRange(new object[] { "Chứng chỉ tin học A tiếng Anh" });
            this.cbExam.Location = new System.Drawing.Point(110, 27);
            this.cbExam.Size = new System.Drawing.Size(200, 21);
            this.cbExam.Text = "Chứng chỉ tin học A tiếng Anh";

            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(340, 30);
            this.label8.Text = "Số câu hỏi:";

            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(400, 30);
            this.label9.Text = "60";

            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(450, 30);
            this.label10.Text = "Thời gian:";

            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(500, 30);
            this.label11.Text = "120";

            // 
            // Nút bấm (PUBLIC)
            // 
            this.btStart.Location = new System.Drawing.Point(380, 310);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(90, 30);
            this.btStart.Text = "Tiếp tục";
            this.btStart.UseVisualStyleBackColor = true;

            this.btExit.Location = new System.Drawing.Point(490, 310);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(90, 30);
            this.btExit.Text = "Kết thúc";
            this.btExit.UseVisualStyleBackColor = true;

            // Login UserControl Setup
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btStart);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Login";
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
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpDob;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbPlace;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbGender;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbExam;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;

        public System.Windows.Forms.Button btStart;
        public System.Windows.Forms.Button btExit;
    }
}