using System.Net;

namespace Opensource.SMS.Pindo.Models
{
    internal record BaseResponse
    {
        public HttpStatusCode statusCode { get; set; }
        public string message { get; set; } = string.Empty;
    }
}
