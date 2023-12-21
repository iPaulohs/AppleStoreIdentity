using AppleStoreIdentity.Models;
using AppleStoreIdentity.Repository;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AppleStoreIdentity.Pages
{
    public class IndexModel : PageModel
    {
        private readonly IDeviceRepository _repository;

        public IndexModel(IDeviceRepository repository)
        {
            _repository = repository;
        }

        public IList<Device> Device { get; set; }

        public async Task OnGetAsync()
        {
            var _devices = _repository.GetAllDevices();
            Device = _devices;
        }
    }
}
