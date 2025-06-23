using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace KE03_INTDEV_SE_1_Base.Pages
{
    public class PaymentModel : PageModel
    {
        public List<string> Bestelling { get; set; } = new List<string> { "Product A", "Product B", "Product C" };
        public decimal Subtotaal { get; set; } = 60.00m;
        public decimal Totaal { get; set; } = 60.00m;

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            return RedirectToPage("Success");
        }
    }
}
