using System;
using System.Windows.Forms;

namespace example
{
    public partial class FormBai19 : Form
    {
        public FormBai19()
        {
            InitializeComponent();
        }

        private void btFile_Click(object sender, EventArgs e)
        {
            // 1. Chế độ hiển thị ảnh: Co giãn ảnh cho vừa khung (Slide 129)
            pbImage.SizeMode = PictureBoxSizeMode.StretchImage;

            // 2. Tạo hộp thoại mở file
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Title = "Open Image"; // Tiêu đề hộp thoại

            // Chỉ lọc các file có đuôi .jpg (theo Slide 129)
            // Bạn có thể thêm |*.png để chọn thêm png nếu thích
            dlg.Filter = "JPEG files (*.jpg)|*.jpg";

            // 3. Hiển thị hộp thoại và kiểm tra xem người dùng có bấm OK không
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                // Nếu bấm OK, gán đường dẫn file ảnh vào PictureBox để hiển thị
                pbImage.ImageLocation = dlg.FileName;
            }
        }
    }
}