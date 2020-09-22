using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace Core.Extensions
{
    public class CommonServiceClient : BaseClient
    {
        public CommonServiceClient(HttpClient client) : base(client)
        {

        }
    }
}
