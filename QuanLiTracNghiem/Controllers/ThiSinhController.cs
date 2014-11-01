using QuanLiTracNghiem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace QuanLiTracNghiem.Controllers
{
    class ThiSinhController
    {
        private UserControl _view;

        public ThiSinhController(UserControl view)
        {
            _view = view;
        }

        public List<ThiSinh> GetAll()
        {
            var content = Ultilities.Get(Ultilities.DS_THI_SINH);
            List<ThiSinh> tss = JsonConvert.DeserializeObject<List<ThiSinh>>(content);
            return tss;
        }

        public bool New(ThiSinh ts)
        {
            return Ultilities.Post(Ultilities.INSERT_THI_SINH, JsonConvert.SerializeObject(ts));
        }

        public bool Update(int id, ThiSinh t)
        {
            var dic = new Dictionary<string, string>();
            return Ultilities.Patch(string.Format(Ultilities.UPDATE_THI_SINH, id), JsonConvert.SerializeObject(t));
        }
    }
}
