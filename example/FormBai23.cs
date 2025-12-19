using System;
using System.Drawing; // Cần thư viện này để dùng Point và Size
using System.Windows.Forms;

namespace example
{
    public partial class FormBai23 : Form
    {
        // 1. Khai báo biến toàn cục (Slide 153)
        PictureBox pb;
        int x = 20; // Tọa độ ban đầu (cho lùi vào 1 chút để dễ nhìn)
        int y = 20;

        public FormBai23()
        {
            InitializeComponent();
        }

        // 2. Nút File: Tạo PictureBox và chọn ảnh (Slide 153)
        private void btFile_Click(object sender, EventArgs e)
        {
            // Mở hộp thoại chọn file (Code này lấy từ bài 19 để thay cho đường dẫn cứng @d:\abc.jpg trong slide)
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Image Files|*.jpg;*.jpeg;*.png";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                // Nếu pb chưa được tạo thì mới tạo (tránh tạo chồng nhiều cái)
                if (pb == null)
                {
                    pb = new PictureBox(); // Khởi tạo đối tượng
                    pb.SizeMode = PictureBoxSizeMode.StretchImage; // Co giãn ảnh
                    pb.Size = new Size(100, 100); // Kích thước 100x100
                    pb.Location = new Point(x, y); // Vị trí ban đầu

                    // QUAN TRỌNG: Lệnh này đưa PictureBox lên giao diện
                    this.Controls.Add(pb);
                }

                // Gán đường dẫn ảnh
                pb.ImageLocation = dlg.FileName;
            }
        }

        // 3. Nút Sang Trái (Slide 154 trên)
        private void btLeft_Click(object sender, EventArgs e)
        {
            if (pb != null) // Kiểm tra xem đã chọn ảnh chưa
            {
                x -= 10; // Giảm toạ độ X để sang trái
                pb.Location = new Point(x, y); // Cập nhật vị trí mới
            }
        }

        // 4. Nút Sang Phải (Slide 154 dưới)
        private void btRight_Click(object sender, EventArgs e)
        {
            if (pb != null)
            {
                x += 10; // Tăng toạ độ X để sang phải
                pb.Location = new Point(x, y);
            }
        }
    }
}