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
        public static string DS_THI_SINH = "api/thi_sinh.json";
        public static string INSERT_THI_SINH = "api/thi_sinh.json";
        public static string UPDATE_THI_SINH = "api/thi_sinh/{0}.json"; // ID

        private UserControl _view;

        public ThiSinhController(UserControl view)
        {
            _view = view;
        }

        public List<ThiSinh> GetAll()
        {
            var content = Ultilities.Get(DS_THI_SINH);
            List<ThiSinh> tss = JsonConvert.DeserializeObject<List<ThiSinh>>(content);
            return tss;
        }

        public void New(ThiSinh ts)
        {
            var rs = Ultilities.Post(INSERT_THI_SINH, JsonConvert.SerializeObject(ts));
            if (!Ultilities.IsResultOk(rs))
            {
                throw new Exception(rs.reason);
            }
        }

        public void Update(int id, ThiSinh t)
        {
            // var dic = new Dictionary<string, string>();
            var rs = Ultilities.Patch(string.Format(UPDATE_THI_SINH, id), JsonConvert.SerializeObject(t));
            if (!Ultilities.IsResultOk(rs))
            {
                throw new Exception(rs.reason);
            }
        }
    }
}
