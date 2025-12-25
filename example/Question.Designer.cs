namespace example
{
    partial class Question
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
            this.panelTop = new System.Windows.Forms.Panel();
            this.lblInfoDob = new System.Windows.Forms.Label();
            this.lblInfoName = new System.Windows.Forms.Label();
            this.lblInfoID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rb4 = new System.Windows.Forms.RadioButton();
            this.rb3 = new System.Windows.Forms.RadioButton();
            this.rb2 = new System.Windows.Forms.RadioButton();
            this.rb1 = new System.Windows.Forms.RadioButton();
            this.btBack = new System.Windows.Forms.Button();
            this.btSubmit = new System.Windows.Forms.Button();
            this.panelTop.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop (Thanh thông tin phía trên)
            // 
            this.panelTop.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelTop.Controls.Add(this.lblInfoDob);
            this.panelTop.Controls.Add(this.lblInfoName);
            this.panelTop.Controls.Add(this.lblInfoID);
            this.panelTop.Controls.Add(this.label1);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(600, 60);
            this.panelTop.TabIndex = 0;
            // 
            // Các Label trong thanh thông tin
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 10);
            this.label1.Text = "Thông tin thí sinh";

            this.lblInfoID.AutoSize = true;
            this.lblInfoID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoID.Location = new System.Drawing.Point(50, 35);
            this.lblInfoID.Text = "Mã:    1";

            this.lblInfoName.AutoSize = true;
            this.lblInfoName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoName.Location = new System.Drawing.Point(200, 35);
            this.lblInfoName.Text = "Tên:    Nguyễn Anh Tú";

            this.lblInfoDob.AutoSize = true;
            this.lblInfoDob.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoDob.Location = new System.Drawing.Point(400, 35);
            this.lblInfoDob.Text = "Ngày sinh:  10/10/1994";

            // 
            // groupBox1 (Câu hỏi)
            // 
            this.groupBox1.Controls.Add(this.lblQuestion);
            this.groupBox1.Location = new System.Drawing.Point(10, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(580, 80);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Câu hỏi";
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblQuestion.Location = new System.Drawing.Point(30, 35);
            this.lblQuestion.Text = "Một cộng một bằng bao nhiêu?";

            // 
            // groupBox2 (Câu trả lời)
            // 
            this.groupBox2.Controls.Add(this.rb4);
            this.groupBox2.Controls.Add(this.rb3);
            this.groupBox2.Controls.Add(this.rb2);
            this.groupBox2.Controls.Add(this.rb1);
            this.groupBox2.Location = new System.Drawing.Point(10, 160);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(580, 140);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Câu trả lời";
            // 
            // RadioButtons
            // 
            this.rb1.AutoSize = true;
            this.rb1.Location = new System.Drawing.Point(40, 30);
            this.rb1.Text = "Hai";
            this.rb1.Checked = true;

            this.rb2.AutoSize = true;
            this.rb2.Location = new System.Drawing.Point(40, 55);
            this.rb2.Text = "Bốn";

            this.rb3.AutoSize = true;
            this.rb3.Location = new System.Drawing.Point(40, 80);
            this.rb3.Text = "Năm";

            this.rb4.AutoSize = true;
            this.rb4.Location = new System.Drawing.Point(40, 105);
            this.rb4.Text = "Ba";

            // 
            // Nút bấm (PUBLIC)
            // 
            this.btBack.Location = new System.Drawing.Point(380, 310);
            this.btBack.Name = "btBack";
            this.btBack.Size = new System.Drawing.Size(90, 30);
            this.btBack.Text = "Quay lại";
            this.btBack.UseVisualStyleBackColor = true;

            this.btSubmit.Location = new System.Drawing.Point(490, 310);
            this.btSubmit.Name = "btSubmit";
            this.btSubmit.Size = new System.Drawing.Size(90, 30);
            this.btSubmit.Text = "Nộp bài";
            this.btSubmit.UseVisualStyleBackColor = true;

            // Setup
            this.Controls.Add(this.btSubmit);
            this.Controls.Add(this.btBack);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panelTop);
            this.Name = "Question";
            this.Size = new System.Drawing.Size(600, 350);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblInfoID;
        private System.Windows.Forms.Label lblInfoName;
        private System.Windows.Forms.Label lblInfoDob;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rb4;
        private System.Windows.Forms.RadioButton rb3;
        private System.Windows.Forms.RadioButton rb2;
        private System.Windows.Forms.RadioButton rb1;

        public System.Windows.Forms.Button btBack;
        public System.Windows.Forms.Button btSubmit;
    }
}