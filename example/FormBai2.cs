using System;
using System.Windows.Forms;
using System.IO;                // Thư viện đọc ghi file
using System.Xml.Serialization; // Thư viện xử lý XML

namespace example
{
    public partial class FormBai2 : Form
    {
        
        string path = @"D:\form_bai2.xml";

        public FormBai2()
        {
            InitializeComponent();
        }

        // --- HÀM GHI FILE  ---
        public void Write(InfoWindows iw)
        {
            try
            {
                XmlSerializer writer = new XmlSerializer(typeof(InfoWindows));
                StreamWriter file = new StreamWriter(path);
                writer.Serialize(file, iw);
                file.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi file: " + ex.Message);
            }
        }

        // --- HÀM ĐỌC FILE  ---
        public InfoWindows Read()
        {
            try
            {
                // Kiểm tra xem file có tồn tại không trước khi đọc
                if (!File.Exists(path)) return null;

                XmlSerializer reader = new XmlSerializer(typeof(InfoWindows));
                StreamReader file = new StreamReader(path);
                // Đọc dữ liệu từ file và ép kiểu về InfoWindows
                InfoWindows iw = (InfoWindows)reader.Deserialize(file);
                file.Close();
                return iw;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi đọc file: " + ex.Message);
                return null;
            }
        }

        // --- SỰ KIỆN LOAD FORM ---
        // Khi mở Form lên -> Đọc file -> Chỉnh lại độ rộng/cao
        private void FormBai2_Load(object sender, EventArgs e)
        {
            InfoWindows iw = Read();
            if (iw != null) // Nếu đọc được dữ liệu
            {
                this.Width = iw.Width;
                this.Height = iw.Height;
            }
        }

        // --- SỰ KIỆN THAY ĐỔI KÍCH THƯỚC  ---
        // Khi kéo thả xong -> Lưu kích thước mới
        private void FormBai2_ResizeEnd(object sender, EventArgs e)
        {
            InfoWindows iw = new InfoWindows();
            iw.Width = this.Size.Width;
            iw.Height = this.Size.Height;
            Write(iw);
        }
    }
}