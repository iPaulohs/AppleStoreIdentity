using AppleStoreIdentity.Domain.ViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AppleStoreIdentity.Pages;

[AllowAnonymous]
public class LoginModel : PageModel
{
    [BindProperty]
    public LoginViewModel ViewModel { get; set; }
    private readonly SignInManager<IdentityUser> _signInManager;

    public LoginModel(SignInManager<IdentityUser> signInManager)
    {
        _signInManager = signInManager;
        ViewModel = new();
    }

    public async Task<IActionResult> OnPostLoginAsync()
    {
        if (ModelState.IsValid)
        {
            var result = await _signInManager.PasswordSignInAsync(ViewModel.Email, ViewModel.Password, ViewModel.RememberMe, false);
            await Console.Out.WriteLineAsync(ViewModel.Email);
            await Console.Out.WriteLineAsync(ViewModel.Password);


            if (result.Succeeded)
            {
                await Console.Out.WriteLineAsync("Deu tudo certo.");
                return RedirectToPage("Index");
            }
            else
            {
                ModelState.AddModelError(string.Empty, "Falha ao fazer login. Verifique suas credenciais.");
            }
        }
        return Page();
    }

    public void OnGet()
    {

    }
}
