using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Core.Extensions;
using Domain.Entity;
using Domain.ServiceModel;
using Domain.ServiceResponse.ClinicService;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;

namespace Core.Services
{
    public class DoctorService : IDoctorService
    {
        private readonly CommonServiceClient _client;
        private readonly IConfiguration _configuration;
        private readonly IErrorService _errorLog;
        public DoctorService(CommonServiceClient client, IConfiguration configuration, IErrorService errorLog)
        {
            _client = client;
            _configuration = configuration;
            _errorLog = errorLog;
        }

        public Task<string> AutoComplete(string term)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IEnumerable<UsersComment>> LoadMoreComment(string doctorId,int size)
        {
            try
            {
                var userCommentList = await GetDoctorUsersComment(doctorId);

                var dataContainer = userCommentList.Result.Comments.OrderBy(x=>x.CreateDate).Skip(size).Take(5);

                return dataContainer;
            }
            catch (Exception e)
            {
                var data = Enumerable.Empty<UsersComment>();

                return data;
            }
        }

        public async Task<BaseResponse<DoctorUsersCommentResponse>> GetDoctorUsersComment(string id)
        {
            try
            {
                var param = new Dictionary<string, string> {{"doctorId", id}};

                var data =
                    await _client.GetObject<BaseResponse<DoctorUsersCommentResponse>>("api/getdoctoruserscomment",
                        param);

                return data;
            }
            catch (Exception ex)
            {
                var error = new ErrorLog
                {
                    ErrorMessage = ex.Message,
                    ErrorStacktrace = ex.StackTrace,
                    ProjectName = "RandevuNoktaClient",
                    CreateDate = DateTime.Now,
                    UpdateDate = DateTime.Now,
                    StatusCode = StatusCodes.Status500InternalServerError
                };
                await _errorLog.InsertErrorLog(error);
                return new BaseResponse<DoctorUsersCommentResponse>();
            }
           
        }
        
        public async Task<BaseResponse<DoctorModel>> GetDoctorGeneralInfo(int doctor_id)
        {
            try
            {
                using (var client = new HttpClient()) 
                {
                    ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;

                    var responseData = await client.GetAsync($"{_configuration["ClinicServiceConfig:Url"]}api/getdoctorbyid?doctorId={doctor_id}");
                
                    var json = responseData.Content.ReadAsStringAsync().Result;
                    var response = JsonConvert.DeserializeObject<BaseResponse<DoctorModel>>(json);
                    return response;
                }
            }
            catch (Exception ex)
            {
                var error = new ErrorLog
                {
                    ErrorMessage = ex.Message,
                    ErrorStacktrace = ex.StackTrace,
                    ProjectName = "RandevuNoktaClient",
                    CreateDate = DateTime.Now,
                    UpdateDate = DateTime.Now,
                    StatusCode = StatusCodes.Status500InternalServerError
                };
                await _errorLog.InsertErrorLog(error);
                return new BaseResponse<DoctorModel>();
            }
           
        }
        
        public async Task<BaseResponse<List<ClinicModel>>> GetClinicListByDoctorId(int doctor_id)
        {
            try
            {
                using (var client = new HttpClient()) 
                {
                    ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;

                    var responseData = await client.GetAsync($"{_configuration["ClinicServiceConfig:Url"]}api/GetClinicListByDoctorId?doctorId={doctor_id}");
                
                    var json = responseData.Content.ReadAsStringAsync().Result;
                    var response = JsonConvert.DeserializeObject<BaseResponse<List<ClinicModel>>>(json);
                    return response;
                }
            }
            catch (Exception ex)
            {
                var error = new ErrorLog
                {
                    ErrorMessage = ex.Message,
                    ErrorStacktrace = ex.StackTrace,
                    ProjectName = "RandevuNoktaClient",
                    CreateDate = DateTime.Now,
                    UpdateDate = DateTime.Now,
                    StatusCode = StatusCodes.Status500InternalServerError
                };
                await _errorLog.InsertErrorLog(error);
                return new BaseResponse<List<ClinicModel>>();
            }
           
        }
        
        public async Task<BaseResponse<List<BranchModel>>> GetBranchListByDoctorId(int doctor_id)
        {
            try
            {
                using (var client = new HttpClient()) 
                {
                    ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;

                    var responseData = await client.GetAsync($"{_configuration["ClinicServiceConfig:Url"]}api/GetBranchListByDoctorId?doctorId={doctor_id}");
                
                    var json = responseData.Content.ReadAsStringAsync().Result;
                    var response = JsonConvert.DeserializeObject<BaseResponse<List<BranchModel>>>(json);
                    return response;
                }
            }
            catch (Exception ex)
            {
                var error = new ErrorLog
                {
                    ErrorMessage = ex.Message,
                    ErrorStacktrace = ex.StackTrace,
                    ProjectName = "RandevuNoktaClient",
                    CreateDate = DateTime.Now,
                    UpdateDate = DateTime.Now,
                    StatusCode = StatusCodes.Status500InternalServerError
                };
                await _errorLog.InsertErrorLog(error);
                return new BaseResponse<List<BranchModel>>();
            }
            
        }
        
        public async Task<BaseResponse<List<ProfessionModel>>> GetProfessionListByDoctorId(int doctor_id)
        {
            try
            {
                using (var client = new HttpClient()) 
                {
                    ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;

                    var responseData = await client.GetAsync($"{_configuration["ClinicServiceConfig:Url"]}api/GetProfessionListByDoctorId?doctorId={doctor_id}");
                
                    var json = responseData.Content.ReadAsStringAsync().Result;
                    var response = JsonConvert.DeserializeObject<BaseResponse<List<ProfessionModel>>>(json);
                    return response;
                }
            }
            catch (Exception ex)
            {
                var error = new ErrorLog
                {
                    ErrorMessage = ex.Message,
                    ErrorStacktrace = ex.StackTrace,
                    ProjectName = "RandevuNoktaClient",
                    CreateDate = DateTime.Now,
                    UpdateDate = DateTime.Now,
                    StatusCode = StatusCodes.Status500InternalServerError
                };
                await _errorLog.InsertErrorLog(error);
                return new BaseResponse<List<ProfessionModel>>();
            }
            
        }
        
        public async Task<BaseResponse<List<DoctorExperienceModel>>> GetExperienceListByDoctorId(int doctor_id)
        {
            try
            {
                using (var client = new HttpClient()) 
                {
                    ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;

                    var responseData = await client.GetAsync($"{_configuration["ClinicServiceConfig:Url"]}api/GetExperienceListByDoctorId?doctorId={doctor_id}");
                
                    var json = responseData.Content.ReadAsStringAsync().Result;
                    var response = JsonConvert.DeserializeObject<BaseResponse<List<DoctorExperienceModel>>>(json);
                    return response;
                }
            }
            catch (Exception ex)
            {
                var error = new ErrorLog
                {
                    ErrorMessage = ex.Message,
                    ErrorStacktrace = ex.StackTrace,
                    ProjectName = "RandevuNoktaClient",
                    CreateDate = DateTime.Now,
                    UpdateDate = DateTime.Now,
                    StatusCode = StatusCodes.Status500InternalServerError
                };
                await _errorLog.InsertErrorLog(error);
                return new BaseResponse<List<DoctorExperienceModel>>();
            }
            
        }
        
        public async Task<BaseResponse<List<InsuranceModel>>> GetInsuranceListByDoctorId(int doctor_id)
        {
            try
            {
                using (var client = new HttpClient()) 
                {
                    ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;

                    var responseData = await client.GetAsync($"{_configuration["ClinicServiceConfig:Url"]}api/GetDoctorInsuranceByDoctorId?id={doctor_id}");
                
                    var json = responseData.Content.ReadAsStringAsync().Result;
                    var response = JsonConvert.DeserializeObject<BaseResponse<List<InsuranceModel>>>(json);
                    return response;
                }
            }
            catch (Exception ex)
            {
                var error = new ErrorLog
                {
                    ErrorMessage = ex.Message,
                    ErrorStacktrace = ex.StackTrace,
                    ProjectName = "RandevuNoktaClient",
                    CreateDate = DateTime.Now,
                    UpdateDate = DateTime.Now,
                    StatusCode = StatusCodes.Status500InternalServerError
                };
                await _errorLog.InsertErrorLog(error);
                return new BaseResponse<List<InsuranceModel>>();
            }
           
        }
        
        public async Task<BaseResponse<List<TreatmentModel>>> GetTreatmentListByDoctorId(int doctor_id)
        {
            try
            {
                using (var client = new HttpClient()) 
                {
                    ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;

                    var responseData = await client.GetAsync($"{_configuration["ClinicServiceConfig:Url"]}api/gettreatmentlistbydoctorid?id={doctor_id}");
                
                    var json = responseData.Content.ReadAsStringAsync().Result;
                    var response = JsonConvert.DeserializeObject<BaseResponse<List<TreatmentModel>>>(json);
                    return response;
                }
            }
            catch (Exception ex)
            {
                var error = new ErrorLog
                {
                    ErrorMessage = ex.Message,
                    ErrorStacktrace = ex.StackTrace,
                    ProjectName = "RandevuNoktaClient",
                    CreateDate = DateTime.Now,
                    UpdateDate = DateTime.Now,
                    StatusCode = StatusCodes.Status500InternalServerError
                };
                await _errorLog.InsertErrorLog(error);
                return new BaseResponse<List<TreatmentModel>>();
            }
            
        }
        
        public async Task<BaseResponse<List<LanguageModel>>> GetLanguageListByDoctorId(int doctor_id)
        {
            try
            {
                using (var client = new HttpClient()) 
                {
                    ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;

                    var responseData = await client.GetAsync($"{_configuration["ClinicServiceConfig:Url"]}api/GetLanguageListByDoctorId?doctorId={doctor_id}");
                
                    var json = responseData.Content.ReadAsStringAsync().Result;
                    var response = JsonConvert.DeserializeObject<BaseResponse<List<LanguageModel>>>(json);
                    return response;
                }
            }
            catch (Exception ex)
            {
                var error = new ErrorLog
                {
                    ErrorMessage = ex.Message,
                    ErrorStacktrace = ex.StackTrace,
                    ProjectName = "RandevuNoktaClient",
                    CreateDate = DateTime.Now,
                    UpdateDate = DateTime.Now,
                    StatusCode = StatusCodes.Status500InternalServerError
                };
                await _errorLog.InsertErrorLog(error);
                return new BaseResponse<List<LanguageModel>>();
            }
            
        }
        
        public async Task<BaseResponse<DoctorUsersCommentResponse>> GetDoctorCommentsListByDoctorId(int doctorId)
        {
            try
            {
                using (var client = new HttpClient()) 
                {
                    ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;

                    var responseData = await client.GetAsync($"{_configuration["CommonServiceConfig:Url"]}comment/getdoctoruserscomment?doctorId={doctorId}");
                
                    var json = responseData.Content.ReadAsStringAsync().Result;
                    var response = JsonConvert.DeserializeObject<BaseResponse<DoctorUsersCommentResponse>>(json);
                    return response;
                }
            }
            catch (Exception ex)
            {
                var error = new ErrorLog
                {
                    ErrorMessage = ex.Message,
                    ErrorStacktrace = ex.StackTrace,
                    ProjectName = "RandevuNoktaClient",
                    CreateDate = DateTime.Now,
                    UpdateDate = DateTime.Now,
                    StatusCode = StatusCodes.Status500InternalServerError
                };
                await _errorLog.InsertErrorLog(error);
                return new BaseResponse<DoctorUsersCommentResponse>();
            }
            
        }
        
        public async Task<BaseResponse<List<PaymentMethods>>> GetMethodListByDoctorId(int doctorId)
        {
            try
            {
                using (var client = new HttpClient()) 
                {
                    ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;

                    var responseData = await client.GetAsync($"{_configuration["CommonServiceConfig:Url"]}api/getpaymentmethodbydoctorid?doctorId={doctorId}");
                
                    var json = responseData.Content.ReadAsStringAsync().Result;
                    var response = JsonConvert.DeserializeObject<BaseResponse<List<PaymentMethods>>>(json);
                    return response;
                }
            }
            catch (Exception ex)
            {
                var error = new ErrorLog
                {
                    ErrorMessage = ex.Message,
                    ErrorStacktrace = ex.StackTrace,
                    ProjectName = "RandevuNoktaClient",
                    CreateDate = DateTime.Now,
                    UpdateDate = DateTime.Now,
                    StatusCode = StatusCodes.Status500InternalServerError
                };
                await _errorLog.InsertErrorLog(error);
                return new BaseResponse<List<PaymentMethods>>();
            }
            
        }
    }
}