using Opensource.SMS.Pindo.Models;

namespace Opensource.SMS.Pindo
{
    public interface ISMSService
    {
        Task<SentBulkSMSResponse> SendBulkSmsAsync(BulkSms bulkSMS);
        Task<SentSMSResponse> SendSmsAsync(Sms sms);

    }
}
