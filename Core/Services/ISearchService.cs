using System.Threading.Tasks;
using Domain.ServiceModel;

namespace Core.Services
{
    public interface ISearchService
    {
        Task<AutocompleteResponse> AutoComplete(string term,string cityId,string districtId);
        Task<object> DoctorSearchByTerm(string term, int cityId, int districtId, double lat, double lng);
        Task<object> ClinicSearchByTerm(string term, int cityId, int districtId, double lat, double lng,int pageIndex,int pageSize);
    }
}