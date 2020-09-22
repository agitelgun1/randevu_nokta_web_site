using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace Core.Extensions
{
    public class AuthServiceClient : BaseClient
    {
        public AuthServiceClient(HttpClient client) : base(client)
        {

        }
    }
}
