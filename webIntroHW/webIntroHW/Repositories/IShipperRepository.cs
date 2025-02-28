using webIntroHW.Entities;

namespace webIntroHW.Repositories;

public interface IShipperRepository
{
    void Add(Shipper shipper);

    void Update(Shipper shipper);

    IQueryable<Shipper> GetAll();

    Shipper GetById(int id);

    void Delete(int id);
}
