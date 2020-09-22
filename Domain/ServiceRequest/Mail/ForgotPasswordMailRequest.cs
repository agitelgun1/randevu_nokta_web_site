namespace Domain.ServiceRequest.Mail
{
    public class ForgotPasswordMailRequest
    {
        public string To { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Url { get; set; }
    }
}