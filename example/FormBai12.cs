using System;
using System.Windows.Forms;

namespace example
{
    public partial class FormBai12 : Form
    {
        public FormBai12()
        {
            InitializeComponent();
        }

        // 1. Khi Form vừa mở lên (Form_Load)
        private void FormBai12_Load(object sender, EventArgs e)
        {
            // Chọn sẵn dòng thứ 3 (Index = 2) - Slide 96
            // (Danh sách đếm từ 0: 0, 1, 2...)
            cb_Faculty.SelectedIndex = 2;
        }

        // 2. Khi người dùng thay đổi lựa chọn (SelectedIndexChanged)
        private void cb_Faculty_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Lấy số thứ tự dòng đang chọn
            int index = cb_Faculty.SelectedIndex;

            // Hiển thị ra màn hình - Slide 96
            tbDisplay.Text = "Bạn đã chọn khoa thứ: " + index.ToString();
        }

        // 3. Khi bấm nút OK
        private void btOK_Click(object sender, EventArgs e)
        {
            // Lấy nội dung chữ của dòng đang chọn
            // Lưu ý: Cần kiểm tra SelectedItem có null không để tránh lỗi
            if (cb_Faculty.SelectedItem != null)
            {
                string item = cb_Faculty.SelectedItem.ToString();
                tbDisplay.Text = "Bạn là sinh viên khoa : " + item;
            }
        }

        // 4. Khi bấm nút Clear (Thêm cho đủ giao diện)
        private void btClear_Click(object sender, EventArgs e)
        {
            tbDisplay.Clear(); // Xóa trắng ô kết quả
        }
    }
}