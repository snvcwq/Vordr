using Vordr.Domain.Common;

namespace Vordr.Domain.Entities;

public record NetworkInformation : BaseMetric
{
    public required string Network {get; set; }
    public required double DataUploaded {get; set; }
    public required double DataDownloaded{  get; set; }
    public required double DownloadSpeed {get; set; }
    public required double UploadSpeed { get; set; }
}
