using System.Net.Http;

namespace Core.Extensions
{
    public class MailServiceClient : BaseClient
    {
        public MailServiceClient(HttpClient client) : base(client)
        {

        }
    }
}
