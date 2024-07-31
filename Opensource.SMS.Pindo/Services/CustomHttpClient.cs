using Opensource.SMS.Pindo.Abstractions;

namespace Opensource.SMS.Pindo.Services
{
    public class CustomHttpClient : IHttpClient {

        private readonly HttpClient _httpClient;


        public CustomHttpClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request)
        {
            var response = await _httpClient.SendAsync(request);
            return response;
        }
    }
}
