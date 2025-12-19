namespace example
{
    partial class FormBai17
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
            this.lbSong = new System.Windows.Forms.ListBox();
            this.lbFavorite = new System.Windows.Forms.ListBox();
            this.btSelect = new System.Windows.Forms.Button();
            this.btSelectAll = new System.Windows.Forms.Button();
            this.btDeselect = new System.Windows.Forms.Button();
            this.btDeselectAll = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbSong (Danh sách Trái)
            // 
            this.lbSong.FormattingEnabled = true;
            this.lbSong.Items.AddRange(new object[] {
            "Giấc mơ Chapi",
            "Đôi Mắt Pleiku",
            "Em Muốn Sống Bên Anh Trọn Đời",
            "H\'Zen Lên Rẫy",
            "Ly Cà Phê Ban Mê",
            "Đi tìm lời ru mặt trời"});
            this.lbSong.Location = new System.Drawing.Point(12, 40);
            this.lbSong.Name = "lbSong";
            this.lbSong.Size = new System.Drawing.Size(200, 250);
            this.lbSong.TabIndex = 0;
            this.lbSong.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lbSong_MouseDoubleClick);
            // 
            // lbFavorite (Danh sách Phải)
            // 
            this.lbFavorite.FormattingEnabled = true;
            this.lbFavorite.Location = new System.Drawing.Point(300, 40);
            this.lbFavorite.Name = "lbFavorite";
            this.lbFavorite.Size = new System.Drawing.Size(200, 250);
            this.lbFavorite.TabIndex = 1;
            this.lbFavorite.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lbFavorite_MouseDoubleClick);
            // 
            // Các nút bấm điều khiển
            // 
            this.btSelect.Location = new System.Drawing.Point(230, 80);
            this.btSelect.Name = "btSelect";
            this.btSelect.Size = new System.Drawing.Size(50, 30);
            this.btSelect.Text = ">";
            this.btSelect.Click += new System.EventHandler(this.btSelect_Click);

            this.btSelectAll.Location = new System.Drawing.Point(230, 120);
            this.btSelectAll.Name = "btSelectAll";
            this.btSelectAll.Size = new System.Drawing.Size(50, 30);
            this.btSelectAll.Text = ">>";
            this.btSelectAll.Click += new System.EventHandler(this.btSelectAll_Click);

            this.btDeselect.Location = new System.Drawing.Point(230, 160);
            this.btDeselect.Name = "btDeselect";
            this.btDeselect.Size = new System.Drawing.Size(50, 30);
            this.btDeselect.Text = "<";
            this.btDeselect.Click += new System.EventHandler(this.btDeselect_Click);

            this.btDeselectAll.Location = new System.Drawing.Point(230, 200);
            this.btDeselectAll.Name = "btDeselectAll";
            this.btDeselectAll.Size = new System.Drawing.Size(50, 30);
            this.btDeselectAll.Text = "<<";
            this.btDeselectAll.Click += new System.EventHandler(this.btDeselectAll_Click);

            // 
            // Labels
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Text = "Danh sách bài hát";
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(300, 20);
            this.label2.Name = "label2";
            this.label2.Text = "Danh sách bài hát ưa thích";
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            // 
            // FormBai17
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 320);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btDeselectAll);
            this.Controls.Add(this.btDeselect);
            this.Controls.Add(this.btSelectAll);
            this.Controls.Add(this.btSelect);
            this.Controls.Add(this.lbFavorite);
            this.Controls.Add(this.lbSong);
            this.Name = "FormBai17";
            this.Text = "Music";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ListBox lbSong;
        private System.Windows.Forms.ListBox lbFavorite;
        private System.Windows.Forms.Button btSelect;
        private System.Windows.Forms.Button btSelectAll;
        private System.Windows.Forms.Button btDeselect;
        private System.Windows.Forms.Button btDeselectAll;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}