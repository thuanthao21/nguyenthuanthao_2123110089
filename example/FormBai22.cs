using System;
using System.Collections.Generic; // Để dùng List
using System.Windows.Forms;

namespace example
{
    public partial class FormBai22 : Form
    {
        // Khai báo Danh sách và BindingSource (Slide 149)
        List<Employee> lstEmp;
        BindingSource bs = new BindingSource();

        public FormBai22()
        {
            InitializeComponent();
        }

        // Tạo dữ liệu giả
        public List<Employee> GetData()
        {
            List<Employee> lst = new List<Employee>();
            lst.Add(new Employee() { Id = "53418", Name = "Trần Tiến", Age = 20, Gender = true });
            lst.Add(new Employee() { Id = "53416", Name = "Nguyễn Cường", Age = 25, Gender = false });
            lst.Add(new Employee() { Id = "53417", Name = "Nguyễn Hào", Age = 23, Gender = true });
            return lst;
        }

        // 1. Form Load (Slide 149)
        private void FormBai22_Load(object sender, EventArgs e)
        {
            lstEmp = GetData();

            // Gán danh sách vào BindingSource
            bs.DataSource = lstEmp;

            // Gán BindingSource vào DataGridView
            // Grid sẽ tự động hiện dữ liệu, không cần vòng lặp for add row nữa!
            dgvEmployee.DataSource = bs;
        }

        // 2. Nút Thêm (Slide 149)
        private void btAddNew_Click(object sender, EventArgs e)
        {
            Employee em = new Employee();
            em.Id = tbId.Text;
            em.Name = tbName.Text;
            int.TryParse(tbAge.Text, out int age);
            em.Age = age;
            em.Gender = ckGender.Checked;

            // Thêm vào List và BindingSource
            lstEmp.Add(em);

            // Mẹo: Reset Binding nếu Grid không cập nhật
            bs.ResetBindings(false);
        }

        // 3. Nút Xóa (Slide 150)
        private void btDelete_Click(object sender, EventArgs e)
        {
            try
            {
                // Xóa dòng đang chọn thông qua BindingSource
                if (dgvEmployee.CurrentCell != null)
                {
                    int idx = dgvEmployee.CurrentCell.RowIndex;

                    bs.RemoveAt(idx);        // Xóa khỏi BindingSource
                    // lstEmp.RemoveAt(idx); // Thường bs.RemoveAt đã tự xóa trong list rồi, nhưng slide có ghi thì ta cứ để
                }
            }
            catch (Exception) { }
        }

        // 4. Binding ngược (Slide 150)
        private void dgvEmployee_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int idx = e.RowIndex;
            if (idx >= 0 && idx < dgvEmployee.Rows.Count && !dgvEmployee.Rows[idx].IsNewRow)
            {
                // Lấy dữ liệu từ ô ném về TextBox
                tbId.Text = dgvEmployee.Rows[idx].Cells[0].Value?.ToString();
                tbName.Text = dgvEmployee.Rows[idx].Cells[1].Value?.ToString();
                tbAge.Text = dgvEmployee.Rows[idx].Cells[2].Value?.ToString();

                string gender = dgvEmployee.Rows[idx].Cells[3].Value?.ToString();
                ckGender.Checked = (gender == "True");
            }
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}