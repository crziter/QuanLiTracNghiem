using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiTracNghiem.Models
{
    class DeThi
    {
        public int id { get; set; }
        public int mon_thi_id { get; set; }

        public override string ToString()
        {
            return "Đề " + id;
        }
    }
}
