using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.ServiceRequest.Auth
{
    public class RegisterRequest
    {
        public string Name { get; set; } = "";
        public string Surname { get; set; } = "";
        public string Email { get; set; } = "";
        public string Phone { get; set; } = "";
        public string IdentityNumber { get; set; } = "";
        public string Gender { get; set; } = "";
        public DateTime BirthDate { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        public string Password { get; set; } = "";
        public int WrongPasswordCount { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime LastLoginDate { get; set; }
        public List<string> Roles { get; set; }
    }
}
