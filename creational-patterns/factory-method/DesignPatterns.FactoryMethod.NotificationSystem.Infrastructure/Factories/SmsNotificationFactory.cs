using DesignPatterns.FactoryMethod.NotificationSystem.Infrastructure.Notifications.Sms;

namespace DesignPatterns.FactoryMethod.NotificationSystem.Infrastructure.Factories;

public class SmsNotificationFactory(IOptions<TwilioSettings> options) : INotificationFactory
{
    public INotification CreateNotification()
        => new SmsNotificationSender(options);
}