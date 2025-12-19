using System;
using System.Windows.Forms;

namespace example
{
    public partial class FormBai15 : Form
    {
        public FormBai15()
        {
            InitializeComponent();
        }

        // 1. Khi bấm nút OK -> Hiện ngày tháng dạng DÀI lên tiêu đề (Slide 110 trên)
        private void btOK_Click(object sender, EventArgs e)
        {
            // ToLongDateString: Ví dụ "Thứ Năm, ngày 1 tháng 1 năm 2025"
            this.Text = dtpDate.Value.ToLongDateString();
        }

        // 2. Khi thay đổi ngày -> Hiện ngày tháng dạng NGẮN lên tiêu đề (Slide 110 dưới)
        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            // ToShortDateString: Ví dụ "01/01/2025"
            this.Text = dtpDate.Value.ToShortDateString();
        }
    }
}