using DesignPatterns.FactoryMethod.NotificationSystem.Application.Enums;

namespace DesignPatterns.FactoryMethod.NotificationSystem.Application.Models;

public class Notification()
{
    public NotificationType Type { get; }
    public string To { get; } = string.Empty;
    public string? Subject { get; } = string.Empty;
    public string Message { get; } = string.Empty;

    public Notification(NotificationType type, string to, string? subject, string message) : this()
    {
        Type = type;
        To = to;
        Subject = subject;
        Message = message;
    }
}