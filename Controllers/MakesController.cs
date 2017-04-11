using System.Collections.Generic;
using System.Threading.Tasks;
using justmotors.Models;
using justmotors.Persistence;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AutoMapper;
using justmotors.Controllers.Resources;

namespace justmotors.Controllers
{
    public class MakesController : Controller
    {
        private readonly JustmotorsDbContext context;
        private readonly IMapper mapper;
        public MakesController(JustmotorsDbContext context, IMapper mapper)
        {
            this.mapper = mapper;
            this.context = context;

        }

        [HttpGet("/api/makes")]
        public async Task<IEnumerable<MakeResource>> GetMakes()
        {
            var makes = await context.Makes.Include(m => m.Models).ToListAsync();

            return mapper.Map<List<Make>, List<MakeResource>>(makes);
        }
    }
}