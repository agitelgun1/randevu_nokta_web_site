using System.Collections.Generic;
using System.Threading.Tasks;
using Domain.Entity;
using Domain.ServiceModel;
using Domain.ServiceResponse.ClinicService;

namespace Core.Services
{
    public interface IDoctorService
    {
        Task<string> AutoComplete(string term);
        Task<IEnumerable<UsersComment>> LoadMoreComment(string doctorId, int size);
        Task<BaseResponse<DoctorModel>> GetDoctorGeneralInfo(int doctor_id);
        Task<BaseResponse<List<ClinicModel>>> GetClinicListByDoctorId(int doctor_id);
        Task<BaseResponse<List<BranchModel>>> GetBranchListByDoctorId(int doctor_id);
        Task<BaseResponse<List<ProfessionModel>>> GetProfessionListByDoctorId(int doctor_id);
        Task<BaseResponse<List<DoctorExperienceModel>>> GetExperienceListByDoctorId(int doctor_id);
        Task<BaseResponse<List<InsuranceModel>>> GetInsuranceListByDoctorId(int doctor_id);
        Task<BaseResponse<List<TreatmentModel>>> GetTreatmentListByDoctorId(int doctor_id);
        Task<BaseResponse<List<LanguageModel>>> GetLanguageListByDoctorId(int doctor_id);
        Task<BaseResponse<DoctorUsersCommentResponse>> GetDoctorCommentsListByDoctorId(int doctorId);
        Task<BaseResponse<List<PaymentMethods>>> GetMethodListByDoctorId(int doctorId);
    }
}