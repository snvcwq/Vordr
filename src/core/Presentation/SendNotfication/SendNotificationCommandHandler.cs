using ErrorOr;
using MailKit.Net.Smtp;
using MailKit.Security;
using MediatR;
using Microsoft.Toolkit.Uwp.Notifications;
using MimeKit;
using Vordr.Application.Common.Extensions;
using Vordr.Application.Common.Interfaces.Persistence;
using Vordr.Application.Notfication.SendNotfication;

namespace Presentation.SendNotfication;

public class SendNotificationCommandHandler(INotificationRepository repository) : IRequestHandler<SendNotificationCommand>
{
    public async Task Handle(SendNotificationCommand request, CancellationToken cancellationToken)
    {
        var config = await repository.GetAsync();
        if (config == null)
            return;

        // Send Email if enabled
        if (config.EmailEnabled)
        {
            try
            {
                var emailMessage = new MimeMessage();
                emailMessage.From.Add(MailboxAddress.Parse(config.SmtpUsername)); 
                emailMessage.To.Add(MailboxAddress.Parse(config.Receiver)); 
                emailMessage.Subject = " Vordr System Alert";
                emailMessage.Body = new TextPart("html")
                {
                    Text = request.Message
                };

                using var smtpClient = new SmtpClient();
                await smtpClient.ConnectAsync(config.SmtpHost, config.SmtpPort, SecureSocketOptions.StartTls, cancellationToken);
                if (!config.SmtpUsername.IsNullOrWhiteSpace() && !config.SmtpPassword.IsNullOrWhiteSpace())
                {
                    await smtpClient.AuthenticateAsync(config.SmtpUsername, config.SmtpPassword, cancellationToken);
                  
                }
                await smtpClient.SendAsync(emailMessage, cancellationToken);
                await smtpClient.DisconnectAsync(true, cancellationToken);  
            }
            catch (Exception ex)
            {
                return;
            }
        }

        if (config.PushNotificationEnabled)
        {
            try
            {
// Requires Microsoft.Toolkit.Uwp.Notifications NuGet package version 7.0 or greater
                new ToastContentBuilder()
                    .AddArgument("action", "viewConversation")
                    .AddArgument("conversationId", 9813)
                    .AddText("Andrew sent you a picture")
                    .AddText("Check this out, The Enchantments in Washington!")
                    .Show();
            }
            catch (Exception ex)
            {
                // Handle push notification failure
                return ;
            }
        }

        return;
    }
}
