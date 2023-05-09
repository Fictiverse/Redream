using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Redream
{
    internal class API
    {
        class AutomaticJsonGetModels
        {
            public string title = "";
            public string model_name = "";
            public string hash = "";
            public string filename = "";
            public string config = "";
        }

        public static async Task API_RefreshModels(string IP)
        {
            var client = new HttpClient();
            var content = new System.Net.Http.StringContent("", Encoding.UTF8, "application/json");
            var request = new HttpRequestMessage
            {
                RequestUri = new Uri("http://" + IP + "/sdapi/v1/refresh-checkpoints"),
                Method = HttpMethod.Get,
                Content = content
            };

            try
            {
                var response = await client.SendAsync(request);
            }
            catch { }
        }

        public static async Task<JArray> API_GetModels(string IP)
        {
            var client = new HttpClient();
            var content = new System.Net.Http.StringContent("", Encoding.UTF8, "application/json");
            var request = new HttpRequestMessage
            {
                RequestUri = new Uri("http://" + IP + "/sdapi/v1/sd-models"),
                Method = HttpMethod.Get,
                Content = content
            };

            try
            {
                var response = await client.SendAsync(request);
                var jsonRaw = await response.Content.ReadAsStringAsync();
                var jArray = JsonConvert.DeserializeObject<JArray>(jsonRaw);
                return jArray;
            }
            catch { return null; }
        }
        public static async Task<string> API_GetCurrentModel(string IP)
        {
            var client = new HttpClient();
            var content = new System.Net.Http.StringContent("", Encoding.UTF8, "application/json");
            var request = new HttpRequestMessage
            {
                RequestUri = new Uri("http://" + IP + "/sdapi/v1/options"),
                Method = HttpMethod.Get,
                Content = content
            };

            try
            {
                var response = await client.SendAsync(request);
                var jsonRaw = await response.Content.ReadAsStringAsync();

                JObject obj = JObject.Parse(jsonRaw);
                string value = (string)obj["sd_model_checkpoint"];
                return value;
            }
            catch { return null; }
        }



        class AutomaticJsonSetModels
        {
            public string sd_model_checkpoint = "";
        }

        public static async Task API_SetModel(string IP, string model)
        {
            AutomaticJsonSetModels payload = new AutomaticJsonSetModels();
            payload.sd_model_checkpoint = model;

            string json = JsonConvert.SerializeObject(payload);

            var client = new HttpClient();
            var content = new System.Net.Http.StringContent(json, Encoding.UTF8, "application/json");
            var request = new HttpRequestMessage
            {
                RequestUri = new Uri("http://" + IP + "/sdapi/v1/options"),
                Method = HttpMethod.Post,
                Content = content
            };
            try
            {
                var response = await client.SendAsync(request);
            }
            catch { }
        }


    }
}
