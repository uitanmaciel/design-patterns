using DesignPatterns.FactoryMethod.NotificationSystem.Infrastructure.Notifications.Pushes;
using DesignPatterns.FactoryMethod.NotificationSystem.Infrastructure.Pushes;

namespace DesignPatterns.FactoryMethod.NotificationSystem.Infrastructure.Factories;

public class PushNotificationFactory(IOptions<FirebaseSettings> options) : INotificationFactory
{
    public INotification CreateNotification()
        => new PushNotificationSender(options);
}