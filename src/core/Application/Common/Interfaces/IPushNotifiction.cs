using Vordr.Domain.Enums;

namespace Vordr.Application.Common.Interfaces;

public interface IPushNotifiction
{
    public void Send(string message, AlertType alertType);
}
