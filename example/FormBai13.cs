using System;
using System.Collections; // Cần thư viện này để dùng ArrayList
using System.Windows.Forms;

namespace example
{
    public partial class FormBai13 : Form
    {
        public FormBai13()
        {
            InitializeComponent();
        }

        // 1. Hàm tạo dữ liệu giả (Slide 100)
        public ArrayList GetData()
        {
            ArrayList lst = new ArrayList();

            Faculty f = new Faculty();
            f.Id = "K01"; f.Name = "Công nghệ thông tin"; f.Quantity = 1200;
            lst.Add(f);

            f = new Faculty(); // Tạo đối tượng mới
            f.Id = "K02"; f.Name = "Quản trị kinh doanh"; f.Quantity = 4200;
            lst.Add(f);

            f = new Faculty();
            f.Id = "K03"; f.Name = "Kế toán tài chính"; f.Quantity = 5200;
            lst.Add(f);

            return lst;
        }

        // 2. Khi Form Load: Đổ dữ liệu vào ComboBox (Slide 101)
        private void FormBai13_Load(object sender, EventArgs e)
        {
            ArrayList lst = GetData();

            cb_Faculty.DataSource = lst;        // Nguồn là danh sách vừa tạo
            cb_Faculty.DisplayMember = "Name";  // Hiển thị cột "Name"
            // (Mặc định chưa gán ValueMember thì nó sẽ lấy cả đối tượng)
        }

        // 3. Khi chọn thay đổi: Lấy MÃ KHOA (Id) - Slide 101
        private void cb_Faculty_SelectedValueChanged(object sender, EventArgs e)
        {
            // Kiểm tra null để tránh lỗi khi mới khởi động
            if (cb_Faculty.SelectedValue != null)
            {
                // Gán ValueMember là Id để lấy mã
                cb_Faculty.ValueMember = "Id";
                string id = cb_Faculty.SelectedValue.ToString();

                tbDisplay.Text = "Bạn đã chọn khoa có mã: " + id;
            }
        }

        // 4. Khi bấm nút OK: Lấy TÊN KHOA (Name) - Slide 101
        private void btOK_Click(object sender, EventArgs e)
        {
            // Gán ValueMember là Name để lấy tên (theo yêu cầu Slide 101)
            cb_Faculty.ValueMember = "Name";
            string name = cb_Faculty.SelectedValue.ToString();

            tbDisplay.Text = "Bạn đã chọn khoa có tên: " + name;
        }
    }
}