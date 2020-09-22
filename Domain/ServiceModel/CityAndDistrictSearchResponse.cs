using Domain.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.ServiceModel
{
    public class CityAndDistrictSearchResponse
    {
        public List<City> CityList { get; set; }
        public List<District> DistrictList { get; set; }
    }
}
