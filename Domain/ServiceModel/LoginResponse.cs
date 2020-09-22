using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.ServiceModel
{
    public class LoginResponse
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public DateTime LastLoginDate { get; set; }
        public string Token { get; set; }
    }
}
