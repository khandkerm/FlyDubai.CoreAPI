using Microsoft.AspNetCore.Mvc.Infrastructure;

namespace FlyDubai.CoreAPI.Configurations.DI
{
    public static class ServiceCollectionExtensions
    {
        public static void ConfigureBusinessServices(this IServiceCollection services)
        {
            if (services == null)
                return;

            services.AddSingleton<IActionContextAccessor, ActionContextAccessor>();
        }
    }
}
