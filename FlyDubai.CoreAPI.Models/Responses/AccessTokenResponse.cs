namespace FlyDubai.CoreAPI.Models.Responses
{
    public class AccessTokenResponse: ResponseBase
    {
        public string AccessToken { get; set; }
        public string TokenType { get; set; }
        public int ExpiresIn { get; set; }
        public string RefreshToken { get; set; }
        public string Audience { get; set; }
        public string DisplayName { get; set; }
        public string UserId { get; set; }
        public string RolesAndPermission { get; set; }
        public string ResChannelID { get; set; }
        public string Airports { get; set; }
        public bool IsAptClnt { get; set; }
        public string Scope { get; set; }
        public DateTime Issued { get; set; }
        public DateTime Expires { get; set; }
    }
}
