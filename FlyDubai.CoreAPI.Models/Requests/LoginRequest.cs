namespace FlyDubai.CoreAPI.Models.Requests
{
    public class LoginRequest
    {
        public string ClientId { get; set; }
        public string ClientSecret { get; set; }
        public string GrantType { get; set; } = "password";
        public string Username { get; set; }
        public string Password { get; set; }
        public string Scope { get; set; } = "res";
    }

}
