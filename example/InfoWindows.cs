using System;
using System.Drawing; // Cần thêm thư viện này để dùng 'Point'

namespace example
{
    public class InfoWindows
    {
        public int Width { get; set; }
        public int Height { get; set; }
        // Thêm dòng này để lưu vị trí
        public Point Location { get; set; }
    }
}