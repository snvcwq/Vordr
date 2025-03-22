namespace Vordr.Application.Models.Hardware.Components;

public record DriveReport(string DriveName, double DriveFreeSpace, double DriveTotalSize, System.DateTime CapturedAtUtc)
{
}
