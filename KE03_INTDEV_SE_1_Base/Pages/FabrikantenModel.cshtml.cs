using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using System.Linq;

namespace DataAccessLayer.Models
{
    public class FabrikantenModel : PageModel
    {
        private readonly MatrixIncDbContext _context;

        public FabrikantenModel(MatrixIncDbContext context)
        {
            _context = context;
        }

        public Dictionary<string, List<Fabrikant>> Groepering { get; set; }

        public void OnGet()
        {
            var fabrikanten = _context.Fabrikanten.ToList();

            Groepering = fabrikanten
                .GroupBy(f => char.IsDigit(f.Naam[0]) ? "#" : f.Naam[0].ToString().ToUpper())
                .OrderBy(g => g.Key == "#" ? "0" : g.Key) // # eerst
                .ToDictionary(g => g.Key, g => g.ToList());
        }
    }
}
