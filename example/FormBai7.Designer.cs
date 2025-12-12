namespace example
{
    partial class FormBai7
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
            tbYear = new TextBox();
            tbPhone = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 65);
            label1.Name = "label1";
            label1.Size = new Size(37, 20);
            label1.TabIndex = 0;
            label1.Text = "Year";
            // 
            // tbYear
            // 
            tbYear.Location = new Point(120, 58);
            tbYear.Name = "tbYear";
            tbYear.Size = new Size(214, 27);
            tbYear.TabIndex = 1;
            tbYear.KeyPress += tbYear_KeyPress;
            // 
            // tbPhone
            // 
            tbPhone.Location = new Point(120, 116);
            tbPhone.Name = "tbPhone";
            tbPhone.Size = new Size(214, 27);
            tbPhone.TabIndex = 3;
            tbPhone.Validating += tbYear_Validating;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 119);
            label2.Name = "label2";
            label2.Size = new Size(105, 20);
            label2.TabIndex = 2;
            label2.Text = "Phone number";
            // 
            // FormBai7
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(362, 214);
            Controls.Add(tbPhone);
            Controls.Add(label2);
            Controls.Add(tbYear);
            Controls.Add(label1);
            Name = "FormBai7";
            Text = "FormBai7";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tbYear;
        private TextBox tbPhone;
        private Label label2;
    }
}