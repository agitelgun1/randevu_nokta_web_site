namespace Domain.ServiceRequest.Auth
{
    public class ChangeForgotPasswordRequest
    {
        public string Hash { get; set; }
        public string Password { get; set; }
    }
}