using System;
using System.Drawing;
using System.Windows.Forms;

namespace example
{
    public partial class FormBai26 : Form
    {
        // 1. KHAI BÁO BIẾN
        PictureBox pbEgg = new PictureBox();

        // --- SỬA LỖI TẠI ĐÂY: Thêm System.Windows.Forms vào trước Timer ---
        System.Windows.Forms.Timer tmEgg = new System.Windows.Forms.Timer();

        int xEgg = 300;
        int yEgg = 0;
        int yDelta = 5;

        public FormBai26()
        {
            InitializeComponent();
        }

        // 2. KHI FORM VỪA MỞ
        private void FormBai26_Load(object sender, EventArgs e)
        {
            tmEgg.Interval = 20;
            tmEgg.Tick += tmEgg_Tick;
            tmEgg.Start();

            pbEgg.SizeMode = PictureBoxSizeMode.StretchImage;
            pbEgg.Size = new Size(60, 80);
            pbEgg.Location = new Point(xEgg, yEgg);
            pbEgg.BackColor = Color.Transparent;

            this.Controls.Add(pbEgg);

            // Load ảnh trứng lành (egg_gold.png)
            try
            {
                pbEgg.Image = Image.FromFile(@"D:\C#\nguyenthuanthao_2123110089\example\Images/egg_gold.png");
            }
            catch
            {
                pbEgg.BackColor = Color.Gold; // Màu vàng nếu không có ảnh
            }
        }

        // 3. SỰ KIỆN RƠI LIÊN TỤC
        void tmEgg_Tick(object sender, EventArgs e)
        {
            yEgg += yDelta;

            // Kiểm tra va chạm đáy màn hình
            if (yEgg > this.ClientSize.Height - pbEgg.Height)
            {
                // Đổi sang ảnh trứng vỡ
                try
                {
                    pbEgg.Image = Image.FromFile(@"D:\C#\nguyenthuanthao_2123110089\example\Images/egg_gold_broken.png");
                }
                catch
                {
                    pbEgg.BackColor = Color.Red; // Màu đỏ nếu không có ảnh
                }

                // Dừng game lại
                tmEgg.Stop();
                MessageBox.Show("Trứng đã vỡ! Game Over.");
            }

            // Cập nhật vị trí
            pbEgg.Location = new Point(xEgg, yEgg);
        }
    }
}