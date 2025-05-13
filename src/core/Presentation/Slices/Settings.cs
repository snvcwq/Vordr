using MediatR;
using MongoDB.Bson;
using Vordr.Application.Notfication.GetNotificationConfig;
using Vordr.Application.Notfication.UpdateConfig;
using Vordr.Domain.Entities;

namespace Presentation.Slices;
public partial class Settings : Form
{
    private readonly ISender _sender;
    public Settings(ISender sender)
    {
        this._sender = sender;
        InitializeComponent();
    }

    protected override async void OnLoad(EventArgs e)
    {
        try
        {
            base.OnLoad(e);
            var config = await _sender.Send(new GetNotificationConfigQuery());

            SmtpHostTextBox.Content = config.SmtpHost;
            SmtpPortTextBox.Content = config.SmtpPort.ToString();
            SmtpUsernameTextBox.Content = config.SmtpUsername;
            SmtpPasswordTextBox.Content = config.SmtpPassword;
            EmailNotificationSwitch.Checked = config.EmailEnabled;
            PushNotificationSwitchț.Checked = config.PushNotificationEnabled;
            EmailLabel.Content = config.Receiver;
        }
        catch (Exception exception)
        {
            // ignored
        }
    }

    private async void SaveButton_Click(object sender, EventArgs e)
    {
        Thread.Sleep(50);
        var config = new NotificationConfig
        {
            Id = new ObjectId(),
            SmtpHost = SmtpHostTextBox.Content,
            SmtpPort = int.TryParse(SmtpPortTextBox.Content, out var port) ? port : 587,
            SmtpUsername = SmtpUsernameTextBox.Content,
            SmtpPassword = SmtpPasswordTextBox.Content,
            EmailEnabled = EmailNotificationSwitch.Checked,
            PushNotificationEnabled = PushNotificationSwitchț.Checked,
            Receiver = EmailLabel.Content,
            UpdatedAtUtc = DateTime.UtcNow
        };
        await _sender.Send(new UpdateConfigCommand(config));
    }
}
