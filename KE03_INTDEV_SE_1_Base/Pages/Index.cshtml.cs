using DataAccessLayer.Interfaces;
using DataAccessLayer.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

public class IndexModel : PageModel
{
    private readonly ICategoryRepository _categoryRepository;
    public List<Category> Categories { get; set; } = new();

    public IndexModel(ICategoryRepository categoryRepository)
    {
        _categoryRepository = categoryRepository;
    }

    public void OnGet()
    {
        ViewData["Categories"] = _categoryRepository.GetAllCategories();
    }

}