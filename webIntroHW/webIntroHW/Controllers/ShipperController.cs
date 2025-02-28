using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using webIntroHW.Entities;
using webIntroHW.Services;

namespace webIntroHW.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ShipperController(IShipperService shipperService) : ControllerBase
{

    private readonly IShipperService _shipperService = shipperService;

    [HttpPost]
    public IActionResult AddShipper(Shipper shipper)
    {
        var newShipper = _shipperService.Add(shipper);
        return Ok(newShipper);
    }

    [HttpGet]

    public IActionResult GetAllShippers()
    {
        var shipperList = _shipperService.GetAll();
        return Ok(shipperList);
    }

    [HttpGet("id")]
    public IActionResult GetById([FromQuery] int id)
    {
        var shipper = _shipperService.GetById(id);
        return Ok(shipper);
    }

    [HttpDelete("id")]

    public IActionResult DeleteById(int id)
    {

        var isDeleted = _shipperService.Delete(id);
        return Ok(isDeleted);

    }




}
