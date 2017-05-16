using justmotors.Models;
using Microsoft.AspNetCore.Mvc;

namespace justmotors.Controllers
{
    [Route("/api/vehicles")]
    public class VehiclesController : Controller
    {
        [HttpPost]
       public IActionResult CreateVehicle(Vehicle vehicle)
       {
           return Ok(vehicle);
       }
    }

}