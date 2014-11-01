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
        
        public static string DS_THI_SINH = "api/thi_sinh.json";
        public static string INSERT_THI_SINH = "api/thi_sinh.json";
        public static string UPDATE_THI_SINH = "api/thi_sinh/{0}.json"; // ID

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
                    // request.AddBody(data);
                    request.AddParameter("application/json", data, ParameterType.RequestBody);
            }

            RestResponse response = (RestResponse) client.Execute(request);
            return response.Content;
        }


        public static List<T> GetListObject<T>(string url)
        {
            List<T> _rs = new List<T>();
            string content = Get(url);

            _rs = JsonConvert.DeserializeObject<List<T>>(content);

            return _rs;
        }

        public static string Get(string url)
        {
            return WebContent(url, Method.GET, null, null);
        }

        public static bool Patch(string url, string data)
        {
            string content = WebContent(url, Method.PATCH, data, null);

            Result rs = JsonConvert.DeserializeObject<Result>(content);
            if (rs.status != null) {
                if (rs.status.Equals("ok")) return true;
                else throw new Exception(rs.reason);
            } else throw new Exception("Unknow reason");
        }

        public static bool Post(string url, string data)
        {
            string content = WebContent(url, Method.POST, data, null);

            Result rs = JsonConvert.DeserializeObject<Result>(content);
            if (rs.status != null) {
                if (rs.status.Equals("ok")) return true;
                else
                {
                    throw new Exception(rs.reason);
                }
            }

            return false;
        }

        public static bool Update<T1>(string url, T1 obj)
        {
            return Patch(url, JsonConvert.SerializeObject(obj));
        }
    }
}
