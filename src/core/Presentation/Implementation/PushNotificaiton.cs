using Microsoft.Toolkit.Uwp.Notifications;
using Vordr.Application.Common.Interfaces;

namespace Presentation.Implementation;

public class PushNotificaiton : IPushNotifiction
{

    public void Send(string message)
    {
            try
            {
// Requires Microsoft.Toolkit.Uwp.Notifications NuGet package version 7.0 or greater
                new ToastContentBuilder()
                    .AddArgument("action", "viewConversation")
                    .AddArgument("conversationId", 9813)
                    .AddText($"VordR system alert.")
                    .AddText(message)
                    .Show();
            }
            catch (Exception ex)
            {
                // Handle push notification failure
                return ;
            }
    }
}
