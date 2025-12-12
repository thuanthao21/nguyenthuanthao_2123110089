using System;
using System.Windows.Forms;

namespace example
{
    public partial class FormBai8 : Form
    {
        public FormBai8()
        {
            InitializeComponent();
        }

        // 1. Xử lý nút CỘNG (Slide 70)
        private void btCong_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy chữ trong ô, đổi thành số nguyên (int)
                int x = int.Parse(tbSoX.Text);
                int y = int.Parse(tbSoY.Text);

                // Tính toán
                int kq = x + y;

                // Đổi số ngược lại thành chữ để hiện lên màn hình
                tbKetQua.Text = kq.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Vui lòng nhập đúng số!");
            }
        }

        // 2. Xử lý nút NHÂN (Slide 70)
        private void btNhan_Click(object sender, EventArgs e)
        {
            try
            {
                int x = int.Parse(tbSoX.Text);
                int y = int.Parse(tbSoY.Text);

                int kq = x * y;

                tbKetQua.Text = kq.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Vui lòng nhập đúng số!");
            }
        }

        // 3. Xử lý nút THOÁT (Slide 70)
        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close(); // Đóng Form lại
        }


    }
}