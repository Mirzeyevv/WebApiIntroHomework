using webIntroHW.Entities;

namespace webIntroHW.Services;

public interface IShipperService
{
    Shipper Add(Shipper shipper);

    bool Update(Shipper shipper);

    List<Shipper> GetAll();

    Shipper GetById(int id);

    bool Delete(int id);
}
