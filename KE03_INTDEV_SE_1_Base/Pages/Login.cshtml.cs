using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace KE03_INTDEV_SE_1_Base.Pages
{
    public class LoginModel : PageModel
    {
        [BindProperty]
        public string LoginEmail { get; set; }
        [BindProperty]
        public string LoginPassword { get; set; }
        [BindProperty]
        public bool RememberMe { get; set; }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            // Hier komt je loginlogica
            if (LoginEmail == "123@test.com" && LoginPassword == "wachtwoord")
            {
                // Succesvolle login
                return RedirectToPage("/Checkout");
            }
            // Mislukte login
            ModelState.AddModelError(string.Empty, "Ongeldige inloggegevens");
            return Page();
        }
    }
}
