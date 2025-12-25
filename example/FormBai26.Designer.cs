namespace example
{
    partial class FormBai26
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
            // FormBai26
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 500); // Chiều cao form
            this.Name = "FormBai26";
            this.Text = "Game Hứng Trứng (Egg Drop)";
            this.Load += new System.EventHandler(this.FormBai26_Load);
            this.ResumeLayout(false);
        }

        #endregion
    }
}