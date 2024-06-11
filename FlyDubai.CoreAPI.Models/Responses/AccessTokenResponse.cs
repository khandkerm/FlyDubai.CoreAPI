using Newtonsoft.Json;

namespace FlyDubai.CoreAPI.Models.Responses
{
    public class AccessTokenResponse : ResponseBase
    {
        [JsonProperty("access_token")]
        public string AccessToken { get; set; }

        [JsonProperty("token_type")]
        public string TokenType { get; set; }

        [JsonProperty("expires_in")]
        public int ExpiresIn { get; set; }

        [JsonProperty("refresh_token")]
        public string RefreshToken { get; set; }

        [JsonProperty("audience")]
        public string Audience { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("userId")]
        public string UserId { get; set; }

        [JsonProperty("rolesandpermission")]
        public string RolesAndPermission { get; set; }

        [JsonProperty("groupAccess")]
        public string GroupAccess { get; set; }

        [JsonProperty("resChannelID")]
        public string ResChannelID { get; set; }

        [JsonProperty("airports")]
        public string Airports { get; set; }

        [JsonProperty("isAptClnt")]
        public bool IsAptClnt { get; set; }

        [JsonProperty("scope")]
        public string Scope { get; set; }

        [JsonProperty(".issued")]
        public DateTime Issued { get; set; }

        [JsonProperty(".expires")]
        public DateTime Expires { get; set; }
    }
}
