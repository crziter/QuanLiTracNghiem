using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiTracNghiem.Models
{
    class ThiSinh
    {
        public int id { get; set; }
        public string ten_dang_nhap { get; set; }
        public string ten_that { get; set; }
        public string mat_khau { get; set; }
        public string email { get; set; }
        public bool? active { get; set; }
    }
}
