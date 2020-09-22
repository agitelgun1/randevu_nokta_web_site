using System.Collections.Generic;
using Domain.Entity;
using Domain.ServiceModel;
using Domain.ServiceResponse.ClinicService;

namespace Domain.DTO
{
    public class HospitalGeneralInfo
    {
        public HospitalGeneralInfo()
        {
            DoctorList = new List<DoctorModel>();
        }
        public ClinicModel ClinicInfo { get; set; }
        public ClinicUsersCommentResponse ClinicComments { get; set; }
        public List<DoctorModel> DoctorList { get; set; }
        public int ReviewerCount { get; set; }

        public double? Score { get; set; }
        public IDictionary<int, double> CommentPercentageByScore { get; set; }


    }
}