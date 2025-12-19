using System;
using System.Windows.Forms;

namespace example
{
    public partial class FormBai17 : Form
    {
        public FormBai17()
        {
            InitializeComponent();
        }

        // 1. Chuyển 1 bài từ Trái -> Phải (Nút >)
        private void btSelect_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có chọn bài nào không
            if (lbSong.SelectedItem != null)
            {
                // Thêm vào bên Phải
                lbFavorite.Items.Add(lbSong.SelectedItem);
                // Xóa khỏi bên Trái
                lbSong.Items.Remove(lbSong.SelectedItem);
            }
        }

        // 2. Chuyển 1 bài từ Phải -> Trái (Nút <)
        private void btDeselect_Click(object sender, EventArgs e)
        {
            if (lbFavorite.SelectedItem != null)
            {
                lbSong.Items.Add(lbFavorite.SelectedItem);
                lbFavorite.Items.Remove(lbFavorite.SelectedItem);
            }
        }

        // 3. Chuyển TẤT CẢ từ Trái -> Phải (Nút >>)
        private void btSelectAll_Click(object sender, EventArgs e)
        {
            // Cách nhanh nhất: Copy toàn bộ sang phải, rồi xóa sạch bên trái
            lbFavorite.Items.AddRange(lbSong.Items);
            lbSong.Items.Clear();
        }

        // 4. Chuyển TẤT CẢ từ Phải -> Trái (Nút <<)
        private void btDeselectAll_Click(object sender, EventArgs e)
        {
            lbSong.Items.AddRange(lbFavorite.Items);
            lbFavorite.Items.Clear();
        }

        // 5. Sự kiện Nhấp đúp chuột (Double Click) - Slide 119
        private void lbSong_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            // IndexFromPoint: Kiểm tra xem vị trí chuột click có trúng vào dòng chữ nào không
            int index = lbSong.IndexFromPoint(e.Location);

            if (index != System.Windows.Forms.ListBox.NoMatches) // Nếu trúng
            {
                string song = lbSong.Items[index].ToString();
                lbFavorite.Items.Add(song);
                lbSong.Items.RemoveAt(index);
            }
        }

        private void lbFavorite_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = lbFavorite.IndexFromPoint(e.Location);

            if (index != System.Windows.Forms.ListBox.NoMatches)
            {
                string song = lbFavorite.Items[index].ToString();
                lbSong.Items.Add(song);
                lbFavorite.Items.RemoveAt(index);
            }
        }
    }
}