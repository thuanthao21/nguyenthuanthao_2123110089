using System;
using System.Collections.Generic; // Để dùng List<>
using System.Windows.Forms;

namespace example
{
    public partial class FormBai21 : Form
    {
        // Khai báo danh sách nhân viên (Slide 141)
        List<Employee> lst;

        public FormBai21()
        {
            InitializeComponent();
        }

        // 1. Tạo dữ liệu giả (Slide 141)
        public List<Employee> GetData()
        {
            List<Employee> lst = new List<Employee>();

            Employee em = new Employee();
            em.Id = "53418"; em.Name = "Trần Tiến"; em.Age = 20; em.Gender = true;
            lst.Add(em);

            em = new Employee();
            em.Id = "53416"; em.Name = "Nguyễn Cường"; em.Age = 25; em.Gender = false;
            lst.Add(em);

            em = new Employee();
            em.Id = "53417"; em.Name = "Nguyễn Hào"; em.Age = 23; em.Gender = true;
            lst.Add(em);

            return lst;
        }

        // 2. Form Load: Đổ dữ liệu từ List lên Grid (Slide 142)
        private void FormBai21_Load(object sender, EventArgs e)
        {
            lst = GetData(); // Lấy dữ liệu vào List

            // Duyệt từng nhân viên trong List để đưa lên bảng
            foreach (Employee em in lst)
            {
                dgvEmployee.Rows.Add(em.Id, em.Name, em.Age, em.Gender);
            }
        }

        // 3. Nút THÊM: Thêm vào cả List và Grid (Slide 143)
        private void btAddNew_Click(object sender, EventArgs e)
        {
            // Tạo đối tượng nhân viên mới
            Employee em = new Employee();
            em.Id = tbId.Text;
            em.Name = tbName.Text;
            // Xử lý lỗi nếu quên nhập tuổi (tránh crash)
            int age = 0;
            int.TryParse(tbAge.Text, out age);
            em.Age = age;
            em.Gender = ckGender.Checked;

            // Thêm vào List (Quản lý ngầm)
            lst.Add(em);

            // Thêm vào Grid (Hiển thị)
            dgvEmployee.Rows.Add(em.Id, em.Name, em.Age, em.Gender);
        }

        // 4. Nút XÓA: Xóa cả trong List và Grid (Slide 144)
        private void btDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int idx = dgvEmployee.CurrentCell.RowIndex;

                // Xóa trong List (để đồng bộ dữ liệu)
                // Lưu ý: Cần kiểm tra idx hợp lệ với List không
                if (idx < lst.Count) lst.RemoveAt(idx);

                // Xóa trên Grid
                dgvEmployee.Rows.RemoveAt(idx);
            }
            catch (Exception) { MessageBox.Show("Hãy chọn dòng cần xóa!"); }
        }

        // 5. Sự kiện chọn dòng (Binding ngược) - Slide 144
        private void dgvEmployee_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int idx = e.RowIndex;
            if (idx >= 0 && idx < dgvEmployee.Rows.Count - 1)
            {
                tbId.Text = dgvEmployee.Rows[idx].Cells[0].Value?.ToString();
                tbName.Text = dgvEmployee.Rows[idx].Cells[1].Value?.ToString();
                tbAge.Text = dgvEmployee.Rows[idx].Cells[2].Value?.ToString();

                string genderValue = dgvEmployee.Rows[idx].Cells[3].Value?.ToString();
                ckGender.Checked = (genderValue == "True");
            }
        }

        // 6. Nút Thoát
        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}