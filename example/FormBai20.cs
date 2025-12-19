using System;
using System.Windows.Forms;

namespace example
{
    public partial class FormBai20 : Form
    {
        public FormBai20()
        {
            InitializeComponent();
        }

        // 1. Nút THÊM (Slide 136)
        private void btAddNew_Click(object sender, EventArgs e)
        {
            // Thêm một dòng mới vào DataGridView với các giá trị từ ô nhập
            dgvEmployee.Rows.Add(tbId.Text, tbName.Text, tbAge.Text, ckGender.Checked);
        }

        // 2. Nút XÓA (Slide 137 trên)
        private void btDelete_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy chỉ số dòng đang chọn (CurrentCell)
                int idx = dgvEmployee.CurrentCell.RowIndex;

                // Xóa dòng đó đi
                // Kiểm tra xem dòng đó có phải dòng mới (chưa có dữ liệu) không để tránh lỗi
                if (!dgvEmployee.Rows[idx].IsNewRow)
                {
                    dgvEmployee.Rows.RemoveAt(idx);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Vui lòng chọn dòng cần xóa!");
            }
        }

        // 3. Sự kiện KHI BẤM VÀO MỘT DÒNG (Slide 137 dưới)
        // Mục đích: Đổ dữ liệu từ bảng ngược lại vào các ô nhập liệu
        private void dgvEmployee_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int idx = e.RowIndex; // Lấy chỉ số dòng vừa bấm vào

            // Chỉ xử lý nếu dòng đó hợp lệ và không phải dòng trống cuối cùng
            if (idx >= 0 && idx < dgvEmployee.Rows.Count - 1)
            {
                // Lấy dữ liệu từng ô (Cell) trong dòng đó
                // Cells[0] là Mã, [1] là Tên, [2] là Tuổi, [3] là Giới tính

                // Dùng ?.ToString() để tránh lỗi nếu ô đó đang rỗng
                tbId.Text = dgvEmployee.Rows[idx].Cells[0].Value?.ToString();
                tbName.Text = dgvEmployee.Rows[idx].Cells[1].Value?.ToString();
                tbAge.Text = dgvEmployee.Rows[idx].Cells[2].Value?.ToString();

                // Xử lý cột CheckBox (Giới tính)
                string genderValue = dgvEmployee.Rows[idx].Cells[3].Value?.ToString();
                if (genderValue != null && genderValue.ToLower() == "true")
                {
                    ckGender.Checked = true;
                }
                else
                {
                    ckGender.Checked = false;
                }
            }
        }

        // 4. Nút THOÁT
        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}