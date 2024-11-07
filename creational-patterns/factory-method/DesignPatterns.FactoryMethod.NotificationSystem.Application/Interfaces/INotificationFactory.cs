using DesignPatterns.FactoryMethod.NotificationSystem.Application.Enums;

namespace DesignPatterns.FactoryMethod.NotificationSystem.Application.Interfaces;

public interface INotificationFactory
{
    INotification CreateNotification();
}