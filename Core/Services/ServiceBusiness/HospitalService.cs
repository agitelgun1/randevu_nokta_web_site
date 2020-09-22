using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Core.Services.ServiceInterface;
using Domain.Entity;
using Domain.ServiceModel;
using Domain.ServiceResponse.ClinicService;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Http;

namespace Core.Services.ServiceBusiness
{
    public class HospitalService : IHospitalService
    {
        private readonly IConfiguration _configuration;
        private readonly IErrorService _errorLog;

        public HospitalService(IConfiguration configuration, IErrorService errorLog)
        {
            _configuration = configuration;
            _errorLog = errorLog;
        }

        public async Task<BaseResponse<ClinicUsersCommentResponse>> GetClinicCommentsListByClinicId(int clinicId)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    ServicePointManager.SecurityProtocol =
                        SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;

                    var responseData = await client.GetAsync(
                        $"{_configuration["CommonServiceConfig:Url"]}comment/getcommentsbyclinicid?clinicId={clinicId}");

                    var json = responseData.Content.ReadAsStringAsync().Result;
                    var response = JsonConvert.DeserializeObject<BaseResponse<ClinicUsersCommentResponse>>(json);
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
                return new BaseResponse<ClinicUsersCommentResponse>();
            }
        }

        public async Task<BaseResponse<List<DoctorModel>>> GetDoctorListByClinicId(int clinicId)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    ServicePointManager.SecurityProtocol =
                        SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;

                    var responseData = await client.GetAsync(
                        $"{_configuration["ClinicServiceConfig:Url"]}api/getdoctorlistbyclinicid?clinicId={clinicId}");

                    var json = responseData.Content.ReadAsStringAsync().Result;
                    var response = JsonConvert.DeserializeObject<BaseResponse<List<DoctorModel>>>(json);
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
                return new BaseResponse<List<DoctorModel>>();
            }
        }

        public async Task<BaseResponse<ClinicModel>> GetClinicGeneralInfo(int clinicId)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    ServicePointManager.SecurityProtocol =
                        SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;

                    var responseData =
                        await client.GetAsync(
                            $"{_configuration["ClinicServiceConfig:Url"]}api/getclinicbyid?clinicId={clinicId}");

                    var json = responseData.Content.ReadAsStringAsync().Result;
                    var response = JsonConvert.DeserializeObject<BaseResponse<ClinicModel>>(json);
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
                return new BaseResponse<ClinicModel>();
            }
        }
    }
}