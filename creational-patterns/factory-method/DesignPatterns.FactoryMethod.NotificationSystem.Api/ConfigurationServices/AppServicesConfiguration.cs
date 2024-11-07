using DesignPatterns.FactoryMethod.NotificationSystem.Application;
using DesignPatterns.FactoryMethod.NotificationSystem.Application.Enums;
using DesignPatterns.FactoryMethod.NotificationSystem.Application.Interfaces;
using DesignPatterns.FactoryMethod.NotificationSystem.Infrastructure.Factories;
using DesignPatterns.FactoryMethod.NotificationSystem.Infrastructure.Notifications.Emails;
using DesignPatterns.FactoryMethod.NotificationSystem.Infrastructure.Notifications.Sms;
using DesignPatterns.FactoryMethod.NotificationSystem.Infrastructure.Pushes;

namespace DesignPatterns.FactoryMethod.NotificationSystem.Api.ConfigurationServices;

public static class AppServicesConfiguration
{
    public static void AddNotificationServices(this WebApplicationBuilder builder)
    {
        // Registering SendGrid
        builder.Services.Configure<SendGridSettings>(builder.Configuration.GetSection("SendGrid"));
        
        // Registering Twilio
        builder.Services.Configure<TwilioSettings>(builder.Configuration.GetSection("Twilio"));
        
        // Registering Firebase
        builder.Services.Configure<FirebaseSettings>(builder.Configuration.GetSection("Firebase"));
        
        // Registering factories
        builder.Services.AddScoped<EmailNotificationFactory>();
        builder.Services.AddScoped<SmsNotificationFactory>();
        builder.Services.AddScoped<PushNotificationFactory>();
        
        // Registering Notification Services with their respective factories
        builder.Services.AddScoped<INotificationService>(provider =>
        {
            var factories = new Dictionary<NotificationType, INotificationFactory>
            {
                { NotificationType.Email, provider.GetService<EmailNotificationFactory>()! },
                { NotificationType.SMS, provider.GetService<SmsNotificationFactory>()! },
                { NotificationType.Push, provider.GetService<PushNotificationFactory>()! }
            };

            return new NotificationService(factories);
        });
    }
}