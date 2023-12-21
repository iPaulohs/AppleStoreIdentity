using AppleStoreIdentity.Models;
using AppleStoreIdentity.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AppleStoreIdentity.Pages
{
    public class DetailsDeviceModel : PageModel
    {
        private readonly IDeviceRepository _deviceRepository;

        public DetailsDeviceModel(IDeviceRepository deviceRepository)
        {
            _deviceRepository = deviceRepository;
        }

        public Device Device { get; set; } = new Device();

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Device = await _deviceRepository.GetDeviceByIdAsync(id);

            if (Device == null)
            {
                return NotFound();
            }

            return Page();
        }
    }
}
