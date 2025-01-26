namespace Vordr.Infrastructure.Migrations.Configuration;

public record Version(int Major, int Minor, int Patch)
{
    public int Major { get; } = Major;
    public int Minor { get; } = Minor;
    public int Patch { get; } = Patch;

    public override string ToString() =>
        $"{Major}.{Minor}.{Patch}";
    
}
