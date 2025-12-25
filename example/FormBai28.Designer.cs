namespace example
{
    partial class FormBai28
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
            // FormBai28
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 600);
            this.Name = "FormBai28";
            this.Text = "Game Gà Đẻ Trứng Vàng";

            // QUAN TRỌNG: Để bắt phím di chuyển giỏ
            this.KeyPreview = true;

            this.Load += new System.EventHandler(this.FormBai28_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormBai28_KeyDown);
            this.ResumeLayout(false);
        }

        #endregion
    }
}