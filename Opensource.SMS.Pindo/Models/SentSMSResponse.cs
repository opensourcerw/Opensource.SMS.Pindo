namespace Opensource.SMS.Pindo.Models
{
    public record SentSMSResponse
    {
        public double bonus { get; set; }
        public double discount { get; set; }
        public int item_count { get; set; }
        public double item_price { get; set; }
        public double remaining_balance { get; set; }
        public string self_url { get; set; }
        public string sms_id { get; set; }
        public string status { get; set; }
        public string to { get; set; }
        public double total_cost { get; set; }
    }

 
}
