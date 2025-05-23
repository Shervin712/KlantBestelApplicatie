using DataAccessLayer.Models;

public interface ICategoryRepository
{
    IEnumerable<Category> GetAllCategories();
    IEnumerable<Category> GetAllCategoriesWithPartsAndProducts();

    Category? GetCategoryById(int id);
    void AddCategory(Category category);
    void UpdateCategory(Category category);
    void DeleteCategory(Category category);
}