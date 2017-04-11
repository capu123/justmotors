using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using justmotors.Controllers.Resources;
using justmotors.Models;
using justmotors.Persistence;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace justmotors.Controllers
{
    public class FeaturesController : Controller
    {
        private readonly JustmotorsDbContext context;
        private readonly IMapper mapper;
        public FeaturesController(JustmotorsDbContext context, IMapper mapper)
        {
            this.mapper = mapper;
            this.context = context;

        }
        
        [HttpGet("/api/features")]
        public async Task<IEnumerable<FeatureResource>> GetFeatures()
        {
            var features = await context.Features.ToListAsync();
            return mapper.Map<List<Feature>, List<FeatureResource>>(features);
        }
    }
}