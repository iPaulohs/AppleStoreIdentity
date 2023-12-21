using AppleStoreIdentity.Models;
using AppleStoreIdentity.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AppleStoreIdentity.Pages
{
    [Authorize]
    public class DeleteDeviceModel : PageModel
    {
        private readonly IDeviceRepository _deviceRepository;

        public DeleteDeviceModel(IDeviceRepository deviceRepository)
        {
            _deviceRepository = deviceRepository;
        }

        [BindProperty]
        public Device Device { get; set; } = default!;

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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Device = await _deviceRepository.GetDeviceByIdAsync(id);

            if (Device != null)
            {
                await _deviceRepository.DeleteDeviceAsync(Device);
            }

            return RedirectToPage("./Index");
        }
    }
}
