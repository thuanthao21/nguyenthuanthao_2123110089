using System;
using System.Collections;
using System.Windows.Forms;

namespace example
{
    public partial class FormBai18 : Form
    {
        public FormBai18()
        {
            InitializeComponent();
        }

        // Tạo nhiều dữ liệu hơn cho giống ảnh
        public ArrayList GetData()
        {
            ArrayList lst = new ArrayList();

            Song s = new Song() { Id = 53418, Name = "Giấc mơ cha pi", Author = "Trần Tiến" }; lst.Add(s);
            s = new Song() { Id = 52616, Name = "Đôi mắt pleiku", Author = "Nguyễn Cường" }; lst.Add(s);
            s = new Song() { Id = 51172, Name = "Em muốn sống bên anh trọn đời", Author = "Nguyễn Cường" }; lst.Add(s);

            // --- Thêm bài hát mới cho giống ảnh ---
            s = new Song() { Id = 50001, Name = "H'Zen Lên Rẫy", Author = "Nguyễn Cường" }; lst.Add(s);
            s = new Song() { Id = 50002, Name = "Ly Cà Phê Ban Mê", Author = "Nguyễn Cường" }; lst.Add(s);
            s = new Song() { Id = 50003, Name = "Đi tìm lời ru mặt trời", Author = "Y Phôn Ksor" }; lst.Add(s);

            return lst;
        }

        private void FormBai18_Load(object sender, EventArgs e)
        {
            lbSong.DataSource = GetData();
            lbSong.DisplayMember = "Name";
        }

        // Nút > (Chọn)
        private void btSelect_Click(object sender, EventArgs e)
        {
            if (lbSong.SelectedItem != null)
            {
                Song s = (Song)lbSong.SelectedItem;
                // Thêm chuỗi hiển thị sang phải
                string info = s.Id + " - " + s.Name + " - " + s.Author;

                // Kiểm tra xem bên phải đã có bài này chưa để tránh trùng
                if (!lbFavorite.Items.Contains(info))
                {
                    lbFavorite.Items.Add(info);
                }
            }
        }

        // Nút < (Bỏ chọn - Xóa khỏi danh sách phải)
        private void btDeselect_Click(object sender, EventArgs e)
        {
            if (lbFavorite.SelectedItem != null)
            {
                lbFavorite.Items.Remove(lbFavorite.SelectedItem);
            }
        }
    }
}