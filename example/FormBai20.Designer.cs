namespace example
{
    partial class FormBai20
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
            this.dgvEmployee = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGender = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.tbId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbAge = new System.Windows.Forms.TextBox();
            this.ckGender = new System.Windows.Forms.CheckBox();
            this.btAddNew = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEmployee (Bảng dữ liệu)
            // 
            this.dgvEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colName,
            this.colAge,
            this.colGender});
            this.dgvEmployee.Location = new System.Drawing.Point(12, 12);
            this.dgvEmployee.Name = "dgvEmployee";
            this.dgvEmployee.Size = new System.Drawing.Size(460, 150);
            this.dgvEmployee.TabIndex = 0;
            // Gắn sự kiện khi bấm vào dòng (Slide 137)
            this.dgvEmployee.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmployee_RowEnter);
            // 
            // Cấu hình các cột (Columns)
            // 
            this.colId.HeaderText = "Mã nhân viên";
            this.colId.Name = "colId";

            this.colName.HeaderText = "Tên nhân viên";
            this.colName.Name = "colName";
            this.colName.Width = 150;

            this.colAge.HeaderText = "Tuổi";
            this.colAge.Name = "colAge";
            this.colAge.Width = 50;

            this.colGender.HeaderText = "Giới tính (Nam)";
            this.colGender.Name = "colGender";
            this.colGender.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colGender.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Các ô nhập liệu bên dưới
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 180);
            this.label1.Name = "label1";
            this.label1.Text = "Mã";

            this.tbId.Location = new System.Drawing.Point(80, 177);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(100, 20);

            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 210);
            this.label2.Name = "label2";
            this.label2.Text = "Tên";

            this.tbName.Location = new System.Drawing.Point(80, 207);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(200, 20);

            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 240);
            this.label3.Name = "label3";
            this.label3.Text = "Tuổi";

            this.tbAge.Location = new System.Drawing.Point(80, 237);
            this.tbAge.Name = "tbAge";
            this.tbAge.Size = new System.Drawing.Size(50, 20);

            this.ckGender.AutoSize = true;
            this.ckGender.Location = new System.Drawing.Point(80, 270);
            this.ckGender.Name = "ckGender";
            this.ckGender.Text = "Nam";
            this.ckGender.UseVisualStyleBackColor = true;

            // 
            // Các nút bấm
            // 
            this.btAddNew.Location = new System.Drawing.Point(220, 270);
            this.btAddNew.Name = "btAddNew";
            this.btAddNew.Size = new System.Drawing.Size(75, 23);
            this.btAddNew.Text = "Thêm";
            this.btAddNew.Click += new System.EventHandler(this.btAddNew_Click);

            this.btDelete.Location = new System.Drawing.Point(301, 270);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(75, 23);
            this.btDelete.Text = "Xóa";
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);

            this.btExit.Location = new System.Drawing.Point(382, 270);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(75, 23);
            this.btExit.Text = "Thoát";
            this.btExit.Click += new System.EventHandler(this.btExit_Click);

            // 
            // FormBai20
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 311);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btAddNew);
            this.Controls.Add(this.ckGender);
            this.Controls.Add(this.tbAge);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvEmployee);
            this.Name = "FormBai20";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEmployee;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAge;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colGender;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbAge;
        private System.Windows.Forms.CheckBox ckGender;
        private System.Windows.Forms.Button btAddNew;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btExit;
    }
}