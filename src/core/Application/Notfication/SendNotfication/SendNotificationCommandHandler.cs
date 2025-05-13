using MailKit.Net.Smtp;
using MailKit.Security;
using MimeKit;
using Vordr.Application.Common.Extensions;
using Vordr.Application.Common.Interfaces.Persistence;
using Vordr.Application.StaticData;

namespace Vordr.Application.Notfication.SendNotfication;

public class SendNotificationCommandHandler(INotificationRepository repository) : IRequestHandler<SendNotificationCommand>
{
    private const string html =
        "<!DOCTYPE html>\n<html lang=\"en\">\n<head>\n    <meta charset=\"UTF-8\">\n    <style>\n        body {\n            font-family: \"Segoe UI\", sans-serif;\n            background-color: #f5f7fc;\n            color: #333;\n            padding: 20px;\n        }\n        .container {\n            background-color: #ffffff;\n            border-radius: 12px;\n            padding: 24px;\n            max-width: 600px;\n            margin: auto;\n            box-shadow: 0 4px 12px rgba(0, 0, 0, 0.06);\n            border-top: 6px solid #6d7dfd;\n        }\n        .header {\n            font-size: 20px;\n            font-weight: 600;\n            margin-bottom: 16px;\n            color: #3c4eea;\n        }\n        .message {\n            font-size: 15px;\n            line-height: 1.6;\n        }\n        .footer {\n            margin-top: 24px;\n            font-size: 12px;\n            color: #888;\n            text-align: center;\n        }\n    </style>\n</head>\n<body>\n    <div class=\"container\">\n        <div class=\"header\">\ud83d\udd14 Vordr System Alert</div>\n        <div class=\"message\">\n            {{MessageContent}}\n        </div>\n        <div class=\"footer\">\n            This message was generated automatically by the Vordr monitoring system.\n        </div>\n    </div>\n</body>\n</html>";    public async Task Handle(SendNotificationCommand request, CancellationToken cancellationToken)
    {
        var config = await repository.GetAsync();
        if (config == null)
            return;
        if (!SentMessages.CanSend(request.AlertType))
            return;
        
        SentMessages.MarkSent(request.AlertType);
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
                    Text = html.Replace("{{MessageContent}}", request.Message)
                };

                using var smtpClient = new SmtpClient();
                await smtpClient.ConnectAsync(config.SmtpHost, config.SmtpPort, SecureSocketOptions.SslOnConnect, cancellationToken);
                if (!config.SmtpUsername.IsNullOrWhiteSpace() && !config.SmtpPassword.IsNullOrWhiteSpace())
                {
                    await smtpClient.AuthenticateAsync(config.SmtpUsername, config.SmtpPassword, cancellationToken);
                  
                }
                await smtpClient.SendAsync(emailMessage, cancellationToken);
                await smtpClient.DisconnectAsync(true, cancellationToken);  
            }
            catch (Exception)
            {
                return;
            }
        }

        return;
    }
}
