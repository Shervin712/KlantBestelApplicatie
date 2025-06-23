using DataAccessLayer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Linq;

namespace KE03_INTDEV_SE_1_Base.Pages.Api
{
    public class SearchProductsModel : PageModel
    {
        private readonly MatrixIncDbContext _context;

        public SearchProductsModel(MatrixIncDbContext context)
        {
            _context = context;
        }

        public JsonResult OnGet(string q)
        {
            if (string.IsNullOrWhiteSpace(q))
                return new JsonResult(Array.Empty<object>());

            var qLower = q.ToLower();

            var results = _context.Products
                .Where(p =>
                    p.Name.ToLower().Contains(qLower) ||
                    p.ArticleNumber.ToLower().Contains(qLower)
                )
                .Select(p => new
                {
                    id = p.Id,
                    name = p.Name,
                    articleNumber = p.ArticleNumber,
                    manufacturer = p.Manufacturer,
                    url = $"/Product/{p.Id}"
                })
                .Take(10)
                .ToList();

            return new JsonResult(results);
        }
    }
}