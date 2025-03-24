namespace Vordr.ResourcesMonitoring.Windows.Process;

public static class SystemService
{
    public static List<string> KnownSystemPaths = new()
    {
        @"C:\Windows\explorer.exe",
        @"C:\Windows\System32\ntoskrnl.exe",
        @"C:\Windows\System32\WerFault.exe",
        @"C:\Windows\System32\backgroundTaskHost.exe",
        @"C:\Windows\System32\backgroundTransferHost.exe",
        @"C:\Windows\System32\winlogon.exe",
        @"C:\Windows\System32\wininit.exe",
        @"C:\Windows\System32\csrss.exe",
        @"C:\Windows\System32\lsass.exe",
        @"C:\Windows\System32\smss.exe",
        @"C:\Windows\System32\services.exe",
        @"C:\Windows\System32\taskeng.exe",
        @"C:\Windows\System32\taskhost.exe",
        @"C:\Windows\System32\dwm.exe",
        @"C:\Windows\System32\conhost.exe",
        @"C:\Windows\System32\svchost.exe",
        @"C:\Windows\System32\sihost.exe"
    };
}
