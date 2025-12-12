using System;
using System.Drawing; // Quan trọng: Phải có thư viện này mới dùng được 'Size'
using System.Windows.Forms;

namespace example
{
    public partial class FormBai6 : Form
    {
        public FormBai6()
        {
            InitializeComponent();
        }

        private void bt_OK_Click(object sender, EventArgs e)
        {
            // Đổi tiêu đề của cửa sổ (Slide 56)
            this.Text = "Article for Button";

            // Đổi kích thước cửa sổ thành 500x500 (Slide 56)
            this.Size = new Size(500, 500);
        }
    }
}