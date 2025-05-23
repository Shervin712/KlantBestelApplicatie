using DataAccessLayer.Interfaces;
using DataAccessLayer.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace KE03_INTDEV_SE_1_Base.Pages
{
    public class ProductModel : PageModel
    {
        private readonly IPartRepository _partRepository;

        public List<Part> Parts { get; set; } = new();

        public ProductModel(IPartRepository partRepository)
        {
            _partRepository = partRepository;
        }

        public void OnGet()
        {
            Parts = _partRepository.GetAllParts().ToList();
        }
    }
}
