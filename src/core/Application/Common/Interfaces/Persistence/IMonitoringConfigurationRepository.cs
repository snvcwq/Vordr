using Vordr.Domain.Entities;
using Vordr.Domain.Enums;

namespace Vordr.Application.Common.Interfaces.Persistence;

public interface IMonitoringConfigurationRepository
{
    public Task<ErrorOr<Updated>> UpdateProcessMonitoringAsync(MonitoringStatus status);
    public Task<ErrorOr<Updated>> DefineMaxProcessesToMonitorAsync(int maxProcessesNumber);
    public Task<ErrorOr<Updated>> ExcludeProcessesFromMonitoringAsync(string[] processNames);
    public Task<ErrorOr<Updated>> IncludeProcessesToMonitoringAsync(string[] processNames);
    public Task<ErrorOr<Updated>> UpdateProcessScanFrequencyMonitoringAsync(string frequency);
    public Task<ErrorOr<Updated>> UpdateDrivesMonitoringAsync(MonitoringStatus status);
    public Task<ErrorOr<Updated>> UpdateCpuMonitoringAsync(MonitoringStatus status);
    public Task<ErrorOr<Updated>> UpdateGpuMonitoringAsync(MonitoringStatus status);
    public Task<ErrorOr<Updated>> UpdateRamMonitoringAsync(MonitoringStatus status);
    public Task<ErrorOr<Updated>> UpdateStorageDevicesMonitoringAsync(MonitoringStatus status);
    public Task<ErrorOr<Updated>> UpdateMotherBoardMonitoringAsync(MonitoringStatus status);
    public Task<ErrorOr<Updated>> UpdateNetworkMonitoringAsync(MonitoringStatus status);
    public Task<ErrorOr<Updated>> UpdatePeripheralsMonitoringAsync(MonitoringStatus status);
    public Task<ErrorOr<Updated>> UpdateTemperatureMonitoringAsync(MonitoringStatus status);
    public Task<ErrorOr<Updated>> UpdatePowerSupplyMonitoringAsync(MonitoringStatus status);
    
    public Task<ErrorOr<MonitoringConfiguration>> RetrieveMonitoringConfigurationAsync();

    
}
