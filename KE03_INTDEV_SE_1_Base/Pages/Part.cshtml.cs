using DataAccessLayer;
using DataAccessLayer.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace KE03_INTDEV_SE_1_Base.Pages
{
    public class PartModel : PageModel
    {
        private readonly MatrixIncDbContext _context;

        public Part? Part { get; set; }
        public List<Part> RelatedParts { get; set; } = new();

        public PartModel(MatrixIncDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet(int id)
        {
            Part = _context.Parts
                .Include(p => p.Category)
                .FirstOrDefault(p => p.Id == id);

            if (Part == null)
                return NotFound();

            RelatedParts = _context.Parts
                .Where(p => p.CategoryId == Part.CategoryId && p.Id != Part.Id)
                .ToList();

            return Page();
        }
    }
}