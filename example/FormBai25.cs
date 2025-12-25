using System;
using System.Drawing; // Thư viện đồ họa
using System.Windows.Forms;

namespace example
{
    public partial class FormBai25 : Form
    {
        // --- 1. KHAI BÁO BIẾN (Slide 162) ---
        PictureBox pb = new PictureBox(); // Tạo quả bóng
        System.Windows.Forms.Timer tmGame = new System.Windows.Forms.Timer();
        int xBall = 0;   // Tọa độ ngang
        int yBall = 0;   // Tọa độ dọc
        int xDelta = 5;  // Tốc độ ngang (Mỗi lần nhảy 5 pixel)
        int yDelta = 5;  // Tốc độ dọc

        public FormBai25()
        {
            InitializeComponent();
        }

        // --- 2. KHI FORM VỪA CHẠY (Slide 163 trên) ---
        private void FormBai25_Load(object sender, EventArgs e)
        {
            // Cài đặt Timer (Tốc độ game)
            tmGame.Interval = 10;           // 10ms chạy 1 lần (càng nhỏ càng nhanh)
            tmGame.Tick += tmGame_Tick;     // Gắn sự kiện
            tmGame.Start();                 // Bắt đầu chạy

            // Cài đặt Quả bóng
            pb.SizeMode = PictureBoxSizeMode.StretchImage;
            pb.Size = new Size(50, 50);     // Kích thước 50x50
            pb.Location = new Point(xBall, yBall); // Vị trí ban đầu (0,0)

            // Đưa bóng vào màn hình
            this.Controls.Add(pb);

            // --- Đặt ảnh hoặc màu cho bóng ---
            // Cách 1: Dùng ảnh (Sửa đường dẫn cho đúng máy bạn)
            try
            {
                pb.ImageLocation = @"D:\C#\nguyenthuanthao_2123110089\OIP.jpg";
            }
            catch { }

            // Cách 2: Nếu không có ảnh, dùng màu đỏ cho dễ thấy (Code thêm)
            if (pb.ImageLocation == null) pb.BackColor = Color.Red;
        }

        // --- 3. SỰ KIỆN CHẠY LIÊN TỤC (Slide 163 dưới) ---
        void tmGame_Tick(object sender, EventArgs e)
        {
            // Cộng thêm tọa độ để bóng di chuyển
            xBall += xDelta;
            yBall += yDelta;

            // Xử lý chạm biên ngang (Trái / Phải)
            // Nếu bóng đi quá lề phải HOẶC bóng chạm lề trái (<=0)
            if (xBall > this.ClientSize.Width - pb.Width || xBall <= 0)
            {
                xDelta = -xDelta; // Đổi chiều (đang bay sang phải thì thành sang trái)
            }

            // Xử lý chạm biên dọc (Trên / Dưới)
            if (yBall > this.ClientSize.Height - pb.Height || yBall <= 0)
            {
                yDelta = -yDelta; // Đổi chiều
            }

            // Cập nhật vị trí mới cho bóng
            pb.Location = new Point(xBall, yBall);
        }
    }
}