namespace example
{
    partial class FormBai11
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtDisplay; // Khai báo biến ở đây

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.txtDisplay = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtDisplay
            // 
            this.txtDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.txtDisplay.Location = new System.Drawing.Point(12, 12);
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.Size = new System.Drawing.Size(360, 38);
            this.txtDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDisplay.ReadOnly = true;
            // 
            // FormBai11
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 440);
            this.Controls.Add(this.txtDisplay);
            this.Name = "FormBai11";
            this.Text = "My Calculator";
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}