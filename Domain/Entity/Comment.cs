using System;

namespace Domain.Entity
{
    public class Comment
    {
        public decimal Score { get; set; }
        public DateTime CreateDate { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string UserName { get; set; }
        public string UserImageUrl { get; set; }
        public string DoctorId { get; set; }
        public string UserId { get; set; }
        public string UpdatedDate { get; set; }
    }
}