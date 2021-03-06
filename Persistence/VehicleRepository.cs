using System.Threading.Tasks;
using justmotors.Models;
using Microsoft.EntityFrameworkCore;

namespace justmotors.Persistence
{
    public class VehicleRepository : IVehicleRepository
    {
        private readonly JustmotorsDbContext context;
        public VehicleRepository(JustmotorsDbContext context)
        {
            this.context = context;
        }

        public async Task<Vehicle> GetVehicle(int id, bool includeRelated = true)
        {
            if(includeRelated != false)
                return await context.Vehicles.FindAsync(id);

            return await context.Vehicles
                    .Include(v => v.Features)
                        .ThenInclude(vf => vf.Feature)
                    .Include(v => v.Model)
                        .ThenInclude(m => m.Make)
                    .SingleOrDefaultAsync(v => v.Id == id);
        }


        public void Add(Vehicle vehicle)
        {
            context.Vehicles.Add(vehicle);
        }

        public void Remove(Vehicle vehicle)
        {
            context.Remove(vehicle);
        }
    }
}