using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Opensource.SMS.Pindo.Models
{
    public class Recipient
    {
        [JsonPropertyName("name")]
        [Required]
        public string Name { get; set; }
        [JsonPropertyName("phonenumber")]
        [Required]
        public string PhoneNumber { get; set; }
    }
}
