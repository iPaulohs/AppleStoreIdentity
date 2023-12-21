using AppleStoreIdentity.Models;
using AppleStoreIdentity.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace AppleStoreIdentity.Pages
{
    [Authorize]
    public class CreateDeviceModel : PageModel
    {
        [BindProperty]
        public List<SelectListItem> CategoryOptions { get; set; } = new List<SelectListItem>();
        private readonly IDeviceRepository _deviceRepository;
        private readonly ICategoryRepository _categoryRepository;


        public CreateDeviceModel(IDeviceRepository deviceRepository, ICategoryRepository categoryRepository)
        {
            _deviceRepository = deviceRepository;
            _categoryRepository = categoryRepository;
            CategoryOptions = _categoryRepository
            .GetAll()
            .Select(category => new SelectListItem { Value = category.Id.ToString(), Text = category.Name })
            .ToList();
        }

        public IActionResult OnGet()
        { 
            return Page();
        }

        [BindProperty]
        public Device Device { get; set; } = new Device();

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            Console.WriteLine($"CategoryId selected: {Device.CategoryId}");

            _deviceRepository.AddDevice(Device);

            return RedirectToPage("./Index");
        }
    }
}
