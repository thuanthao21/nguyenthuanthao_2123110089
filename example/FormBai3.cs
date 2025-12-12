using System;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;
using System.Drawing; // Thêm dòng này để xử lý Point/Location

namespace example
{
    public partial class FormBai3 : Form
    {
        // Đặt tên file riêng cho bài 3
        string path = @"D:\form_bai3.xml";

        public FormBai3()
        {
            InitializeComponent();
        }

        // --- HÀM GHI FILE ---
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

        // --- HÀM ĐỌC FILE  ---
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
            catch (Exception ex) { return null; }
        }

        // --- SỰ KIỆN KHI MỞ FORM (LOAD) ---
        private void FormBai3_Load(object sender, EventArgs e)
        {
            InfoWindows iw = Read();
            if (iw != null)
            {
                this.Width = iw.Width;
                this.Height = iw.Height;
                // Khôi phục vị trí cũ (Slide 39)
                this.Location = iw.Location;
            }
        }

        // --- SỰ KIỆN KHI TẮT FORM (CLOSING) ---
        // Lưu ý: Bài này dùng sự kiện FormClosing thay vì ResizeEnd
        private void FormBai3_FormClosing(object sender, FormClosingEventArgs e)
        {
            InfoWindows iw = new InfoWindows();
            iw.Width = this.Size.Width;
            iw.Height = this.Size.Height;
            // Lưu vị trí hiện tại 
            iw.Location = this.Location;

            Write(iw);
        }
    }
}