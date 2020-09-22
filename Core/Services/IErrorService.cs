using System.Threading.Tasks;
using Domain.Entity;

namespace Core.Services
{
    public interface IErrorService
    {
        Task<bool> InsertErrorLog(ErrorLog errorLog);
    }
}