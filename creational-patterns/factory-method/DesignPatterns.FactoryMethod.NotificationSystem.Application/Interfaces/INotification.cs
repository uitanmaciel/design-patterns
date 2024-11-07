using DesignPatterns.FactoryMethod.NotificationSystem.Application.Models;

namespace DesignPatterns.FactoryMethod.NotificationSystem.Application.Interfaces;

public interface INotification
{
    Task SendAsync(Notification notification, CancellationToken cancellationToken = default);
}