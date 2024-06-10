using System.Security.Claims;

namespace FlyDubai.CoreAPI.Helper
{
    /// <summary>
    /// 
    /// </summary>
    public static class Helper
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="type"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static Claim CreateClaim(string type, string value)
        {
            return new Claim(type: type, value: value);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="expirationInMinutes"></param>
        /// <returns></returns>
        public static DateTimeOffset CreateFlyDubaiCacheOptions(double expirationInMinutes = 36)
        {
            return DateTime.Now.AddMinutes(expirationInMinutes);
        }
    }
}
