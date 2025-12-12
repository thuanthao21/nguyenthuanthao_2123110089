namespace example
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            FormBai1 bai1 = new FormBai1();
            bai1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormBai2 bai2 = new FormBai2();
            bai2.Show();
        }


        // Visual Studio đang tìm hàm này, thêm vào sẽ hết lỗi dòng 93
        private void button3_Click(object sender, EventArgs e)
        {
            FormBai3 bai3 = new FormBai3();
            bai3.Show();
        }

        private void btn_bai5_Click(object sender, EventArgs e)
        {
            FormBai5 bai5 = new FormBai5();
            bai5.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FormBai4 bai4 = new FormBai4();
            bai4.Show();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            FormBai6 bai6 = new FormBai6();
            bai6.Show();
        }

        private void btn_bai7_Click(object sender, EventArgs e)
        {
            FormBai7 bai7 = new FormBai7();
            bai7.Show();
        }

        private void btn_bai8_Click(object sender, EventArgs e)
        {
            FormBai8 bai8 = new FormBai8();
            bai8.Show();
        }

        private void btn_bai9_Click(object sender, EventArgs e)
        {
            FormBai9 bai9 = new FormBai9();
            bai9.Show();
        }
    }
}
