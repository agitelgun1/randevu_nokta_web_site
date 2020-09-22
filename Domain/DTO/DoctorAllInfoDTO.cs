using System.Collections.Generic;
using Domain.Entity;
using Domain.ServiceResponse.ClinicService;

namespace Domain.DTO
{
    public class DoctorAllInfoDTO
    {
        public DoctorAllInfoDTO()
        {
            ClinicList = new List<ClinicModel>();
            BranchList = new List<BranchModel>();
            ProfessionList = new List<ProfessionModel>();
            ExperienceList = new List<DoctorExperienceModel>();
            InsuranceList = new List<InsuranceModel>();
            TreatmentList = new List<TreatmentModel>();
            LanguageList = new List<LanguageModel>();
            DoctorComments = new List<UsersComment>();
            PaymentMethodsList = new List<PaymentMethods>();
        }

        public DoctorModel DoctorGeneralInfo { get; set; }
        public List<ClinicModel> ClinicList { get; set; }
        public List<BranchModel> BranchList { get; set; }
        public List<ProfessionModel> ProfessionList { get; set; }
        public List<DoctorExperienceModel> ExperienceList { get; set; }
        public List<InsuranceModel> InsuranceList { get; set; }
        public List<TreatmentModel> TreatmentList { get; set; }
        public List<LanguageModel> LanguageList { get; set; }
        public IEnumerable<UsersComment> DoctorComments { get; set; }
        public int ReviewerCount { get; set; }

        public double Score { get; set; }
        public IDictionary<int, double> CommentPercentageByScore { get; set; }
        public List<PaymentMethods> PaymentMethodsList { get; set; }
    }
}