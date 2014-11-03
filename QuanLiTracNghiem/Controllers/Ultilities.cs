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
                    request.AddParameter("application/json", data, ParameterType.RequestBody);
            }

            RestResponse response = (RestResponse) client.Execute(request);
            return response.Content;
        }

        public static string Get(string url)
        {
            return WebContent(url, Method.GET, null, null);
        }

        public static string Delete(string url)
        {
            return WebContent(url, Method.DELETE, null, null);
        }

        public static Result Post(string url, string data)
        {
            string content = WebContent(url, Method.POST, data, null);

            Result rs = JsonConvert.DeserializeObject<Result>(content);
            return rs;
        }

        public static Result Patch(string url, string data)
        {
            string content = WebContent(url, Method.PATCH, data, null);

            Result rs = JsonConvert.DeserializeObject<Result>(content);
            return rs;
        }

        public static bool IsResultOk(Result rs)
        {
            if (rs != null)
            {
                if (rs.status.Equals("ok")) return true;
                return false;
            }

            return false;
        }

        public static List<T> ListObjects<T>(string url)
        {
            List<T> _rs = new List<T>();
            string content = Get(url);

            _rs = JsonConvert.DeserializeObject<List<T>>(content);

            return _rs;
        }

        public static Result Update<T1>(string url, T1 obj)
        {
            var rs = Patch(url, JsonConvert.SerializeObject(obj));
            return rs;
        }
    }
}
