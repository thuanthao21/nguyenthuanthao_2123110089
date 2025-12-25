using System;
using System.Drawing;
using System.Windows.Forms;

namespace example
{
    public partial class FormBai29 : Form
    {
        // Khai báo 3 User Control (3 màn hình con)
        Login l = new Login();
        Question q = new Question();
        Finish f = new Finish();

        public FormBai29()
        {
            InitializeComponent();
        }

        private void FormBai29_Load(object sender, EventArgs e)
        {
            // 1. Cài đặt Form chính
            this.ClientSize = new Size(600, 380); // Kích thước vừa với User Control
            this.Text = "Chương trình thi trắc nghiệm (Bài 29)";

            // 2. Đặt vị trí 3 màn hình chồng khít lên nhau tại góc (0,0)
            l.Location = new Point(0, 0);
            q.Location = new Point(0, 0);
            f.Location = new Point(0, 0);

            // 3. Mặc định hiện màn hình Login đầu tiên
            this.Controls.Add(l);

            // 4. Gắn sự kiện cho các nút bấm (Vì đã public nên gọi được)

            // --- Màn hình Login ---
            l.btStart.Click += new EventHandler(btStart_Click); // Nút Tiếp tục
            l.btExit.Click += new EventHandler(btExit_Click);   // Nút Thoát

            // --- Màn hình Question ---
            q.btBack.Click += new EventHandler(btBack_Click);     // Nút Quay lại
            q.btSubmit.Click += new EventHandler(btSubmit_Click); // Nút Nộp bài

            // --- Màn hình Finish ---
            f.btEnd.Click += new EventHandler(btEnd_Click);       // Nút Kết thúc
        }

        // --- CÁC HÀM XỬ LÝ CHUYỂN CẢNH ---

        // Login -> Question
        void btStart_Click(object sender, EventArgs e)
        {
            this.Controls.Remove(l); // Gỡ Login
            this.Controls.Add(q);    // Hiện Question
        }

        // Thoát ngay từ Login
        void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Question -> Login (Quay lại)
        void btBack_Click(object sender, EventArgs e)
        {
            this.Controls.Remove(q);
            this.Controls.Add(l);
        }

        // Question -> Finish (Nộp bài)
        void btSubmit_Click(object sender, EventArgs e)
        {
            this.Controls.Remove(q);
            this.Controls.Add(f);
        }

        // Kết thúc chương trình
        void btEnd_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}