
using webIntroHW.Context;
using webIntroHW.Entities;

namespace webIntroHW.Repositories;

public class CategoryRepository(AppDbContext dbContext) : ICategoryRepository
{
    private readonly AppDbContext _dbContext = dbContext;
    void ICategoryRepository.Add(Category category)
    {
        _dbContext.Categories.Add(category);
        _dbContext.SaveChanges();
    }

    void ICategoryRepository.Delete(int id)
    {
        var current = _dbContext.Categories.FirstOrDefault(c => c.CategoryID == id);
        if(current != null)
        {
            _dbContext.Categories.Remove(current);
            _dbContext.SaveChanges();
        }
        
    }

    IQueryable<Category> ICategoryRepository.GetAll()
    {
        return _dbContext.Categories;
    }

    Category ICategoryRepository.GetById(int id)
    {
        var current = _dbContext.Categories.FirstOrDefault(c => c.CategoryID == id);
        return current;
    }

    void ICategoryRepository.Update(Category category)
    {
        _dbContext.Update(category);
        _dbContext.SaveChanges();
    }
}
