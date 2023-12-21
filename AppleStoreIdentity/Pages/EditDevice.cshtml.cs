using AppleStoreIdentity.Models;
using AppleStoreIdentity.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;

namespace AppleStoreIdentity.Pages;

[Authorize]
public class EditDeviceModel : PageModel
{
    private readonly IDeviceRepository _deviceRepository;

    public EditDeviceModel(IDeviceRepository deviceRepository)
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

        var device = await _deviceRepository.GetDeviceByIdAsync(id);
        if (device == null)
        {
            return NotFound();
        }

        Device = device;
        return Page();
    }

    public IActionResult OnPost()
    {
        if (!ModelState.IsValid)
        {
            return Page();
        }

        _deviceRepository.UpdateDevice(Device);

        return RedirectToPage("./Index");
    }
}
