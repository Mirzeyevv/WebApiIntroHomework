using webIntroHW.Entities;

namespace webIntroHW.Services;

public interface ICategoryService
{
    Category Add(Category category);

    bool Update(Category category);

    List<Category> GetAll();

    Category GetById(int id);

    bool Delete(int id);

}
