using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example
{
    public class Employee
    {
        public string Id { get; set; }      // Mã NV
        public string Name { get; set; }    // Tên NV
        public int Age { get; set; }        // Tuổi
        public bool Gender { get; set; }    // Giới tính (Nam/Nữ)
    }
}