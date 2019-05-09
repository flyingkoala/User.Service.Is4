using System;
using System.Collections.Generic;
using System.Text;

namespace Client1.ClientCredentials.Model
{
    public class RequestTokenModel
    {
        public string grant_type { get; set; }
        public string client_id { get; set; }
        public string client_secret { get; set; }
    }
}
