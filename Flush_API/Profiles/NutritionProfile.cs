using AutoMapper;
using Flushed_API.Dtos;
using Flushed_API.Models;

namespace Flushed_API.Profiles
{
    public class NutritionProfile : Profile
    {
        public NutritionProfile()
        {
            //Source -> Target
            CreateMap<Nutrition, NutritionReadDto>();
            CreateMap<NutritionCreateDto, Nutrition>();
            CreateMap<NutritionUpdateDto, Nutrition>();
        }
    }
}
