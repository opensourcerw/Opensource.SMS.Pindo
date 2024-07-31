using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Opensource.SMS.Pindo.Models
{
    public class Sms
    {
        [JsonPropertyName("to")]
        [Required]
        public string To { get; set; }
        [JsonPropertyName("text")]
        [Required]
        public string Text { get; set; }
        [JsonPropertyName("sender")]
        [Required]
        public string Sender { get; set; }
    }
}
