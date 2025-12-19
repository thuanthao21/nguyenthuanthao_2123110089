namespace example
{
    partial class FormBai18
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
            this.btDeselect = new System.Windows.Forms.Button(); // Thêm nút này
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbSong
            // 
            this.lbSong.FormattingEnabled = true;
            this.lbSong.Location = new System.Drawing.Point(12, 40);
            this.lbSong.Name = "lbSong";
            this.lbSong.Size = new System.Drawing.Size(200, 250);
            this.lbSong.TabIndex = 0;
            // 
            // lbFavorite
            // 
            this.lbFavorite.FormattingEnabled = true;
            this.lbFavorite.Location = new System.Drawing.Point(300, 40);
            this.lbFavorite.Name = "lbFavorite";
            this.lbFavorite.Size = new System.Drawing.Size(250, 250);
            this.lbFavorite.TabIndex = 1;
            // 
            // btSelect (Nút >)
            // 
            this.btSelect.Location = new System.Drawing.Point(230, 100);
            this.btSelect.Name = "btSelect";
            this.btSelect.Size = new System.Drawing.Size(50, 30);
            this.btSelect.Text = ">";
            this.btSelect.Click += new System.EventHandler(this.btSelect_Click);
            // 
            // btDeselect (Nút <) - Mới thêm
            // 
            this.btDeselect.Location = new System.Drawing.Point(230, 150);
            this.btDeselect.Name = "btDeselect";
            this.btDeselect.Size = new System.Drawing.Size(50, 30);
            this.btDeselect.Text = "<";
            this.btDeselect.Click += new System.EventHandler(this.btDeselect_Click);
            // 
            // Labels
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Text = "Danh sách bài hát";
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);

            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(300, 20);
            this.label2.Text = "Danh sách bài hát ưa thích";
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);

            // Form
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 320);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btDeselect); // Nhớ add nút vào Form
            this.Controls.Add(this.btSelect);
            this.Controls.Add(this.lbFavorite);
            this.Controls.Add(this.lbSong);
            this.Name = "FormBai18";
            this.Text = "Music (Object Binding)";
            this.Load += new System.EventHandler(this.FormBai18_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        #endregion

        private System.Windows.Forms.ListBox lbSong;
        private System.Windows.Forms.ListBox lbFavorite;
        private System.Windows.Forms.Button btSelect;
        private System.Windows.Forms.Button btDeselect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}