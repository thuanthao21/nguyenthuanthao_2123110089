using System;
using System.Drawing;
using System.Windows.Forms;

namespace example
{
    public partial class FormBai28 : Form
    {
        // --- 1. KHAI BÁO BIẾN ---
        PictureBox pbBasket = new PictureBox();
        PictureBox pbEgg = new PictureBox();
        PictureBox pbChicken = new PictureBox();

        System.Windows.Forms.Timer tmEgg = new System.Windows.Forms.Timer();
        System.Windows.Forms.Timer tmChicken = new System.Windows.Forms.Timer();

        // Tọa độ GIỎ
        int xBasket = 300;
        int yBasket = 500;
        int xDeltaBasket = 30; // Tăng tốc độ giỏ lên xíu cho dễ hứng

        // Tọa độ GÀ
        int xChicken = 300;
        int yChicken = 10;
        int xDeltaChicken = 5;

        // Tọa độ TRỨNG
        int xEgg = 300;
        int yEgg = 10;
        int yDeltaEgg = 5;

        public FormBai28()
        {
            InitializeComponent();
        }

        // --- 2. FORM LOAD ---
        private void FormBai28_Load(object sender, EventArgs e)
        {
            // Timer
            tmEgg.Interval = 10;
            tmEgg.Tick += tmEgg_Tick;
            tmEgg.Start();

            tmChicken.Interval = 10;
            tmChicken.Tick += tmChicken_Tick;
            tmChicken.Start();

            // Setup các PictureBox
            pbBasket.SizeMode = PictureBoxSizeMode.StretchImage;
            pbBasket.Size = new Size(100, 100);
            pbBasket.Location = new Point(xBasket, yBasket);
            pbBasket.BackColor = Color.Transparent;
            this.Controls.Add(pbBasket);

            pbChicken.SizeMode = PictureBoxSizeMode.StretchImage;
            pbChicken.Size = new Size(100, 100);
            pbChicken.Location = new Point(xChicken, yChicken);
            pbChicken.BackColor = Color.Transparent;
            this.Controls.Add(pbChicken);

            pbEgg.SizeMode = PictureBoxSizeMode.StretchImage;
            pbEgg.Size = new Size(50, 70);
            pbEgg.Location = new Point(xEgg, yEgg);
            pbEgg.BackColor = Color.Transparent;
            this.Controls.Add(pbEgg);

            // Nạp ảnh
            try
            {
                pbBasket.Image = Image.FromFile(@"D:\C#\nguyenthuanthao_2123110089\example/Images/basket.png");
                pbChicken.Image = Image.FromFile(@"D:\C#\nguyenthuanthao_2123110089\example/Images/chicken.png");
                pbEgg.Image = Image.FromFile(@"D:\C#\nguyenthuanthao_2123110089\example/Images/egg_gold.png");
            }
            catch
            {
                pbBasket.BackColor = Color.Blue;
                pbChicken.BackColor = Color.Brown;
                pbEgg.BackColor = Color.Gold;
            }
        }

        // --- 3. GÀ BAY ---
        void tmChicken_Tick(object sender, EventArgs e)
        {
            xChicken += xDeltaChicken;
            if (xChicken > this.ClientSize.Width - pbChicken.Width || xChicken <= 0)
                xDeltaChicken = -xDeltaChicken;

            pbChicken.Location = new Point(xChicken, yChicken);
        }

        // --- 4. TRỨNG RƠI (Logic thay đổi ở đây) ---
        void tmEgg_Tick(object sender, EventArgs e)
        {
            yEgg += yDeltaEgg;

            // a. Kiểm tra chạm đất -> THUA CUỘC
            if (yEgg > this.ClientSize.Height - pbEgg.Height)
            {
                // 1. Đổi ảnh trứng vỡ
                try
                {
                    pbEgg.Image = Image.FromFile(@"D:\C#\nguyenthuanthao_2123110089\example/Images/egg_gold_broken.png");
                }
                catch { pbEgg.BackColor = Color.Red; }

                // 2. Dừng mọi hoạt động
                tmEgg.Stop();      // Trứng dừng rơi
                tmChicken.Stop();  // Gà dừng bay

                // 3. Hiện thông báo
                MessageBox.Show("Toang rồi! Trứng đã vỡ.\nGAME OVER!", "Thua cuộc");

                // (Tùy chọn) Muốn đóng game luôn thì dùng lệnh này:
                // this.Close(); 

                return; // Thoát ra, không chạy code bên dưới nữa
            }

            // b. Kiểm tra va chạm với GIỎ -> HỨNG ĐƯỢC
            Rectangle unionRect = Rectangle.Intersect(pbEgg.Bounds, pbBasket.Bounds);
            if (unionRect.IsEmpty == false)
            {
                ResetEgg(); // Hứng được thì reset để rơi quả mới
            }

            pbEgg.Location = new Point(xEgg, yEgg);
        }

        // Hàm Reset trứng
        void ResetEgg()
        {
            yEgg = 30;
            xEgg = pbChicken.Location.X + 20;
            try { pbEgg.Image = Image.FromFile(@"D:\C#\nguyenthuanthao_2123110089\example/Images/egg_gold.png"); } catch { pbEgg.BackColor = Color.Gold; }
        }

        // --- 5. ĐIỀU KHIỂN GIỎ ---
        private void FormBai28_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 39 && (xBasket < this.ClientSize.Width - pbBasket.Width))
                xBasket += xDeltaBasket;

            if (e.KeyValue == 37 && xBasket > 0)
                xBasket -= xDeltaBasket;

            pbBasket.Location = new Point(xBasket, yBasket);
        }
    }
}