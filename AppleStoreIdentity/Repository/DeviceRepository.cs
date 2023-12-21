using AppleStoreIdentity.Database;
using AppleStoreIdentity.Models;

namespace AppleStoreIdentity.Repository;

public class DeviceRepository : IDeviceRepository
{
    private readonly AppleDbContext _db;

    public DeviceRepository(AppleDbContext db) => _db = db;

    public async Task<Device> GetDeviceByIdAsync(int? id)
    {
        return await _db.Devices.FindAsync(id);
    }

    public void AddDevice(Device device)
    {
        _db.Devices.Add(device);
        _db.SaveChanges();
    }

    public void UpdateDevice(Device device)
    {
        _db.Devices.Update(device);
        _db.SaveChanges();
    }

    public async Task DeleteDeviceAsync(Device device)
    {
        _db.Devices.Remove(device);
        await _db.SaveChangesAsync();
    }

    public IList<Device> GetAllDevices()
    {
        return _db.Devices.ToList();
    }
}
