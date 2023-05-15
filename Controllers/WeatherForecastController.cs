using Microsoft.AspNetCore.Mvc;
using Web_API_Training_Template.Models;

namespace Web_API_Training_Template.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    private readonly NorthwindDB NorthwindDB;
    public WeatherForecastController(NorthwindDB NorthwindDB_)
    {
        NorthwindDB = NorthwindDB_;
    }

    [HttpGet("ex1")]
    public IEnumerable<Order> Get()
    {
        return NorthwindDB.Orders.ToList();
    }
}

