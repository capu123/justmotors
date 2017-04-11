using AutoMapper;
using justmotors.Controllers.Resources;
using justmotors.Models;

namespace justmotors.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Make, MakeResource>(); 
            CreateMap<Model, ModelResource>();
            CreateMap<Feature, FeatureResource>();
        }
    }
}