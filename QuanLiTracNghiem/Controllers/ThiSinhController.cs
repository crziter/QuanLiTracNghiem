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
            var content = Ultilities.GetWeb(Ultilities.DS_THI_SINH);
            List<ThiSinh> tss = JsonConvert.DeserializeObject<List<ThiSinh>>(content);
            return tss;
        }

        public void Delete(ThiSinh t)
        {
            
        }

        public bool Update(int id, ThiSinh t)
        {
            var dic = new Dictionary<string, string>();
            dic.Add("id", id.ToString());
            return Ultilities.PatchWeb(Ultilities.UPDATE_THI_SINH, JsonConvert.SerializeObject(t), dic);
        }
    }
}
