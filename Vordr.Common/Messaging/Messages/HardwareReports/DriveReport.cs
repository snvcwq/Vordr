namespace Vordr.Common.Messaging.Messages.HardwareReports;

public record DriveReport(string DriveName, double DriveFreeSpace, double DriveTotalSize, System.DateTime CapturedAtUtc)
{
}
