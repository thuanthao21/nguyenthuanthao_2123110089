using System;
using System.Windows.Forms;
// Hai thư viện quan trọng để ghi file XML
using System.IO;
using System.Xml.Serialization;

namespace example
{
    public partial class FormBai1 : Form
    {
        // Đường dẫn file lưu trữ (Lưu ý: Máy bạn phải có ổ D, nếu không hãy đổi thành "C:\\form.xml")
        string path = @"D:\form.xml";

        public FormBai1()
        {
            InitializeComponent();
        }

        // Hàm ghi dữ liệu xuống file (Slide 28)
        public void Write(InfoWindows iw)
        {
            try
            {
                // Tạo đối tượng chuyển đổi sang XML
                XmlSerializer writer = new XmlSerializer(typeof(InfoWindows));
                // Tạo file để ghi
                StreamWriter file = new StreamWriter(path);
                // Ghi dữ liệu
                writer.Serialize(file, iw);
                // Đóng file
                file.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi file: " + ex.Message);
            }
        }

        // Sự kiện khi thay đổi kích thước xong (Slide 29)
        private void FormBai1_ResizeEnd(object sender, EventArgs e)
        {
            InfoWindows iw = new InfoWindows();
            iw.Width = this.Size.Width;
            iw.Height = this.Size.Height;
            Write(iw);
        }

        // Sự kiện khi Form vừa hiện lên (Slide 29)
        private void FormBai1_Load(object sender, EventArgs e)
        {
            InfoWindows iw = new InfoWindows();
            iw.Width = this.Size.Width;
            iw.Height = this.Size.Height;
            Write(iw);
        }
    }
}