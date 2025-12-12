using System;
using System.Windows.Forms;
using System.IO;                // Để đọc ghi file
using System.Xml.Serialization; // Để xử lý XML
using System.Drawing;           // Để xử lý Point (Vị trí)

namespace example
{
    public partial class FormBai5 : Form
    {
        // Đường dẫn file lưu cấu hình riêng cho Bài 5
        string path = @"D:\config_bai5.xml";

        public FormBai5()
        {
            InitializeComponent();
        }

        // --- PHẦN 1: LOGIC NÚT OK  ---
        private void bt_OK_Click(object sender, EventArgs e)
        {
            // Code xử lý khi bấm nút OK
            string thongTin = "Bạn đã nhập dữ liệu thành công!";
            MessageBox.Show(thongTin);
        }

        // --- PHẦN 2: LOGIC LƯU TRẠNG THÁI FORM  ---

        // Hàm Ghi
        public void Write(InfoWindows iw)
        {
            try
            {
                XmlSerializer writer = new XmlSerializer(typeof(InfoWindows));
                StreamWriter file = new StreamWriter(path);
                writer.Serialize(file, iw);
                file.Close();
            }
            catch (Exception ex) { MessageBox.Show("Lỗi ghi: " + ex.Message); }
        }

        // Hàm Đọc
        public InfoWindows Read()
        {
            try
            {
                if (!File.Exists(path)) return null;
                XmlSerializer reader = new XmlSerializer(typeof(InfoWindows));
                StreamReader file = new StreamReader(path);
                InfoWindows iw = (InfoWindows)reader.Deserialize(file);
                file.Close();
                return iw;
            }
            catch (Exception) { return null; }
        }

        // Sự kiện Form Load: Đọc file để khôi phục vị trí cũ
        private void FormBai5_Load(object sender, EventArgs e)
        {
            InfoWindows iw = Read();
            if (iw != null)
            {
                this.Width = iw.Width;
                this.Height = iw.Height;
                this.Location = iw.Location;
            }
        }

        private void FormBai5_FormClosing(object sender, FormClosingEventArgs e)
        {
            InfoWindows iw = new InfoWindows();
            iw.Width = this.Size.Width;
            iw.Height = this.Size.Height;
            iw.Location = this.Location;
            Write(iw);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}