using DesignPatterns.FactoryMethod.NotificationSystem.Infrastructure.Pushes;
using FirebaseAdmin;
using FirebaseAdmin.Messaging;
using Google.Apis.Auth.OAuth2;
using Notification = DesignPatterns.FactoryMethod.NotificationSystem.Application.Models.Notification;

namespace DesignPatterns.FactoryMethod.NotificationSystem.Infrastructure.Notifications.Pushes;

public class PushNotificationSender : INotification
{
    private readonly FirebaseMessaging _firebaseMessaging;
    public PushNotificationSender(IOptions<FirebaseSettings> options)
    {
        var settings = options.Value;
        var app = FirebaseApp.Create(new AppOptions
        {
            Credential = GoogleCredential.FromFile(settings.CredentialsPath),
            ProjectId = settings.ProjectId
        });
        _firebaseMessaging = FirebaseMessaging.GetMessaging(app);
    }

    public Task SendAsync(Notification notification, CancellationToken cancellationToken = default)
    {
        // Implement push notification sending logic
        throw new NotImplementedException();
    }
}