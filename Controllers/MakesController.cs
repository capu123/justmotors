using System.Collections.Generic;
using System.Threading.Tasks;
using justmotors.Models;
using justmotors.Persistence;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace justmotors.Controllers
{
    public class MakesController : Controller
    {
        private readonly JustmotorsDbContext context;
        public MakesController(JustmotorsDbContext context)
        {
            this.context = context;

        }

        [HttpGet("/api/makes")]
        public async Task<IEnumerable<Make>> GetMakes()
        {
            return await context.Makes.Include(m => m.Models).ToListAsync();
        }
    }
}