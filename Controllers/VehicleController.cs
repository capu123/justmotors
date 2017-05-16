using justmotors.Models;
using justmotors.Controllers.Resources;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using justmotors.Persistence;
using System.Threading.Tasks;
using System;

namespace justmotors.Controllers
{
    [Route("/api/vehicles")]
    public class VehiclesController : Controller
    {
        private readonly IMapper mapper;
        private readonly JustmotorsDbContext context;
        public VehiclesController(IMapper mapper, JustmotorsDbContext context)
        {
            this.context = context;
            this.mapper = mapper;
        }

        [HttpPost]
        public async Task<IActionResult> CreateVehicle([FromBody] VehicleResource vehicleResource)
        {
            var vehicle = mapper.Map<VehicleResource, Vehicle>(vehicleResource);
            vehicle.LastUpdate = DateTime.Now;

            context.Vehicles.Add(vehicle);
            await context.SaveChangesAsync();

            var result = mapper.Map<Vehicle, VehicleResource>(vehicle);
            return Ok(result);
        }
    }

}