using System.Collections.Generic;
using System.Threading.Tasks;
using Domain.Entity;
using Domain.ServiceModel;
using Domain.ServiceResponse.ClinicService;

namespace Core.Services.ServiceInterface
{
    public interface IHospitalService
    {
        Task<BaseResponse<ClinicModel>> GetClinicGeneralInfo(int clinicId);
        Task<BaseResponse<List<DoctorModel>>> GetDoctorListByClinicId(int clinicId);
        Task<BaseResponse<ClinicUsersCommentResponse>> GetClinicCommentsListByClinicId(int clinicId);
    }
}