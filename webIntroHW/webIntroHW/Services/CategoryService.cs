using webIntroHW.Entities;
using webIntroHW.Repositories;

namespace webIntroHW.Services;

public class CategoryService(ICategoryRepository categoryRepository) : ICategoryService
{

    private readonly ICategoryRepository _categoryRepository = categoryRepository;

    public Category Add(Category category)
    {
        _categoryRepository.Add(category);
        return category;
    }

    public bool Delete(int id)
    {
        _categoryRepository.Delete(id);
        return true;
    }

    public List<Category> GetAll()
    {
        var list = _categoryRepository.GetAll();
        return list.ToList();
    }

    public Category GetById(int id)
    {
        var result = _categoryRepository.GetById(id);
        return result;

    }

    public bool Update(Category category)
    {
        _categoryRepository.Update(category);
        return true;
    }
}
