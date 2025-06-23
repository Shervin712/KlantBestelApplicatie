using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace KE03_INTDEV_SE_1_Base.Pages
{
    public class CheckoutModel : PageModel
    {
        [BindProperty]
        public string Titel { get; set; }
        [BindProperty]
        public string Voornaam { get; set; }
        [BindProperty]
        public string Achternaam { get; set; }
        [BindProperty]
        public string Straatnaam { get; set; }
        [BindProperty]
        public string Huisnummer { get; set; }
        [BindProperty]
        public string Plaats { get; set; }
        [BindProperty]
        public string Land { get; set; }
        [BindProperty]
        public string Postcode { get; set; }
        [BindProperty]
        public string Telefoonnummer { get; set; }

        public List<string> Bestelling { get; set; } = new List<string> { "Product A", "Product B", "Product C" };
        public decimal Subtotaal { get; set; } = 60.00m;
        public decimal Totaal { get; set; } = 60.00m;

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            // Hier kan je je logica voor opslaan/verwerken doen
            return RedirectToPage("Payment");
        }
    }
}
