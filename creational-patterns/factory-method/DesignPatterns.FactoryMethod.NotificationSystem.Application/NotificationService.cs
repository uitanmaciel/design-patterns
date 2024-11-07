using DesignPatterns.FactoryMethod.NotificationSystem.Application.Enums;
using DesignPatterns.FactoryMethod.NotificationSystem.Application.Interfaces;
using DesignPatterns.FactoryMethod.NotificationSystem.Application.Models;

namespace DesignPatterns.FactoryMethod.NotificationSystem.Application;

public class NotificationService(IDictionary<NotificationType, INotificationFactory> factories) : INotificationService
{
    public Task SendAsync(Notification notification, CancellationToken cancellationToken = default)
    {
        if(factories.TryGetValue(notification.Type, out var factory))
        {
            var notifier = factory.CreateNotification();
            return notifier.SendAsync(notification, cancellationToken);
        }

        throw new NotSupportedException($"Notification type {notification.Type} is not supported.");
    }
}