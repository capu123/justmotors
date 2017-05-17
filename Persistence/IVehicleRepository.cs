using System.Threading.Tasks;
using justmotors.Models;

namespace justmotors.Persistence
{
    public interface IVehicleRepository
    {
         Task<Vehicle> GetVehicle(int id);
    }
}