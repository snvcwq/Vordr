namespace Vordr.Common.Messaging.Messages.HardwareReports;

public record NetworkReport
{
    public string Network {get; set; } = string.Empty;
    public double DataUploaded {get; set; }
    public double DataDownloaded{  get; set; }
    public double DownloadSpeed {get; set; }
    public double UploadSpeed { get; set; }
    public System.DateTime CapturedAtUtc { get; set; }
};
