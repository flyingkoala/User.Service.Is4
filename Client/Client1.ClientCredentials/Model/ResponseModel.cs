using System;
using System.Collections.Generic;
using System.Text;

namespace Client1.ClientCredentials.Model
{
    public class ResponseModel
    {
        public string access_token { get; set; }
        public string expires_in { get; set; }
        public string token_type { get; set; }
    }
}
