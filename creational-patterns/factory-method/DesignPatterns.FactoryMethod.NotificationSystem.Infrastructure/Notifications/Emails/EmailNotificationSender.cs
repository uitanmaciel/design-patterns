using SendGrid;
using SendGrid.Helpers.Mail;

namespace DesignPatterns.FactoryMethod.NotificationSystem.Infrastructure.Notifications.Emails;

public class EmailNotificationSender(IOptions<SendGridSettings> options) : INotification
{
    private readonly SendGridSettings _sendGridSettings = options.Value;


    public Task SendAsync(Notification notification, CancellationToken cancellationToken = default)
    {
        // Implement Email sending logic here
        throw new NotImplementedException();
    }
}