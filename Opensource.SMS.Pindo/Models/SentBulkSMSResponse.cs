namespace Opensource.SMS.Pindo.Models
{
    public record SentBulkSMSResponse
    {
        public double bonus { get; set; }
        public int count { get; set; }
        public double discount { get; set; }
        public double item_price { get; set; }
        public object network { get; set; }
        public double remaining_balance { get; set; }
        public string status { get; set; }
        public int total { get; set; }
    }
}
