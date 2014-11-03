using QuanLiTracNghiem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiTracNghiem.Controllers
{
    class DeThiController
    {
        public static string ALL_MONTHI = "api/mon_thi.json";
        public static string UPDATE_MONTHI = "api/mon_thi/{0}.json"; // id

        public static string ALL_DETHI_BY_MONTHI = "api/de_thi/{0}/list.json"; // id

        private UserControl _view;

        public DeThiController(UserControl view)
        {
            this._view = view;
        }

        public List<Models.MonThi> GetAllMonThi()
        {
            return Ultilities.ListObjects<MonThi>(ALL_MONTHI);
        }

        public void Update(int id, MonThi mt)
        {
            Ultilities.Update<MonThi>(string.Format(UPDATE_MONTHI, id), mt);
        }

        public List<DeThi> GetAllDeThi(MonThi mt)
        {
            return Ultilities.ListObjects<DeThi>(string.Format(ALL_DETHI_BY_MONTHI, mt.id));
        }


    }
}
