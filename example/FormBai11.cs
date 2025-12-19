using System;
using System.Drawing; // Thư viện đồ họa để chỉnh vị trí, màu sắc
using System.Windows.Forms;

namespace example
{
    public partial class FormBai11 : Form
    {
        // --- KHAI BÁO BIẾN ---
        decimal memory = 0;
        decimal workingMemory = 0;
        string opr = "";

        public FormBai11()
        {
            InitializeComponent(); // Gọi giao diện cơ bản (TextBox)
            TaoCacNutBam();        // Gọi hàm tạo nút bấm của mình
        }

        // --- HÀM TẠO NÚT TỰ ĐỘNG (Dời từ Designer sang đây) ---
        private void TaoCacNutBam()
        {
            string[] buttonLabels = {
                "MC", "MR", "MS", "M+", "M-",
                "←", "CE", "C", "±", "√",
                "7", "8", "9", "/", "%",
                "4", "5", "6", "*", "1/x",
                "1", "2", "3", "-", "=",
                "0", ".", "+"
            };

            int x = 12, y = 60;
            int w = 65, h = 50;
            int margin = 8;

            for (int i = 0; i < buttonLabels.Length; i++)
            {
                Button btn = new Button();
                btn.Text = buttonLabels[i];
                btn.Name = "bt" + buttonLabels[i];
                btn.Size = new Size(w, h);
                btn.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
                btn.Location = new Point(x, y);

                // Gắn sự kiện Click
                btn.Click += new EventHandler(Button_Click);

                // Xử lý nút 0 và nút =
                if (buttonLabels[i] == "0") { btn.Width = w * 2 + margin; x += w + margin; }
                else if (buttonLabels[i] == "=") { btn.Height = h * 2 + margin; btn.Location = new Point(x, y - h - margin); }

                this.Controls.Add(btn);

                // Tính toán vị trí tiếp theo
                x += w + margin;
                if ((i + 1) % 5 == 0) { x = 12; y += h + margin; }
            }
        }

        // --- HÀM XỬ LÝ SỰ KIỆN (Logic tính toán) ---
        private void Button_Click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            string text = bt.Text;

            if ((char.IsDigit(text, 0) && text.Length == 1) || text == ".")
            {
                if (txtDisplay.Text == "0" && text != ".") txtDisplay.Clear();
                if (text == "." && txtDisplay.Text.Contains(".")) return;
                txtDisplay.Text += text;
            }
            else if (text == "+" || text == "-" || text == "*" || text == "/")
            {
                opr = text;
                workingMemory = decimal.Parse(txtDisplay.Text);
                txtDisplay.Clear();
            }
            else if (text == "=")
            {
                decimal secondValue = decimal.Parse(txtDisplay.Text);
                switch (opr)
                {
                    case "+": txtDisplay.Text = (workingMemory + secondValue).ToString(); break;
                    case "-": txtDisplay.Text = (workingMemory - secondValue).ToString(); break;
                    case "*": txtDisplay.Text = (workingMemory * secondValue).ToString(); break;
                    case "/":
                        if (secondValue != 0) txtDisplay.Text = (workingMemory / secondValue).ToString();
                        else MessageBox.Show("Lỗi chia cho 0");
                        break;
                }
            }
            // Các nút chức năng khác
            else if (text == "C") { workingMemory = 0; opr = ""; txtDisplay.Text = "0"; }
            else if (text == "CE") txtDisplay.Text = "0";
            else if (text == "←")
            {
                if (txtDisplay.TextLength > 0) txtDisplay.Text = txtDisplay.Text.Remove(txtDisplay.TextLength - 1);
                if (txtDisplay.Text == "") txtDisplay.Text = "0";
            }
            // (Bạn có thể thêm các logic √, %, 1/x, M+... vào đây như bài trước nếu cần)
        }
    }
}