using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;

namespace DesignPatterns.FactoryMethod.NotificationSystem.Infrastructure.Notifications.Sms;

public class SmsNotificationSender : INotification
{
    private readonly TwilioSettings _twilioSettings;

    public SmsNotificationSender(IOptions<TwilioSettings> options)
    {
        _twilioSettings = options.Value;
        TwilioClient.Init(_twilioSettings.AccountSid, _twilioSettings.AuthToken);
    }

    public Task SendAsync(Notification notification, CancellationToken cancellationToken = default)
    {
        // Implement SMS sending logic here
        throw new NotImplementedException();
    }
}