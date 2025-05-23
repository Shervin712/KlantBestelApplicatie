using DataAccessLayer.Interfaces;
using Microsoft.AspNetCore.Mvc;

public class ProductCategoriesMenuViewComponent : ViewComponent
{
    private readonly ICategoryRepository _categoryRepository;

    public ProductCategoriesMenuViewComponent(ICategoryRepository categoryRepository)
    {
        _categoryRepository = categoryRepository;
    }

    public IViewComponentResult Invoke()
    {
        var categories = _categoryRepository.GetAllCategoriesWithPartsAndProducts();
        return View(categories);
    }
}
