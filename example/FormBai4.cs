using System;
using System.Windows.Forms;
using System.IO; // Thư viện để ghi file

namespace example
{
    public partial class FormBai4 : Form
    {
        public FormBai4()
        {
            InitializeComponent();
        }

        // Sự kiện xảy ra khi bạn nhả một phím ra 
        private void FormBai4_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                // Mở file để ghi nối tiếp (true = append)
                // File sẽ nằm ở ổ D, tên là Key_Logger.txt
                StreamWriter sw = new StreamWriter(@"D:\Key_Logger.txt", true);

                // Ghi phím vừa bấm vào file
                // e.KeyCode: Lấy mã phím (Ví dụ: A, B, Enter, Space...)
                sw.Write(e.KeyCode.ToString() + " ");

                // Đóng file ngay để lưu dữ liệu
                sw.Close();
            }
            catch (Exception ex)
            {
                // Nếu lỗi (ví dụ không có ổ D) thì bỏ qua, không làm gì
            }
        }

       
    }
}