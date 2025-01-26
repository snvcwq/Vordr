using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using MongoDB.Driver;
using System.Reflection;
using Vordr.Infrastructure.Persistence;

namespace Vordr.Infrastructure.Migrations.Configuration;

public class MongoMigrationPerformer(ILogger<MongoMigrationPerformer> logger, MongoDbClient client, IServiceProvider serviceProvider)
{

    private readonly IMongoCollection<Migration> _collection =
        client.Database().GetCollection<Migration>(Migration.GetCollectionName());
    
    
    public async Task PerformMigrationsAsync()
    {
        var executingAssembly = Assembly.GetExecutingAssembly();

        var migrationTypes = executingAssembly.GetTypes()
            .Where(t => typeof(IMigration).IsAssignableFrom(t) && t is { IsInterface: false, IsAbstract: false })
            .ToList();

        var performedMigrations = await GetPerformedMigrations();

        var migrationsToPerform = GetMigrationsToPerform(migrationTypes, performedMigrations);

        if (migrationsToPerform.Count == 0)
        {
            logger.LogInformation("There are no migrations to be performed.");
            return;
        }

        await PerformMigrationsAsync(migrationsToPerform);
    }

    private async Task<IEnumerable<Migration>> GetPerformedMigrations() =>
        await (await _collection.FindAsync(FilterDefinition<Migration>.Empty)).ToListAsync();
    
    private List<IMigration> GetMigrationsToPerform(IEnumerable<Type> migrationTypes, IEnumerable<Migration> performedMigrations)
    {
        var migrationsToPerform = new List<IMigration>();
        performedMigrations = performedMigrations.ToList();
        
        foreach (var migrationType in migrationTypes)
        {
            var migration = (IMigration)serviceProvider.GetRequiredService(migrationType);
            var alreadyPerformed = performedMigrations.Any(m =>
                m.Version == migration.Version && m.Name == migration.Name);

            if (!alreadyPerformed)
            {
                migrationsToPerform.Add(migration);
                break;
            }
            logger.LogInformation($"Migration <{migration.Name}> with version {migration.Version} was already performed, it will not be executed again.");
        }
        return migrationsToPerform;
    }

    private async Task PerformMigrationsAsync(IEnumerable<IMigration> migrations)
    {
        foreach (var migration in migrations)
        {
            logger.LogInformation($"Started performing <{migration.Name}> with version <{migration.Version}>");
            await PerformMigrationAsync(migration);
            logger.LogInformation($"Finished performing <{migration.Name}>");
        }
    }

    private async Task PerformMigrationAsync(IMigration migration)
    {
        var isSuccessful = await migration.ExecuteAsync();

        if (!isSuccessful)
        {
            logger.LogError($"An Error occured when performing {migration.Name}. migration's execution will not be saved in Db.");
            return;
        }
        await _collection.InsertOneAsync(new Migration
        {
            Version = migration.Version,
            Name = migration.Name,
            Description = migration.Description,
            PerformedDateTimeUtc = DateTime.UtcNow
        });
    }
    
    
}
