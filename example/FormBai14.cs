using System;
using System.Windows.Forms;

namespace example
{
    public partial class FormBai14 : Form
    {
        public FormBai14()
        {
            InitializeComponent();
        }

        // 1. Sự kiện khi bấm nút Tính tiền (Slide 106)
        private void btRun_Click(object sender, EventArgs e)
        {
            string msg = "";
            int disc = 0;

            // Kiểm tra giới tính
            if (rbMale.Checked == true)
                msg += "Ông ";
            if (rbFemale.Checked == true)
                msg += "Bà ";

            // Kiểm tra giảm giá
            if (ckDiscount.Checked == true)
            {
                // Lấy giá trị từ ô nhập (Thay vì gán cứng disc = 5 như slide cũ)
                // Dùng TryParse để tránh lỗi nếu người dùng nhập chữ linh tinh
                int.TryParse(tbDiscount.Text, out disc);
            }

            // Hiển thị kết quả
            // \r\n là ký tự xuống dòng
            tbResult.Text = msg + tbName.Text + " được giảm " + disc.ToString() + "%" + "\r\n";
        }

        // 2. Sự kiện khi tick vào ô Giảm giá (Slide 106)
        // Nếu tick -> Cho nhập ô textbox. Nếu bỏ tick -> Khóa ô textbox.
        private void ckDiscount_CheckedChanged(object sender, EventArgs e)
        {
            if (ckDiscount.Checked == true)
            {
                tbDiscount.Enabled = true; // Mở khóa
                tbDiscount.Focus();        // Đặt con trỏ chuột vào đó luôn
            }
            else
            {
                tbDiscount.Enabled = false; // Khóa lại
                tbDiscount.Text = "";       // Xóa trắng cho sạch
            }
        }

        // 3. Nút Thoát
        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}