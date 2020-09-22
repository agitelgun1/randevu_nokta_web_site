using System;
using System.Collections.Generic;
using Domain.Entity;
using Domain.ServiceModel;

namespace Domain.ViewModel
{
    public class DoctorDetailViewModel
    {
        public DoctorDetailViewModel()
        {
            CommentPercentageByScore = new Dictionary<int, double>();
        }
        public string Name { get; set; }
        public double DoctorId { get; set; }
        public string Surname { get; set; }
        public string Graduated { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Fax { get; set; }
        public string Gender { get; set; }
        public DateTime BirthDate { get; set; }
        public string Nationality { get; set; }
        public int AppointmentCount { get; set; }
        public double Score { get; set; }
        public string Image { get; set; }
        public string CoverImage { get; set; }
        public string ProfessionalExperience { get; set; }
        public decimal Price { get; set; }
        public int ReviewerCount { get; set; }
        public int PatientCount { get; set; }
        public string DoctorInformation { get; set; }
        public IEnumerable<string> DoctorSpecializations { get; set; }
        public IEnumerable<string> DoctorPaymentMethods { get; set; }
        public IEnumerable<string> GraduatedInstitution { get; set; }
        public IEnumerable<UsersComment> Comments { get; set; }
        public IDictionary<int, double> CommentPercentageByScore { get; set; }
        public double Latitude { get; set; }
        
        public double Longitude { get; set; }
    }
}