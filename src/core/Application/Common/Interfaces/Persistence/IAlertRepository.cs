
namespace Vordr.Application.Common.Interfaces.Persistence;

public interface IAlertRepository
{
    public Task<IEnumerable<Domain.Entities.Alert>> GetAllAsync();
    public Task<Domain.Entities.Alert> GetByTypeAsync(Domain.Enums.AlertType alertTypeType);
    public Task<Domain.Entities.Alert> UpdateAsync(Domain.Entities.Alert alert);
}
