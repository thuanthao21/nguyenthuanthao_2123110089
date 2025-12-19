namespace example
{
    partial class FormBai14
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
            this.tbName = new System.Windows.Forms.TextBox();
            this.gbGender = new System.Windows.Forms.GroupBox();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.ckDiscount = new System.Windows.Forms.CheckBox();
            this.tbDiscount = new System.Windows.Forms.TextBox();
            this.tbResult = new System.Windows.Forms.TextBox();
            this.btRun = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.gbGender.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(12, 12);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(260, 20);
            this.tbName.TabIndex = 0;
            this.tbName.Text = "Nguyễn Văn A"; // Giá trị mặc định
            // 
            // gbGender (Nhóm Giới tính)
            // 
            this.gbGender.Controls.Add(this.rbFemale);
            this.gbGender.Controls.Add(this.rbMale);
            this.gbGender.Location = new System.Drawing.Point(12, 45);
            this.gbGender.Name = "gbGender";
            this.gbGender.Size = new System.Drawing.Size(260, 60);
            this.gbGender.TabIndex = 1;
            this.gbGender.TabStop = false;
            this.gbGender.Text = "Giới tính";
            // 
            // rbFemale (Nữ)
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Location = new System.Drawing.Point(150, 25);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(39, 17);
            this.rbFemale.Text = "Nữ";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // rbMale (Nam)
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Checked = true; // Mặc định chọn Nam
            this.rbMale.Location = new System.Drawing.Point(50, 25);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(47, 17);
            this.rbMale.Text = "Nam";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // ckDiscount (Giảm giá)
            // 
            this.ckDiscount.AutoSize = true;
            this.ckDiscount.Location = new System.Drawing.Point(12, 120);
            this.ckDiscount.Name = "ckDiscount";
            this.ckDiscount.Size = new System.Drawing.Size(67, 17);
            this.ckDiscount.TabIndex = 2;
            this.ckDiscount.Text = "Giảm giá";
            this.ckDiscount.UseVisualStyleBackColor = true;
            this.ckDiscount.CheckedChanged += new System.EventHandler(this.ckDiscount_CheckedChanged);
            // 
            // tbDiscount
            // 
            this.tbDiscount.Enabled = false; // Mặc định khóa (vì chưa tick giảm giá)
            this.tbDiscount.Location = new System.Drawing.Point(85, 118);
            this.tbDiscount.Name = "tbDiscount";
            this.tbDiscount.Size = new System.Drawing.Size(187, 20);
            this.tbDiscount.TabIndex = 3;
            // 
            // tbResult
            // 
            this.tbResult.Location = new System.Drawing.Point(12, 150);
            this.tbResult.Multiline = true;
            this.tbResult.Name = "tbResult";
            this.tbResult.Size = new System.Drawing.Size(260, 80);
            this.tbResult.TabIndex = 4;
            // 
            // btRun (Nút Tính tiền)
            // 
            this.btRun.Location = new System.Drawing.Point(116, 240);
            this.btRun.Name = "btRun";
            this.btRun.Size = new System.Drawing.Size(75, 23);
            this.btRun.Text = "Tính tiền";
            this.btRun.UseVisualStyleBackColor = true;
            this.btRun.Click += new System.EventHandler(this.btRun_Click);
            // 
            // btExit (Nút Thoát)
            // 
            this.btExit.Location = new System.Drawing.Point(197, 240);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(75, 23);
            this.btExit.Text = "Thoát";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // FormBai14
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 280);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btRun);
            this.Controls.Add(this.tbResult);
            this.Controls.Add(this.tbDiscount);
            this.Controls.Add(this.ckDiscount);
            this.Controls.Add(this.gbGender);
            this.Controls.Add(this.tbName);
            this.Name = "FormBai14";
            this.Text = "Form1";
            this.gbGender.ResumeLayout(false);
            this.gbGender.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.GroupBox gbGender;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.CheckBox ckDiscount;
        private System.Windows.Forms.TextBox tbDiscount;
        private System.Windows.Forms.TextBox tbResult;
        private System.Windows.Forms.Button btRun;
        private System.Windows.Forms.Button btExit;
    }
}