using webIntroHW.Entities;

namespace webIntroHW.Repositories;

public interface ICategoryRepository
{
    void Add(Category category);

    void Update(Category category);

    IQueryable<Category> GetAll ();

    Category GetById(int id);

    void Delete(int id);


}
