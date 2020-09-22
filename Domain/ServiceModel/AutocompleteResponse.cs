using System.Collections.Generic;
using Domain.DTO;

namespace Domain.ServiceModel
{
    public class AutocompleteResponse
    {
        public List<DoctorDTO> Doctors { get; set; }
        public List<DynamicSolrDTO> Branches { get; set; }
        public List<DynamicSolrDTO> Diseases { get; set; }
        public List<DynamicSolrDTO> Treatments { get; set; }
        public List<DynamicSolrDTO> Clinics { get; set; }
    }
}