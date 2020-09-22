using System;

namespace Domain.ServiceResponse.ClinicService
{
    public class ClinicModel
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int CityId { get; set; }
        public string CityName { get; set; }
        public int DistrictId { get; set; }
        public string DistrictName { get; set; }
        public string PhoneNumber { get; set; }
        public string LogoUrl { get; set; }
        public int Capacity { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        public decimal Score { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public long VendorId { get; set; }
        public string VendorName { get; set; }
        public string Longitude { get; set; }
        public string Latitude { get; set; }
        public string ClinicType { get; set; }
        public string AboutUs { get; set; }
    }
}