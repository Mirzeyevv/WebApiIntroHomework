using Microsoft.EntityFrameworkCore;
using webIntroHW.Context;
using webIntroHW.Entities;

namespace webIntroHW.Repositories;

public class ShipperRepository(AppDbContext dbContext) : IShipperRepository
{

    private readonly AppDbContext _dbContext = dbContext;
    void IShipperRepository.Add(Shipper shipper)
    {
        _dbContext.Shippers.Add(shipper);
        _dbContext.SaveChanges();
    }

    void IShipperRepository.Delete(int id)
    {
        var current = _dbContext.Shippers.FirstOrDefault(c => c.ShipperID == id);
        if (current != null)
        {
            _dbContext.Shippers.Remove(current);
            _dbContext.SaveChanges();
        }
    }

    IQueryable<Shipper> IShipperRepository.GetAll()
    {
        return _dbContext.Shippers;
    }

    Shipper IShipperRepository.GetById(int id)
    {
        var current = _dbContext.Shippers.FirstOrDefault(c => c.ShipperID == id);
        return current;
    }

    void IShipperRepository.Update(Shipper shipper)
    {
        _dbContext.Update(shipper);
        _dbContext.SaveChanges();
    }
}
