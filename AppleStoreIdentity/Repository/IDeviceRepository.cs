using AppleStoreIdentity.Models;

namespace AppleStoreIdentity.Repository;

public interface IDeviceRepository
{
    public void AddDevice(Device device);
    public void UpdateDevice(Device device);
    Task<Device> GetDeviceByIdAsync(int? id);
    Task DeleteDeviceAsync(Device device);
    public IList<Device> GetAllDevices();
}
