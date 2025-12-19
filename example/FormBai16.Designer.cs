namespace example
{
    partial class FormBai16
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
            this.tbName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpDob = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.cbFaculty = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbStatus = new System.Windows.Forms.TextBox();
            this.btAdd = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1 (Họ tên)
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.Text = "Họ và tên";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(100, 22);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(200, 20);
            this.tbName.TabIndex = 0;
            // 
            // label2 (Ngày sinh)
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.Text = "Ngày Sinh";
            // 
            // dtpDob
            // 
            this.dtpDob.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDob.Location = new System.Drawing.Point(100, 57);
            this.dtpDob.Name = "dtpDob";
            this.dtpDob.Size = new System.Drawing.Size(200, 20);
            this.dtpDob.TabIndex = 1;
            // 
            // groupBox1 (Giới tính)
            // 
            this.groupBox1.Controls.Add(this.rbFemale);
            this.groupBox1.Controls.Add(this.rbMale);
            this.groupBox1.Location = new System.Drawing.Point(100, 90);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 50);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Giới tính";
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Location = new System.Drawing.Point(120, 20);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(39, 17);
            this.rbFemale.Text = "Nữ";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Checked = true;
            this.rbMale.Location = new System.Drawing.Point(30, 20);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(47, 17);
            this.rbMale.Text = "Nam";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // label3 (Khoa)
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.Text = "Khoa";
            // 
            // cbFaculty
            // 
            this.cbFaculty.FormattingEnabled = true;
            this.cbFaculty.Items.AddRange(new object[] {
            "Công nghệ thông tin",
            "Quản trị kinh doanh",
            "Kế toán",
            "Ngoại ngữ"});
            this.cbFaculty.Location = new System.Drawing.Point(100, 157);
            this.cbFaculty.Name = "cbFaculty";
            this.cbFaculty.Size = new System.Drawing.Size(200, 21);
            this.cbFaculty.TabIndex = 3;
            this.cbFaculty.Text = "Công nghệ thông tin"; // Chọn sẵn
            // 
            // label4 (Trạng thái)
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.Text = "Trạng thái";
            // 
            // tbStatus (Ô kết quả lớn)
            // 
            this.tbStatus.Location = new System.Drawing.Point(100, 200);
            this.tbStatus.Multiline = true;
            this.tbStatus.Name = "tbStatus";
            this.tbStatus.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbStatus.Size = new System.Drawing.Size(200, 120);
            this.tbStatus.TabIndex = 4;
            // 
            // btAdd (Nút Thêm)
            // 
            this.btAdd.Location = new System.Drawing.Point(144, 330);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(75, 23);
            this.btAdd.Text = "Thêm";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btExit (Nút Thoát)
            // 
            this.btExit.Location = new System.Drawing.Point(225, 330);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(75, 23);
            this.btExit.Text = "Thoát";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // FormBai16
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 380);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.tbStatus);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbFaculty);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtpDob);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label1);
            this.Name = "FormBai16";
            this.Text = "Quản lý sinh viên";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpDob;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbFaculty;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbStatus;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btExit;
    }
}