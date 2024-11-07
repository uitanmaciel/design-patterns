using DesignPatterns.FactoryMethod.NotificationSystem.Infrastructure.Notifications.Emails;

namespace DesignPatterns.FactoryMethod.NotificationSystem.Infrastructure.Factories;

public class EmailNotificationFactory(IOptions<SendGridSettings> options) : INotificationFactory
{
    public INotification CreateNotification()
        => new EmailNotificationSender(options);
}