using System;
using System.Collections.Generic;
using Domain.Entity;
using Domain.ServiceModel;

namespace Domain.ServiceResponse.ClinicService
{
    public class DoctorModel
    {
        public DoctorModel()
        {
            BranchList = new List<BranchModel>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string GraduatedInstitution { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string FaxNumber { get; set; }
        public string Gender { get; set; }
        public DateTime BirthDate { get; set; }
        public string Nationality { get; set; }
        public int AppointmentCount { get; set; }
        public decimal Score { get; set; }
        public string Image { get; set; }
        public string CoverImage { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        public string ProfessionalExperience { get; set; }
        public decimal Price { get; set; }
        public List<BranchModel> BranchList { get; set; }
        
        public double? DoctorScore { get; set; }
        
        public int ReviewerCount { get; set; }
    }
}