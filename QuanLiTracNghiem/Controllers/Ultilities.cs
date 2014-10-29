using Newtonsoft.Json;
using QuanLiTracNghiem.Models;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiTracNghiem.Controllers
{
    class Ultilities
    {
        public static string HOST = "http://crziter.me:3000";
        public static string DS_MON_THI = "api/mon_thi.json";
        public static string DS_THI_SINH = "api/thi_sinh.json";
        public static string UPDATE_THI_SINH = "api/thi_sinh/{id}.json";

        public static string WebContent(string uri, Method method, string data, Dictionary<string, string> pars)
        {
            var client = new RestClient(HOST);
            var request = new RestRequest(uri, method);
            request.RequestFormat = DataFormat.Json;

            if (pars != null)
            {
                foreach (var p in pars)
                {
                    request.AddUrlSegment(p.Key, p.Value);
                }
            }

            if (method == Method.POST || method == Method.PUT || method == Method.PATCH)
            {
                if (data != null)
                    request.AddBody(data);
            }

            RestResponse response = (RestResponse) client.Execute(request);
            return response.Content;
        }

        public static string GetWeb(string url)
        {
            return WebContent(url, Method.GET, null, null);
        }

        public static bool Delete(string url)
        {
            string content = WebContent(url, Method.DELETE, null, null);
            return false;
        }

        public static bool PatchWeb(string url, string data, Dictionary<string, string> dic)
        {
            string content = WebContent(url, Method.PATCH, data, dic);

            Result rs = JsonConvert.DeserializeObject<Result>(content);
            if (rs.status != null && rs.status.Equals("ok")) return true;
            return false;
        }
    }
}
