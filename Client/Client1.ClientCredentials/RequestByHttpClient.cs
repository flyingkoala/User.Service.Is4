using Client1.ClientCredentials.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Text;
using System.Threading.Tasks;

namespace Client1.ClientCredentials
{
    public class RequestByHttpClient : IRequest
    {
        /// <summary>
        /// 不依赖IdentityModel框架获取accesstoken和请求api资源
        /// </summary>
        /// <returns></returns>
        public async Task GetTokenRequestApiAsync()
        {
            string data = string.Empty;

            //获取accesstoken
            string url = "http://localhost:5000/connect/token";
            using (HttpClient client = new HttpClient())
            {
                client.Timeout = new TimeSpan(0, 0, 60);
                var body = new FormUrlEncodedContent(new Dictionary<string, string>
                {
                    { "grant_type", "client_credentials"},
                    { "client_id", "client1"},
                    { "client_secret", "client1_123456"}
                });
                // response
                var response = await client.PostAsync(url, body);
                data = response.Content.ReadAsStringAsync().Result;
                Console.WriteLine(data);
            }
            //携带accesstoken请求api接口
            ResponseModel repmodel = JsonConvert.DeserializeObject<ResponseModel>(data);
            string apiurl = "http://localhost:5010/identity";
            using (HttpClient client = new HttpClient())
            {
                client.Timeout = new TimeSpan(0, 0, 60);
                client.DefaultRequestHeaders.Add("Authorization", $"{repmodel.token_type} {repmodel.access_token}");
                var response = await client.GetAsync(apiurl);
                data = response.Content.ReadAsStringAsync().Result;
                Console.WriteLine(data);
            }


            Console.ReadLine();
        }
    }
}
