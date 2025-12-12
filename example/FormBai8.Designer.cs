namespace example
{
    partial class FormBai8
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
            label1 = new Label();
            tbSoX = new TextBox();
            tbSoY = new TextBox();
            label2 = new Label();
            tbKetQua = new TextBox();
            label3 = new Label();
            btCong = new Button();
            btNhan = new Button();
            btThoat = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 26);
            label1.Name = "label1";
            label1.Size = new Size(37, 20);
            label1.TabIndex = 0;
            label1.Text = "số X";
            // 
            // tbSoX
            // 
            tbSoX.Location = new Point(88, 23);
            tbSoX.Name = "tbSoX";
            tbSoX.Size = new Size(194, 27);
            tbSoX.TabIndex = 1;
            // 
            // tbSoY
            // 
            tbSoY.Location = new Point(88, 56);
            tbSoY.Name = "tbSoY";
            tbSoY.Size = new Size(194, 27);
            tbSoY.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 59);
            label2.Name = "label2";
            label2.Size = new Size(36, 20);
            label2.TabIndex = 2;
            label2.Text = "số Y";
            // 
            // tbKetQua
            // 
            tbKetQua.Location = new Point(88, 101);
            tbKetQua.Name = "tbKetQua";
            tbKetQua.ReadOnly = true;
            tbKetQua.Size = new Size(194, 27);
            tbKetQua.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 104);
            label3.Name = "label3";
            label3.Size = new Size(63, 20);
            label3.TabIndex = 4;
            label3.Text = "Kết quả:";
            // 
            // btCong
            // 
            btCong.Location = new Point(12, 154);
            btCong.Name = "btCong";
            btCong.Size = new Size(94, 29);
            btCong.TabIndex = 6;
            btCong.Text = "Cộng";
            btCong.UseVisualStyleBackColor = true;
            btCong.Click += btCong_Click;
            // 
            // btNhan
            // 
            btNhan.Location = new Point(112, 154);
            btNhan.Name = "btNhan";
            btNhan.Size = new Size(94, 29);
            btNhan.TabIndex = 7;
            btNhan.Text = "Nhân";
            btNhan.UseVisualStyleBackColor = true;
            btNhan.Click += btNhan_Click;
            // 
            // btThoat
            // 
            btThoat.Location = new Point(226, 154);
            btThoat.Name = "btThoat";
            btThoat.Size = new Size(94, 29);
            btThoat.TabIndex = 8;
            btThoat.Text = "Thoat";
            btThoat.UseVisualStyleBackColor = true;
            btThoat.Click += btThoat_Click;
            // 
            // FormBai8
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(332, 206);
            Controls.Add(btThoat);
            Controls.Add(btNhan);
            Controls.Add(btCong);
            Controls.Add(tbKetQua);
            Controls.Add(label3);
            Controls.Add(tbSoY);
            Controls.Add(label2);
            Controls.Add(tbSoX);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormBai8";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tbSoX;
        private TextBox tbSoY;
        private Label label2;
        private TextBox tbKetQua;
        private Label label3;
        private Button btCong;
        private Button btNhan;
        private Button btThoat;
    }
}