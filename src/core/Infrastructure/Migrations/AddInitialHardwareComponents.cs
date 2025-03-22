using Cronos;
using MediatR;
using MongoDB.Bson;
using MongoDB.Driver;
using Vordr.Application.Common.Interfaces.Resources;
using Vordr.Application.HardwareComponent.Commands;
using Vordr.Domain.Entities;
using Vordr.Domain.Enums;
using Vordr.Infrastructure.Constants;
using Vordr.Infrastructure.Migrations.Configuration;
using Vordr.Infrastructure.Persistence;
using Version = Vordr.Infrastructure.Migrations.Configuration.Version;

namespace Vordr.Infrastructure.Migrations;

public class AddInitialHardwareComponents(
    ISender sender,
    ILogger<AddInitialHardwareComponents> logger)
    : IMigration
{
    
    public Version Version { get; set; } = new(1, 2, 0);
    public string Name { get; set; } = nameof(AddInitialHardwareComponents);
    public string Description { get; set; } = "Add initial hardware description";

    public async Task<bool> ExecuteAsync()
    {

        try
        {
            await sender.Send(new UpdateHardwareComponent());
        }
        catch (Exception e)
        {
            logger.LogError("An error occured when executing {@MigrationName}. Message: {@ErrorMessage}", Name, e.Message);
            return false;
        }
        return true;
    }
}
