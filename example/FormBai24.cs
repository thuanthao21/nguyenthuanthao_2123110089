using System;
using System.Windows.Forms;

namespace example
{
    public partial class FormBai24 : Form
    {
        // Biến đếm số giây (Slide 159)
        int second = 0;

        public FormBai24()
        {
            InitializeComponent();
        }

        // 1. Nút Start: Cấu hình và Bắt đầu Timer
        private void btStart_Click(object sender, EventArgs e)
        {
            // Interval: Khoảng thời gian giữa các lần Tick (tính bằng mili giây)
            // 1000 ms = 1 giây
            tmStopwatch.Interval = 1000;

            // Bắt đầu chạy
            tmStopwatch.Start();
        }

        // 2. Nút Stop: Dừng Timer
        private void btStop_Click(object sender, EventArgs e)
        {
            tmStopwatch.Stop();
        }

        // 3. Sự kiện Tick: Chạy mỗi khi hết khoảng thời gian Interval (mỗi 1 giây)
        private void tmStopwatch_Tick(object sender, EventArgs e)
        {
            second++; // Tăng giây lên

            // Hiển thị ra màn hình
            // Code trong Slide 159 chỉ hiển thị số giây đơn giản
            lblDisplay.Text = second.ToString();

            /* * MỞ RỘNG (Nếu bạn muốn hiển thị đẹp dạng 00:00 như ảnh Slide 158):
             * Bạn có thể thay dòng trên bằng đoạn code này:
             * * TimeSpan t = TimeSpan.FromSeconds(second);
             * lblDisplay.Text = string.Format("{0:D2}:{1:D2}", t.Minutes, t.Seconds);
             */
        }
    }
}