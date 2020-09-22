using System;

namespace Domain.Entity
{
    public class UsersComment
    {
        public int Score { get; set; }
        public DateTime CreateDate { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string UserName { get; set; }
        

        public string UserImageUrl { get; set; }
        
        public long DoctorId { get; set; }

        public long UserId { get; set; }
        

        public DateTime UpdatedDate { get; set; }
        public long ClinicId { get; set; }
    }
}