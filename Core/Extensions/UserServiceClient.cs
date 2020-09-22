using System.Net.Http;

namespace Core.Extensions
{
    public class UserServiceClient : BaseClient
    {
        public UserServiceClient(HttpClient client) : base(client)
        {

        }
    }
}