using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiTracNghiem.Models
{
    class MonThi
    {
        public int id { get; set; }
        public string ten { get; set; }

        public override string ToString()
        {
            return ten;
        }
    }
}
