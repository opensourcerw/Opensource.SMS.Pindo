namespace Opensource.SMS.Pindo.Abstractions
{
    public interface IHttpClient
    {
        Task<HttpResponseMessage> SendAsync(HttpRequestMessage request);
    }
}
