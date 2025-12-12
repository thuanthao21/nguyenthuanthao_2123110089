namespace example
{
    partial class FormBai9
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
            tbSoY = new TextBox();
            label2 = new Label();
            tbSoX = new TextBox();
            label1 = new Label();
            label3 = new Label();
            tbKetQua = new TextBox();
            btThoat = new Button();
            btNhan = new Button();
            btCong = new Button();
            btLuu = new Button();
            SuspendLayout();
            // 
            // tbSoY
            // 
            tbSoY.Location = new Point(90, 61);
            tbSoY.Name = "tbSoY";
            tbSoY.Size = new Size(345, 27);
            tbSoY.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 64);
            label2.Name = "label2";
            label2.Size = new Size(36, 20);
            label2.TabIndex = 6;
            label2.Text = "số Y";
            // 
            // tbSoX
            // 
            tbSoX.Location = new Point(90, 28);
            tbSoX.Name = "tbSoX";
            tbSoX.Size = new Size(345, 27);
            tbSoX.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 31);
            label1.Name = "label1";
            label1.Size = new Size(37, 20);
            label1.TabIndex = 4;
            label1.Text = "số X";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 105);
            label3.Name = "label3";
            label3.Size = new Size(63, 20);
            label3.TabIndex = 8;
            label3.Text = "Kết quả:";
            // 
            // tbKetQua
            // 
            tbKetQua.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbKetQua.Location = new Point(90, 128);
            tbKetQua.Multiline = true;
            tbKetQua.Name = "tbKetQua";
            tbKetQua.ScrollBars = ScrollBars.Vertical;
            tbKetQua.Size = new Size(345, 231);
            tbKetQua.TabIndex = 9;
            // 
            // btThoat
            // 
            btThoat.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btThoat.Location = new Point(344, 423);
            btThoat.Name = "btThoat";
            btThoat.Size = new Size(94, 29);
            btThoat.TabIndex = 12;
            btThoat.Text = "Thoat";
            btThoat.UseVisualStyleBackColor = true;
            btThoat.Click += btThoat_Click;
            // 
            // btNhan
            // 
            btNhan.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btNhan.Location = new Point(230, 423);
            btNhan.Name = "btNhan";
            btNhan.Size = new Size(94, 29);
            btNhan.TabIndex = 11;
            btNhan.Text = "Nhân";
            btNhan.UseVisualStyleBackColor = true;
            btNhan.Click += btNhan_Click;
            // 
            // btCong
            // 
            btCong.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btCong.Location = new Point(130, 423);
            btCong.Name = "btCong";
            btCong.Size = new Size(94, 29);
            btCong.TabIndex = 10;
            btCong.Text = "Cộng";
            btCong.UseVisualStyleBackColor = true;
            btCong.Click += btCong_Click;
            // 
            // btLuu
            // 
            btLuu.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btLuu.Location = new Point(12, 423);
            btLuu.Name = "btLuu";
            btLuu.Size = new Size(94, 29);
            btLuu.TabIndex = 13;
            btLuu.Text = "Lưu";
            btLuu.UseVisualStyleBackColor = true;
            btLuu.Click += btLuu_Click;
            // 
            // FormBai9
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(469, 464);
            Controls.Add(btLuu);
            Controls.Add(btThoat);
            Controls.Add(btNhan);
            Controls.Add(btCong);
            Controls.Add(tbKetQua);
            Controls.Add(label3);
            Controls.Add(tbSoY);
            Controls.Add(label2);
            Controls.Add(tbSoX);
            Controls.Add(label1);
            Name = "FormBai9";
            Text = "FormBai9";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbSoY;
        private Label label2;
        private TextBox tbSoX;
        private Label label1;
        private Label label3;
        private TextBox tbKetQua;
        private Button btThoat;
        private Button btNhan;
        private Button btCong;
        private Button btLuu;
    }
}