using DesignPatterns.FactoryMethod.NotificationSystem.Api.ConfigurationServices;
using DesignPatterns.FactoryMethod.NotificationSystem.Api.Models;
using DesignPatterns.FactoryMethod.NotificationSystem.Application.Interfaces;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.AddNotificationServices(); // AddNotificationServices extension method
var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseHttpsRedirection();

// Route to send notification
app.MapPost("/api/send-notification", async(INotificationService service, NotificationRequest request) =>
{
    var model = NotificationRequest.ToModelApplication(request);
    await service.SendAsync(model);
    return Results.Ok("Notification sent successfully");
});

app.Run("http://localhost:5000");
