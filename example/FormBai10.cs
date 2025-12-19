using System;
using System.Windows.Forms;

namespace example
{
    public partial class FormBai10 : Form
    {
        // --- KHAI BÁO BIẾN DÙNG CHUNG (Slide 78) ---
        decimal workingMemory = 0; // Bộ nhớ lưu số đầu tiên
        string opr = "";           // Lưu phép toán (+, *, ...)

        public FormBai10()
        {
            InitializeComponent();
        }

        // --- NHÓM 1: XỬ LÝ CÁC NÚT SỐ (Slide 78) ---
        // Khi bấm số, ta nối thêm số đó vào màn hình

        private void bt0_Click(object sender, EventArgs e)
        {
            tbDisplay.Text += "0";
        }

        private void bt1_Click(object sender, EventArgs e)
        {
            tbDisplay.Text += "1"; // Hoặc dùng: tbDisplay.Text += bt1.Text;
        }

        private void bt2_Click(object sender, EventArgs e)
        {
            tbDisplay.Text += "2";
        }

        private void bt3_Click(object sender, EventArgs e)
        {
            tbDisplay.Text += "3";
        }

        private void btDot_Click(object sender, EventArgs e)
        {
            // Kiểm tra: Nếu chưa có dấu chấm thì mới cho thêm (tránh lỗi 12.0.5)
            if (!tbDisplay.Text.Contains("."))
            {
                tbDisplay.Text += ".";
            }
        }

        // --- NHÓM 2: XỬ LÝ PHÉP TÍNH (Slide 79 - btPlus) ---
        // Khi bấm +, *, ta lưu số hiện tại vào bộ nhớ và xóa màn hình để nhập số mới

        private void btPlus_Click(object sender, EventArgs e)
        {
            opr = "+"; // Lưu dấu cộng
            workingMemory = decimal.Parse(tbDisplay.Text); // Lưu số đang có
            tbDisplay.Clear(); // Xóa màn hình
        }

        private void btMul_Click(object sender, EventArgs e)
        {
            opr = "*"; // Lưu dấu nhân
            workingMemory = decimal.Parse(tbDisplay.Text);
            tbDisplay.Clear();
        }

        // --- NHÓM 3: XỬ LÝ DẤU BẰNG (Slide 79 - btEquals) ---
        // Lấy số thứ 2, kết hợp với số trong bộ nhớ và phép tính để ra kết quả

        private void btEquals_Click(object sender, EventArgs e)
        {
            decimal secondValue = decimal.Parse(tbDisplay.Text); // Số thứ 2 mới nhập

            if (opr == "+")
            {
                tbDisplay.Text = (workingMemory + secondValue).ToString();
            }

            if (opr == "*")
            {
                tbDisplay.Text = (workingMemory * secondValue).ToString();
            }
        }
    }
}