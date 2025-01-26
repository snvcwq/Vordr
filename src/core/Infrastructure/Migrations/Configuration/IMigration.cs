namespace Vordr.Infrastructure.Migrations.Configuration;

public interface IMigration
{

    public Version Version { get; set; }
    
    public string Name { get; set; }
    
    public string Description { get; set; }

    public Task<bool> ExecuteAsync();
}
