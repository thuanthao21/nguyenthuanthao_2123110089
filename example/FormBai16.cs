using System;
using System.Windows.Forms;

namespace example
{
    public partial class FormBai16 : Form
    {
        // Biến đếm số lượng sinh viên (Để hiện số 1. 2. 3...)
        int count = 0;

        public FormBai16()
        {
            InitializeComponent();
        }

        // 1. Xử lý nút THÊM
        private void btAdd_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem đã nhập tên chưa
            if (tbName.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên sinh viên!");
                return;
            }

            count++; // Tăng số thứ tự

            // Lấy dữ liệu từ giao diện
            string name = tbName.Text;
            string dob = dtpDob.Value.ToShortDateString(); // Ngày sinh dạng ngắn
            string gender = "";
            if (rbMale.Checked) gender = "Nam";
            else gender = "Nữ";
            string faculty = cbFaculty.Text;

            // Tạo chuỗi kết quả (Giống format trong ảnh Slide 112)
            // \r\n là xuống dòng
            string result = count.ToString() + "." + name + "\r\n" +
                            "   -Giới tính: " + gender + "\r\n" +
                            "   -Ngày Sinh: " + dob + "\r\n" +
                            "   -Khoa: " + faculty + "\r\n";

            // Nối thêm vào ô Trạng thái (+=)
            tbStatus.Text += result;
        }

        // 2. Xử lý nút THOÁT
        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}