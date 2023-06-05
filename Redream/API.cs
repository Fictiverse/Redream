using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Redream.MyFunctions;

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
        public static async Task AutomaticInterrupt(string URI)
        {

            var client = new HttpClient();
            var content = new System.Net.Http.StringContent("", Encoding.UTF8, "application/json");


            try
            {
                var request = new HttpRequestMessage
                {
                    RequestUri = new Uri("http://" + URI + "/sdapi/v1/interrupt"),
                    Method = HttpMethod.Post,
                    Content = content
                };
                var response = await client.SendAsync(request);
            }
            catch { }

        }

        class AutomaticInterrogateStruct
        {
            public string image = "";
            public string model = "clip";
        }

        public static async Task<string> AutomaticInterrogate(string URI, Bitmap image )
        {
            string base64Image = "data:image/png;base64," + Convert.ToBase64String(ImageToBytes(image));
            var struc = new AutomaticInterrogateStruct
            {
                image = base64Image
            };

            try
            {
                string json = JsonConvert.SerializeObject(struc);
                var client = new HttpClient();
                var content = new System.Net.Http.StringContent(json, Encoding.UTF8, "application/json");
                var request = new HttpRequestMessage
                {
                    RequestUri = new Uri("http://" + URI + "/sdapi/v1/interrogate"),
                    Method = HttpMethod.Post,
                    Content = content
                };
                var response = await client.SendAsync(request);
                dynamic responseD = JsonConvert.DeserializeObject(await response.Content.ReadAsStringAsync());
                return responseD.caption.ToString();
            }
            catch { return null; }
        }

        public static async Task API_RefreshModels(string IP)
        {
            var client = new HttpClient();
            var content = new System.Net.Http.StringContent("", Encoding.UTF8, "application/json");


            try
            {
                var request = new HttpRequestMessage
                {
                    RequestUri = new Uri("http://" + IP + "/sdapi/v1/refresh-checkpoints"),
                    Method = HttpMethod.Get,
                    Content = content
                };
                var response = await client.SendAsync(request);
            }
            catch { }
        }

        public static async Task<JArray> API_GetModels(string IP)
        {
            var client = new HttpClient();
            var content = new System.Net.Http.StringContent("", Encoding.UTF8, "application/json");

            try
            {
                var request = new HttpRequestMessage
                {
                    RequestUri = new Uri("http://" + IP + "/sdapi/v1/sd-models"),
                    Method = HttpMethod.Get,
                    Content = content
                };

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


            try
            {
                var request = new HttpRequestMessage
                {
                    RequestUri = new Uri("http://" + IP + "/sdapi/v1/options"),
                    Method = HttpMethod.Get,
                    Content = content
                };
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

            try
            {
                var request = new HttpRequestMessage
                {
                    RequestUri = new Uri("http://" + IP + "/sdapi/v1/options"),
                    Method = HttpMethod.Post,
                    Content = content
                };
                var response = await client.SendAsync(request);
            }
            catch { }
        }


        public static async Task<string[]> Get_ControlNet_ModelList(string IP)
        {
            var client = new HttpClient();
            var content = new System.Net.Http.StringContent("", Encoding.UTF8, "application/json");


            try
            {
                var request = new HttpRequestMessage
                {
                    RequestUri = new Uri("http://" + IP + "/controlnet/model_list"),
                    Method = HttpMethod.Get,
                    Content = content
                };
                var response = await client.SendAsync(request);

                var json = await response.Content.ReadAsStringAsync();
                var responseObject = JsonConvert.DeserializeObject<Dictionary<string, List<string>>>(json);
                List<string> modelList = responseObject["model_list"];

                return modelList.ToArray();
            }
            catch { return null; }
        }





    }
}
