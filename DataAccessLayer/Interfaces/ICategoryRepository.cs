using DataAccessLayer.Models;


namespace DataAccessLayer.Interfaces
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> GetAllCategories();

        Category? GetCategoryById(int id);
        void AddCategory(Category category);
        void UpdateCategory(Category category);
        void DeleteCategory(Category category);
    }
}