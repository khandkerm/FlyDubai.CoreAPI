using System.ComponentModel.DataAnnotations;

namespace FlyDubai.CoreAPI.Models.Global
{
    /// <summary>
    /// AppSettings
    /// </summary>
    public class AppSettings
    {
        /// <summary>
        /// Default Database Connection to be used 
        /// </summary>
        [Required]
        public string DefaultDB { get; set; }

        /// <summary>
        /// Used to decrypt value found over http call
        /// </summary>
        public string CipherSecretKey { get; set; }

        /// <summary>
        /// Gets or sets the value for the SameSite attribute of the cookie. 
        /// -1: No SameSite field will be set, the client should follow its default cookie policy.
        /// 0: Indicates the client should disable same-site restrictions.
        /// 1: Indicates the client should send the cookie with "same-site" requests, and with "cross-site" top-level navigations.
        /// 2: Indicates the client should only send the cookie with "same-site" requests.
        /// </summary>
        public int CookieSameSite { get; set; } = 0;

        /// <summary>
        /// For Jwt Token
        /// </summary>
        public string JwtCryptoKey { get; set; }
        public string JwtIssuer { get; set; }
        public string JwtAudience { get; set; }
        public bool JwtValidateIssuer { get; set; }
        public bool JwtValidateAudience { get; set; }


        /// <summary>
        /// For Security API
        /// </summary>
        public string ClientId { get; set; }
        public string ClientSecret { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        /// <summary>
        /// For user password
        /// </summary>
        public string PwdSecretKey { get; set; }

        public string BaseKey { get; set; }

        /// <summary>
        /// CORS settings
        /// </summary>
        public string CorsSetting { get; set; }


        /// <summary>
        /// Logger enabled if the is there is value
        /// </summary>
        public string LoggerPath { get; set; } = string.Empty;
        public int LoggerMinLevel { get; set; }

        /// <summary>
        /// Distributed cache (Redis)
        /// </summary>
        public string RedisCacheUrl { get; set; } = string.Empty;

        /// <summary>
        /// Distributed Session (Redis) 
        /// </summary>
        public string RedisSessionUrl { get; set; } = string.Empty;


        /// <summary>
        /// Application url for reset password, authentication or any other url
        /// </summary>
        public string AppUrl { get; set; } = string.Empty;


        /// <summary>
        /// SOAP Api crypto information
        /// </summary>
        public string ApiCryptoKey { get; set; }
        public int ApiSecurityMode { get; set; }

        public ADSettings ADConfig { get; set; }
        [Required]
        public ApiSettings API { get; set; }
        [Required]
        public Swagger Swagger { get; set; }
    }

    /// <summary>
    /// 
    /// </summary>
    public class ADSettings
    {
        public bool Enabled { get; set; }
        public string Domain { get; set; }
        public string Path { get; set; }
    }

    /// <summary>
    /// 
    /// </summary>
    public class ApiSettings
    {
        [Required]
        public string Title { get; set; }
        public string Description { get; set; }
        public ApiContact Contact { get; set; }
        public string TermsOfServiceUrl { get; set; }
        public ApiLicense License { get; set; }
    }

    /// <summary>
    /// 
    /// </summary>
    public class ApiContact
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Url { get; set; }
    }

    /// <summary>
    /// 
    /// </summary>
    public class ApiLicense
    {
        public string Name { get; set; }
        public string Url { get; set; }
    }

    /// <summary>
    /// 
    /// </summary>
    public class Swagger
    {
        [Required]
        public bool Enabled { get; set; }
    }
}
