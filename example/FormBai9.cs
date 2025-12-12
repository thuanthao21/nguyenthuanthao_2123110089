using System;
using System.Windows.Forms;
using System.IO; // Thư viện để lưu file

namespace example
{
    public partial class FormBai9 : Form
    {
        public FormBai9()
        {
            InitializeComponent();
        }

        // 1. Nút CỘNG: Nối thêm dòng phép tính vào ô kết quả
        private void btCong_Click(object sender, EventArgs e)
        {
            try
            {
                int x = int.Parse(tbSoX.Text);
                int y = int.Parse(tbSoY.Text);
                int kq = x + y;

                // Slide 74: Cộng dồn chuỗi (dùng +=) và thêm xuống dòng (\r\n)
                tbKetQua.Text += x.ToString() + " + " + y.ToString() + " = " + kq.ToString() + "\r\n";
            }
            catch { MessageBox.Show("Nhập số sai!"); }
        }

        // 2. Nút NHÂN: Tương tự
        private void btNhan_Click(object sender, EventArgs e)
        {
            try
            {
                int x = int.Parse(tbSoX.Text);
                int y = int.Parse(tbSoY.Text);
                int kq = x * y;

                // Slide 74
                tbKetQua.Text += x.ToString() + " * " + y.ToString() + " = " + kq.ToString() + "\r\n";
            }
            catch { MessageBox.Show("Nhập số sai!"); }
        }

        // 3. Nút LƯU: Ghi toàn bộ nội dung ô kết quả xuống file
        private void btLuu_Click(object sender, EventArgs e)
        {
            try
            {
                // Slide 74: Tạo file Caculator.txt (Lưu ý slide ghi thiếu chữ 'l' trong Calculator, bạn sửa lại cho đúng cũng được)
                // Tham số 'true' nghĩa là ghi nối tiếp (append), không xóa nội dung cũ của file
                StreamWriter sw = new StreamWriter("Calculator.txt", true);
                sw.Write(tbKetQua.Text);
                sw.Close();

                MessageBox.Show("Đã lưu thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi lưu file: " + ex.Message);
            }
        }

        // 4. Nút THOÁT
        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}