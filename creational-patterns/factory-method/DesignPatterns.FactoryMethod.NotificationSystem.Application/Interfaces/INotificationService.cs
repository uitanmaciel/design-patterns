using DesignPatterns.FactoryMethod.NotificationSystem.Application.Models;

namespace DesignPatterns.FactoryMethod.NotificationSystem.Application.Interfaces;

public interface INotificationService
{
    Task SendAsync(Notification notification, CancellationToken cancellationToken = default);
}