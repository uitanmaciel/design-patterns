﻿namespace DesignPatterns.FactoryMethod.NotificationSystem.Infrastructure.Notifications.Emails;

public class SendGridSettings
{
    public string ApiKey { get; set; } = string.Empty;
    public string FromEmail { get; set; } = string.Empty;
    public string FromName { get; set; } = string.Empty;
}