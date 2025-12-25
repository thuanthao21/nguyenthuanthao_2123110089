using System;
using System.Drawing;
using System.Windows.Forms;

namespace example
{
    public partial class FormBai27 : Form
    {
        // 1. KHAI BÁO BIẾN (Slide 173)
        PictureBox pbBasket = new PictureBox();
        int xBasket = 250; // Vị trí ngang
        int yBasket = 500; // Vị trí dọc (Nằm sát đáy)
        int xDelta = 10;   // Tốc độ di chuyển (Mỗi lần bấm đi 10px)

        public FormBai27()
        {
            InitializeComponent();
        }

        // 2. FORM LOAD (Slide 174 trên)
        private void FormBai27_Load(object sender, EventArgs e)
        {
            // Cấu hình cái giỏ
            pbBasket.SizeMode = PictureBoxSizeMode.StretchImage;
            pbBasket.Size = new Size(100, 100);
            pbBasket.Location = new Point(xBasket, yBasket);
            pbBasket.BackColor = Color.Transparent;

            this.Controls.Add(pbBasket);

            // Nạp ảnh basket.png
            try
            {
                pbBasket.Image = Image.FromFile(@"D:\C#\nguyenthuanthao_2123110089\example/Images/basket.png");
            }
            catch
            {
                pbBasket.BackColor = Color.Blue; // Nếu không có ảnh thì hiện màu Xanh
            }
        }

        // 3. SỰ KIỆN BẤM PHÍM (Slide 174 dưới)
        private void FormBai27_KeyDown(object sender, KeyEventArgs e)
        {
            // Kiểm tra phím Mũi tên Phải (Right) -> Mã 39
            // Và kiểm tra xem có đi quá lề phải không
            if (e.KeyValue == 39 && (xBasket < this.ClientSize.Width - pbBasket.Width))
            {
                xBasket += xDelta;
            }

            // Kiểm tra phím Mũi tên Trái (Left) -> Mã 37
            // Và kiểm tra xem có đi quá lề trái không (> 0)
            if (e.KeyValue == 37 && xBasket > 0)
            {
                xBasket -= xDelta;
            }

            // Cập nhật vị trí mới
            pbBasket.Location = new Point(xBasket, yBasket);
        }
    }
}