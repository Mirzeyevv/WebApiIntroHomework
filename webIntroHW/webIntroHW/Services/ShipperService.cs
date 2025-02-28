using webIntroHW.Entities;
using webIntroHW.Repositories;

namespace webIntroHW.Services;

public class ShipperService(IShipperRepository shipperRepository ) : IShipperService
{

    private readonly IShipperRepository _shipperRepository = shipperRepository;

    Shipper IShipperService.Add(Shipper shipper)
    {
        _shipperRepository.Add(shipper);
        return shipper;
    }

    bool IShipperService.Delete(int id)
    {
        _shipperRepository.Delete(id);
        return true;
    }

    List<Shipper> IShipperService.GetAll()
    {
        var list = _shipperRepository.GetAll();
        return list.ToList();
    }

    Shipper IShipperService.GetById(int id)
    {
        var result = _shipperRepository.GetById(id);
        return result;
    }

    bool IShipperService.Update(Shipper shipper)
    {
        _shipperRepository.Update(shipper);
        return true;
    }
}
