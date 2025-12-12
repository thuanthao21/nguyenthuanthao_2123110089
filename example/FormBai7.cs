using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel; // Nhớ thêm thư viện này ở đầu file


namespace example
{
    public partial class FormBai7 : Form
    {
        public FormBai7()
        {
            InitializeComponent();
        }

        private void tbYear_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Nếu KHÔNG PHẢI là phím điều khiển (như Backspace) 
            // VÀ cũng KHÔNG PHẢI là chữ số
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Chặn phím đó lại (không cho nhập)
            }
        }

private void tbYear_Validating(object sender, CancelEventArgs e)
    {
        // Nếu ô trống thì thôi không kiểm tra (để tránh lỗi khi mới mở form)
        if (string.IsNullOrEmpty(tbYear.Text)) return;

        try
        {
            int year = int.Parse(tbYear.Text);
            // Kiểm tra điều kiện (Ví dụ: Năm phải <= 2000)
            if (year > 2000)
            {
                MessageBox.Show("Năm sinh phải nhỏ hơn hoặc bằng 2000!", "Lỗi dữ liệu");
                e.Cancel = true; // Giữ chuột lại ô này, không cho thoát
            }
        }
        catch (Exception)
        {
            // Phòng trường hợp nhập linh tinh không phải số (dù KeyPress đã chặn bớt rồi)
        }
    }



}
}
