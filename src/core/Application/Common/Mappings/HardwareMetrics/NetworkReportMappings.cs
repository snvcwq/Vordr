using Vordr.Application.Models.Hardware.Components;
using Vordr.Domain.Entities;

namespace Vordr.Application.Common.Mappings.HardwareMetrics;

public static class NetworkReportMappings
{
    public static NetworkInformation ToNetworkInformation(this NetworkReport report) =>
        new()
        {
            Network = report.Network,
            DataUploaded = report.DataUploaded,
            DataDownloaded = report.DataDownloaded,
            DownloadSpeed = report.DownloadSpeed,
            UploadSpeed = report.UploadSpeed
        };
}
