using Microsoft.Extensions.DependencyInjection;
using Opensource.SMS.Pindo.Abstractions;
using Opensource.SMS.Pindo.Services;

namespace Opensource.SMS.Pindo
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddPindoSMS(this IServiceCollection services, string token = null)
        {
            // Register the custom HttpClient using HttpClientFactory
            services.AddHttpClient<IHttpClient, CustomHttpClient>();

            // Register the SMSService with a scoped lifetime and inject the token
            services.AddScoped<ISMSService>(provider =>
            {
                var httpClient = provider.GetRequiredService<IHttpClient>();
                return new SMSService(httpClient, token);
            });

            return services;

        }
    }
}
