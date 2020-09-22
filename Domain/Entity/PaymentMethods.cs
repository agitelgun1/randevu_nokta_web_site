using System;

namespace Domain.Entity
{
    public class PaymentMethods
    {
        public int Id { get; set; }
        public string MethodName { get; set; }
        public string Icon { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}