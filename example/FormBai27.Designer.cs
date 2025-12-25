namespace example
{
    partial class FormBai27
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
            // FormBai27
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 600); // Tăng chiều cao lên 600 để chứa được y=500
            this.Name = "FormBai27";
            this.Text = "Game Hứng Trứng (Di chuyển giỏ)";

            // QUAN TRỌNG: Cho phép Form nhận sự kiện phím
            this.KeyPreview = true;

            this.Load += new System.EventHandler(this.FormBai27_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormBai27_KeyDown);
            this.ResumeLayout(false);
        }

        #endregion
    }
}