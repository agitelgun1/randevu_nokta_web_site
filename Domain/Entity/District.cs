using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entity
{
    public class District
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CityId { get; set; }
        public int DistrictCode { get; set; }
        public string CityName { get; set; }
        public string FullName => $"{Name}, {CityName}";
    }
}
