using IdentityModel.Client;
using Newtonsoft.Json.Linq;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Client1.ClientCredentials
{
    class Program
    {
        private static async Task Main()
        {
            //使用identityModel提供的拓展方法发送请求
            //IRequest req = new RequestByIdentityModel();
            //原生请求
            IRequest req = new RequestByHttpClient();
            await req.GetTokenRequestApiAsync();
        }
    }
}
