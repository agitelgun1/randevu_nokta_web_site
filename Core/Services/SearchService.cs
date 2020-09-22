using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Domain.ServiceModel;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;

namespace Core.Services
{
    public class SearchService : ISearchService
    {
        private readonly IConfiguration _configuration;
        public SearchService(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        
        public async Task<AutocompleteResponse> AutoComplete(string term,string cityId,string districtId)
        {
            var response = new AutocompleteResponse();
            
            using (var client = new HttpClient()) 
            {
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;

                var responseData = await client.PostAsync($"{_configuration["SearchServiceConfig:Url"]}api/autocomplete?searchText={term}&cityId={cityId}&districtId={districtId}",
                    new StringContent("",Encoding.UTF8));
                
                var json = responseData.Content.ReadAsStringAsync().Result;
                response = JsonConvert.DeserializeObject<AutocompleteResponse>(json);
                return response;
            }
        }
        
        public async Task<object> DoctorSearchByTerm(string term, int cityId, int districtId, double lat, double lng)
        {
            using (var client = new HttpClient()) 
            {
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;

                var responseData = await client.GetAsync($"{_configuration["SearchServiceConfig:Url"]}api/doctorsearch?term={term}&district={districtId}&city={cityId}&lat={lat}&lng={lng}");
                
                var json = responseData.Content.ReadAsStringAsync().Result;
                var response = JsonConvert.DeserializeObject(json);
                return response;
            }
        }
        
        public async Task<object> ClinicSearchByTerm(string term, int cityId, int districtId, double lat, double lng,int pageIndex,int pageSize)
        {
            using (var client = new HttpClient()) 
            {
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;

                var responseData = await client.GetAsync($"{_configuration["SearchServiceConfig:Url"]}api/clinicsearch?term={term}&district={districtId}&city={cityId}&lat={lat}&lng={lng}&pageIndex={pageIndex}&pageSize={pageSize}");
                
                var json = responseData.Content.ReadAsStringAsync().Result;
                var response = JsonConvert.DeserializeObject(json);
                return response;
            }
        }
    }
}