namespace example
{
    partial class FormBai25
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
            this.SuspendLayout();
            // 
            // FormBai25
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 400); // Kích thước cửa sổ game
            this.Name = "FormBai25";
            this.Text = "Game Tâng Bóng (Bài 25)";
            // Gắn sự kiện Load
            this.Load += new System.EventHandler(this.FormBai25_Load);
            this.ResumeLayout(false);
        }

        #endregion
    }
}