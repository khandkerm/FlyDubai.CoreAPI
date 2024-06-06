using System.Security.Claims;

namespace FlyDubai.CoreAPI.Helper
{
    /// <summary>
    /// 
    /// </summary>
    public static class ExtensionMethods
    {
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="principal"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        public static T GetClaimValue<T>(this ClaimsPrincipal principal, string type)
        {
            if (principal == null || principal.Identity == null || principal.Identity.IsAuthenticated == false)
                return typeof(T) == typeof(string) ? ((T)Convert.ChangeType(string.Empty, typeof(T))) : default;

            Claim claim = principal.Claims.Where(p => p.Type == type).SingleOrDefault();
            if (claim == null || string.IsNullOrEmpty(claim.Value) || string.IsNullOrWhiteSpace(claim.Value))
                return typeof(T) == typeof(string) ? ((T)Convert.ChangeType(string.Empty, typeof(T))) : default;

            return (T)Convert.ChangeType(claim.Value, typeof(T));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="logger"></param>
        /// <param name="exception"></param>
        public static void LogError(this ILogger logger, Exception exception)
        {
#pragma warning disable CA2254 // Template should be a static expression
            logger.LogError(exception: exception, message: string.Empty);
#pragma warning restore CA2254 // Template should be a static expression
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="logger"></param>
        /// <param name="message"></param>
        public static void LogError(this ILogger logger, string message)
        {
            logger.LogError(message: message);
        }
    }
}
