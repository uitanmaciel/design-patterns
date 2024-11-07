﻿namespace DesignPatterns.FactoryMethod.NotificationSystem.Infrastructure.Notifications.Sms;

public class TwilioSettings
{
    public string AccountSid { get; set; } = string.Empty;
    public string AuthToken { get; set; } = string.Empty;
    public string FromNumber { get; set; } = string.Empty;
}