using Microsoft.Toolkit.Uwp.Notifications;
using Vordr.Application.Common.Interfaces;
using Vordr.Application.StaticData;
using Vordr.Domain.Enums;

namespace Presentation.Implementation;

public class PushNotificaiton : IPushNotifiction
{

    public void Send(string message, AlertType alertType)
    {
            try
            {
                if (SentPushMessages.CanSend(alertType))
                {
                    new ToastContentBuilder()
                        .AddArgument("action", "viewConversation")
                        .AddArgument("conversationId", 9813)
                        .AddText($"VordR system alert.")
                        .AddText(message)
                        .Show();
                    SentPushMessages.MarkSent(alertType);                    
                }

            }
            catch (Exception ex)
            {
                // Handle push notification failure
                return ;
            }
    }
}
