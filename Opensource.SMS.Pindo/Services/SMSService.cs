using Opensource.SMS.Pindo.Abstractions;
using Opensource.SMS.Pindo.Models;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;

namespace Opensource.SMS.Pindo.Services
{
    public class SMSService : ISMSService
    {
        private readonly IHttpClient _httpClient;
        private readonly string _token;
        public SMSService(IHttpClient httpClient, string token = null)
        {
            _httpClient = httpClient;
            _token = token;
        }

        public async Task<SentSMSResponse> SendSmsAsync(Sms sms)
        {

            HttpRequestMessage httpRequestMessage = new HttpRequestMessage();
            httpRequestMessage.Headers.Add("Accept", "application/json");
            httpRequestMessage.Headers.Add("Authorization", $"bearer {_token}");
            httpRequestMessage.Method = HttpMethod.Post;
            var content = new StringContent(JsonSerializer.Serialize(sms), Encoding.UTF8, "application/json");
            httpRequestMessage.RequestUri = new Uri($"https://api.pindo.io/v1/sms/");
            httpRequestMessage.Content = content;
            var response = await _httpClient.SendAsync(httpRequestMessage);
            response.EnsureSuccessStatusCode();

            return await response.Content.ReadFromJsonAsync<SentSMSResponse>();
        }

        public async Task<SentBulkSMSResponse> SendBulkSmsAsync(BulkSms bulkSMS)
        {
            HttpRequestMessage httpRequestMessage = new HttpRequestMessage();
            httpRequestMessage.Headers.Add("Accept", "application/json");
            httpRequestMessage.Headers.Add("Authorization", $"bearer {_token}");
            httpRequestMessage.Method = HttpMethod.Post;
            var content = new StringContent(JsonSerializer.Serialize(bulkSMS), Encoding.UTF8, "application/json");
            httpRequestMessage.RequestUri = new Uri($"https://api.pindo.io/v1/sms/bulk");
            httpRequestMessage.Content = content;

            var response = await _httpClient.SendAsync(httpRequestMessage);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<SentBulkSMSResponse>();
        }
    }
}
