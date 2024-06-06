using Asp.Versioning.ApiExplorer;
using FlyDubai.CoreAPI.Models.Global;
using Microsoft.Extensions.Options;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace FlyDubai.CoreAPI.Swagger
{
    /// <summary>
    /// 
    /// </summary>
    public class ConfigureSwaggerOptions : IConfigureOptions<SwaggerGenOptions>
    {
        private readonly AppSettings appSettings;
        private readonly IConfiguration configuration;
        private readonly IApiVersionDescriptionProvider provider;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="provider"></param>
        /// <param name="configuration"></param>
        public ConfigureSwaggerOptions(IApiVersionDescriptionProvider provider, IConfiguration configuration)
        {
            this.provider = provider;
            this.configuration = configuration;
            appSettings = configuration.GetSection(nameof(AppSettings)).Get<AppSettings>();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="options"></param>
        public void Configure(SwaggerGenOptions options)
        {
            Configure(options, appSettings.API);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="options"></param>
        /// <param name="apiSettings"></param>
        public void Configure(SwaggerGenOptions options, ApiSettings apiSettings)
        {
            if (options == null)
                throw new ArgumentNullException(nameof(options));

            if (apiSettings == null)
                throw new ArgumentNullException(nameof(apiSettings));

            foreach (var description in provider.ApiVersionDescriptions)
            {
                options.SwaggerDoc(description.GroupName, CreateInfoForApiVersion(description, apiSettings));
            }
        }

        static OpenApiInfo CreateInfoForApiVersion(ApiVersionDescription description, ApiSettings apiSettings)
        {
            var info = new OpenApiInfo()
            {
                Title = $"{apiSettings.Title} {description.ApiVersion}",
                Version = description.ApiVersion.ToString(),
                Description = apiSettings?.Description,
                Contact = (apiSettings != null && apiSettings.Contact != null) ? new OpenApiContact { Name = apiSettings.Contact.Name, Email = apiSettings.Contact.Email, Url = new Uri(apiSettings.Contact.Url) } : null,
                License = (apiSettings != null && apiSettings.License != null) ? new OpenApiLicense { Name = apiSettings.License.Name, Url = new Uri(apiSettings.License.Url) } : null,
                TermsOfService = !string.IsNullOrEmpty(apiSettings?.TermsOfServiceUrl) ? new Uri(apiSettings.TermsOfServiceUrl) : null
            };

            if (description.IsDeprecated)
            {
                info.Description += " This API version has been deprecated.";
            }

            return info;
        }
    }
}
