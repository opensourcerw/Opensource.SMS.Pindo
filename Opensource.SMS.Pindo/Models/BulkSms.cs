using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Opensource.SMS.Pindo.Models
{
    public class BulkSms
    {
        [Required]
        [JsonPropertyName("recipients")]
        public ICollection<Recipient> Recipients { get; set; }
        [JsonPropertyName("text")]
        [Required]
        public string Text { get; set; }
        [JsonPropertyName("sender")]
        [Required]
        public string Sender { get; set; }
    }
}
