using System.Text.Json.Serialization;
using DesignPatterns.FactoryMethod.NotificationSystem.Application.Enums;
using DesignPatterns.FactoryMethod.NotificationSystem.Application.Models;

namespace DesignPatterns.FactoryMethod.NotificationSystem.Api.Models;

public record NotificationRequest()
{
    [JsonPropertyName("type")] public string Type { get; init; } = string.Empty;
    [JsonPropertyName("to")] public string To { get; init; } = string.Empty;
    [JsonPropertyName("subject")] public string? Subject { get; init; } = string.Empty;
    [JsonPropertyName("message")] public string Message { get; init; } = string.Empty;
    
    public NotificationRequest(string type, string to, string? subject, string message) : this()
    {
        Type = type;
        To = to;
        Subject = subject;
        Message = message;
    }
    
    public static Notification ToModelApplication(NotificationRequest request)
        => new Notification(
            (NotificationType)Enum.Parse(typeof(NotificationType), request.Type), 
            request.To, 
            request.Subject, 
            request.Message);
}