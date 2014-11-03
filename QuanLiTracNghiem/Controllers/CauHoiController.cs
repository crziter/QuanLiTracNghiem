using Newtonsoft.Json;
using QuanLiTracNghiem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiTracNghiem.Controllers
{

    class CauHoiController
    {
        public static string ALL_CAUHOI_BY_DETHI = "api/cau_hoi/{0}/list_with_da.json";
        public static string UPDATE_CAUHOI = "/api/cau_hoi/{0}.json";
        public static string CAUHOI = "/api/cau_hoi.json";
        public static string SET_CAUHOI_TO_DETHI = "/api/de_thi/add_cau_hoi.json";
        public List<Models.CauHoi> GetAllCauHoi(Models.DeThi dethi)
        {
            return Ultilities.ListObjects<Models.CauHoi>(string.Format(ALL_CAUHOI_BY_DETHI, dethi.id));
        }

        public Result Update(Models.CauHoi cauhoi)
        {
            return Ultilities.Update<Models.CauHoi>(String.Format(UPDATE_CAUHOI, cauhoi.id), cauhoi);

        }

        public Result Add( Models.CauHoi cauhoi)
        {
            return  Ultilities.Post(CAUHOI, JsonConvert.SerializeObject(cauhoi));
        }

        public Result SetCauHoiToDeThi(Models.DeThi dethi, Models.CauHoi cauhoi)
        {
            DeThiCauHoi dtch = new DeThiCauHoi();

            dtch.de_thi_id = dethi.id;
            dtch.cau_hoi_id = cauhoi.id;
            var rs = Ultilities.Post(SET_CAUHOI_TO_DETHI, JsonConvert.SerializeObject(dtch));
            return rs;
        }

    }
}
